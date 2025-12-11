using Final_Programacion.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Final_Programacion
{
    public partial class ConvertirArchivos : Form
    {
        private string carpetaArchivos;
        private string formatoOrigen = "";
        private string rutaOrigen = "";
        private List<Alumno> alumnosOrigen = new List<Alumno>();

        public ConvertirArchivos()
        {
            InitializeComponent();

            string carpetaProyecto =
                Directory.GetParent(Application.StartupPath)  // net8.0-windows
                         .Parent                             // Debug
                         .Parent                             // bin
                         .Parent                             // Final Programacion
                         .FullName;                          // final-programacion

            carpetaArchivos = Path.Combine(carpetaProyecto, "Registros");
            if (!Directory.Exists(carpetaArchivos))
                Directory.CreateDirectory(carpetaArchivos);

            cmbFormatoDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            lblFormatoOrigen.Text = "Formato detectado: (sin cargar)";
        }

        // ============================
        // CARGAR ORIGEN + DETECTAR FORMATO
        // ============================
        private void btnCargarOrigen_Click(object sender, EventArgs e)
        {
            string nombreArchivo = txtArchivoOrigen.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombreArchivo))
            {
                MessageBox.Show("Ingrese el nombre del archivo de origen.");
                return;
            }

            // 1) Si NO tiene punto, intento adivinar la extensión
            if (!nombreArchivo.Contains("."))
            {
                string[] posiblesExt = { ".txt", ".csv", ".json", ".xml" };
                string rutaEncontrada = null;

                foreach (string ext in posiblesExt)
                {
                    string rutaPrueba = Path.Combine(carpetaArchivos, nombreArchivo + ext);
                    if (File.Exists(rutaPrueba))
                    {
                        rutaEncontrada = rutaPrueba;
                        break;
                    }
                }

                if (rutaEncontrada == null)
                {
                    MessageBox.Show("No se encontró el archivo con ninguna de estas extensiones: TXT, CSV, JSON o XML.");
                    return;
                }

                rutaOrigen = rutaEncontrada;
            }
            else
            {
                // 2) Si TIENE extensión, uso ese nombre tal cual
                rutaOrigen = Path.Combine(carpetaArchivos, nombreArchivo);

                if (!File.Exists(rutaOrigen))
                {
                    MessageBox.Show("El archivo de origen no existe en la carpeta Archivos.");
                    return;
                }
            }

            // Detectar formato por extensión REAL del archivo encontrado
            string extReal = Path.GetExtension(rutaOrigen).ToLowerInvariant();
            switch (extReal)
            {
                case ".txt": formatoOrigen = "TXT"; break;
                case ".csv": formatoOrigen = "CSV"; break;
                case ".json": formatoOrigen = "JSON"; break;
                case ".xml": formatoOrigen = "XML"; break;
                default:
                    MessageBox.Show("Extensión no soportada. Use TXT, CSV, JSON o XML.");
                    return;
            }

            // Cargar alumnos desde ese archivo
            alumnosOrigen = CargarAlumnos(rutaOrigen, formatoOrigen);

            if (alumnosOrigen == null || alumnosOrigen.Count == 0)
            {
                MessageBox.Show("El archivo no contiene registros válidos.");
                formatoOrigen = "";
                lblFormatoOrigen.Text = "Formato detectado: (sin cargar)";
                return;
            }

            lblFormatoOrigen.Text = $"Formato detectado: {formatoOrigen}";

            // Llenar formatos de destino (todos menos el actual)
            cmbFormatoDestino.Items.Clear();
            if (formatoOrigen != "TXT") cmbFormatoDestino.Items.Add("TXT");
            if (formatoOrigen != "CSV") cmbFormatoDestino.Items.Add("CSV");
            if (formatoOrigen != "JSON") cmbFormatoDestino.Items.Add("JSON");
            if (formatoOrigen != "XML") cmbFormatoDestino.Items.Add("XML");

            if (cmbFormatoDestino.Items.Count > 0)
                cmbFormatoDestino.SelectedIndex = 0;

            MessageBox.Show($"Archivo cargado correctamente.\nRegistros leídos: {alumnosOrigen.Count}");
        }


        // ============================
        // CONVERTIR
        // ============================
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(formatoOrigen) || alumnosOrigen.Count == 0)
            {
                MessageBox.Show("Primero cargue un archivo de origen.");
                return;
            }

            if (cmbFormatoDestino.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un formato de destino.");
                return;
            }

            string formatoDestino = cmbFormatoDestino.SelectedItem.ToString();
            string nombreDestino = txtArchivoDestino.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombreDestino))
            {
                MessageBox.Show("Ingrese el nombre del archivo de destino (sin extensión).");
                return;
            }

            string extensionDestino = formatoDestino.ToLowerInvariant();
            string rutaDestino = Path.Combine(carpetaArchivos, nombreDestino + "." + extensionDestino);

            try
            {
                GuardarArchivo(rutaDestino, formatoDestino, alumnosOrigen);

                MessageBox.Show(
                    "✓ Conversión exitosa\n\n" +
                    $"Archivo origen: {Path.GetFileName(rutaOrigen)} ({alumnosOrigen.Count} registros)\n" +
                    $"Archivo destino: {Path.GetFileName(rutaDestino)} ({alumnosOrigen.Count} registros)",
                    "Conversión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al convertir: " + ex.Message);
            }
        }

        // ============================
        // CARGAR ALUMNOS SEGÚN FORMATO
        // ============================
        private List<Alumno> CargarAlumnos(string ruta, string formato)
        {
            List<Alumno> lista = new List<Alumno>();

            if (formato == "TXT")
            {
                var lineas = File.ReadAllLines(ruta, Encoding.UTF8);
                foreach (var linea in lineas)
                {
                    if (string.IsNullOrWhiteSpace(linea)) continue;
                    var partes = linea.Split('|');
                    if (partes.Length < 6) continue;

                    lista.Add(new Alumno
                    {
                        Legajo = partes[0],
                        Apellido = partes[1],
                        Nombres = partes[2],
                        NumeroDocumento = partes[3],
                        Email = partes[4],
                        Telefono = partes[5]
                    });
                }
            }
            else if (formato == "CSV")
            {
                var lineas = File.ReadAllLines(ruta, Encoding.UTF8);
                bool primera = true;

                foreach (var linea in lineas)
                {
                    if (string.IsNullOrWhiteSpace(linea)) continue;

                    // saltamos encabezado si existe
                    if (primera && linea.ToLower().Contains("legajo"))
                    {
                        primera = false;
                        continue;
                    }
                    primera = false;

                    var partes = linea.Split(',');
                    if (partes.Length < 6) continue;

                    lista.Add(new Alumno
                    {
                        Legajo = partes[0],
                        Apellido = partes[1],
                        Nombres = partes[2],
                        NumeroDocumento = partes[3],
                        Email = partes[4],
                        Telefono = partes[5]
                    });
                }
            }
            else if (formato == "JSON")
            {
                string contenido = File.ReadAllText(ruta, Encoding.UTF8);
                var des = JsonSerializer.Deserialize<List<Alumno>>(contenido);
                if (des != null)
                    lista = des;
            }
            else if (formato == "XML")
            {
                XDocument doc = XDocument.Load(ruta);

                foreach (var a in doc.Descendants("Alumno"))
                {
                    lista.Add(new Alumno
                    {
                        Legajo = a.Element("Legajo")?.Value,
                        Apellido = a.Element("Apellido")?.Value,
                        Nombres = a.Element("Nombres")?.Value,
                        NumeroDocumento = a.Element("NumeroDocumento")?.Value,
                        Email = a.Element("Email")?.Value,
                        Telefono = a.Element("Telefono")?.Value
                    });
                }
            }

            return lista;
        }

        // ============================
        // GUARDAR SEGÚN FORMATO
        // ============================
        private void GuardarArchivo(string ruta, string formatoDestino, List<Alumno> alumnos)
        {
            switch (formatoDestino)
            {
                case "TXT":
                    GuardarComoTXT(ruta, alumnos);
                    break;
                case "CSV":
                    GuardarComoCSV(ruta, alumnos);
                    break;
                case "JSON":
                    GuardarComoJSON(ruta, alumnos);
                    break;
                case "XML":
                    GuardarComoXML(ruta, alumnos);
                    break;
            }
        }

        private void GuardarComoTXT(string ruta, List<Alumno> alumnos)
        {
            using (StreamWriter writer = new StreamWriter(ruta, false, Encoding.UTF8))
            {
                foreach (var alumno in alumnos)
                {
                    string linea = $"{alumno.Legajo}|{alumno.Apellido}|{alumno.Nombres}|" +
                                   $"{alumno.NumeroDocumento}|{alumno.Email}|{alumno.Telefono}";
                    writer.WriteLine(linea);
                }
            }
        }

        private void GuardarComoCSV(string ruta, List<Alumno> alumnos)
        {
            using (StreamWriter writer = new StreamWriter(ruta, false, Encoding.UTF8))
            {
                writer.WriteLine("Legajo,Apellido,Nombres,NumeroDocumento,Email,Telefono");

                foreach (var alumno in alumnos)
                {
                    string linea = $"{alumno.Legajo},{alumno.Apellido},{alumno.Nombres}," +
                                   $"{alumno.NumeroDocumento},{alumno.Email},{alumno.Telefono}";
                    writer.WriteLine(linea);
                }
            }
        }

        private void GuardarComoJSON(string ruta, List<Alumno> alumnos)
        {
            using (StreamWriter writer = new StreamWriter(ruta, false, Encoding.UTF8))
            {
                writer.WriteLine("[");
                for (int i = 0; i < alumnos.Count; i++)
                {
                    var a = alumnos[i];
                    string bloque =
                        "  {\n" +
                        $"    \"Legajo\": \"{a.Legajo}\",\n" +
                        $"    \"Apellido\": \"{a.Apellido}\",\n" +
                        $"    \"Nombres\": \"{a.Nombres}\",\n" +
                        $"    \"NumeroDocumento\": \"{a.NumeroDocumento}\",\n" +
                        $"    \"Email\": \"{a.Email}\",\n" +
                        $"    \"Telefono\": \"{a.Telefono}\"\n" +
                        "  }";

                    writer.Write(bloque);
                    if (i < alumnos.Count - 1)
                        writer.WriteLine(",");
                    else
                        writer.WriteLine();
                }
                writer.WriteLine("]");
            }
        }

        private void GuardarComoXML(string ruta, List<Alumno> alumnos)
        {
            using (StreamWriter writer = new StreamWriter(ruta, false, Encoding.UTF8))
            {
                writer.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
                writer.WriteLine("<Alumnos>");

                foreach (var a in alumnos)
                {
                    writer.WriteLine("  <Alumno>");
                    writer.WriteLine($"    <Legajo>{a.Legajo}</Legajo>");
                    writer.WriteLine($"    <Apellido>{a.Apellido}</Apellido>");
                    writer.WriteLine($"    <Nombres>{a.Nombres}</Nombres>");
                    writer.WriteLine($"    <NumeroDocumento>{a.NumeroDocumento}</NumeroDocumento>");
                    writer.WriteLine($"    <Email>{a.Email}</Email>");
                    writer.WriteLine($"    <Telefono>{a.Telefono}</Telefono>");
                    writer.WriteLine("  </Alumno>");
                }

                writer.WriteLine("</Alumnos>");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
