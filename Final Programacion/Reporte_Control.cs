using Final_Programacion.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Final_Programacion
{
    public partial class Reporte_Control : Form
    {
        private string reporteGenerado = "";
        private List<Alumno> alumnosCargados = new List<Alumno>();

        public Reporte_Control()
        {
            InitializeComponent();
            cmbExtension.Items.Add("TXT");
            cmbExtension.Items.Add("CSV");
            cmbExtension.Items.Add("JSON");
            cmbExtension.Items.Add("XML");
            cmbExtension.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbExtension.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una extensión.");
                return;
            }

            string formato = cmbExtension.SelectedItem.ToString();
            string nombreArchivo = txtNombre.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombreArchivo))
            {
                MessageBox.Show("Ingrese un nombre de archivo.");
                return;
            }

            string extension = formato.ToLower();
            string carpeta = Path.Combine(Application.StartupPath, "Archivos");
            string archivo = Path.Combine(carpeta, $"{nombreArchivo}.{extension}");

            if (!File.Exists(archivo))
            {
                MessageBox.Show("El archivo no existe.");
                return;
            }

            // 1️⃣ Cargar alumnos desde el archivo
            alumnosCargados = CargarAlumnos(archivo, formato);

            if (alumnosCargados.Count == 0)
            {
                MessageBox.Show("El archivo no contiene alumnos válidos.");
                return;
            }

            // 2️⃣ Generar el reporte
            reporteGenerado = GenerarReporteControlApellido(alumnosCargados);

            // 3️⃣ Mostrar el reporte automáticamente
            rtbReporte.Text = reporteGenerado;

            MessageBox.Show("Reporte generado correctamente.");
        }


        private List<Alumno> CargarAlumnos(string ruta, string formato)
        {
            List<Alumno> lista = new List<Alumno>();

            if (formato == "TXT" || formato == "CSV")
            {
                var lineas = File.ReadAllLines(ruta);

                foreach (var linea in lineas)
                {
                    var datos = linea.Split('|');
                    if (datos.Length == 6)
                    {
                        lista.Add(new Alumno
                        {
                            Legajo = datos[0],
                            Apellido = datos[1],
                            Nombres = datos[2],
                            NumeroDocumento = datos[3],
                            Email = datos[4],
                            Telefono = datos[5]
                        });
                    }
                }
            }

            else if (formato == "JSON")
            {
                string contenido = File.ReadAllText(ruta);
                lista = JsonSerializer.Deserialize<List<Alumno>>(contenido);
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


        private string GenerarReporteControlApellido(List<Alumno> alumnos)
        {
            var sb = new StringBuilder();

            sb.AppendLine("================================================================================");
            sb.AppendLine("                    REPORTE DE ALUMNOS POR APELLIDO");
            sb.AppendLine($"                    Fecha: {DateTime.Now}");
            sb.AppendLine("================================================================================");
            sb.AppendLine();

            var grupos = alumnos
                .OrderBy(a => a.Apellido)
                .GroupBy(a => a.Apellido);

            int totalGeneral = 0;
            int totalApellidos = 0;

            foreach (var grupo in grupos)
            {
                string apellido = grupo.Key.ToUpper();
                int subtotal = grupo.Count();

                sb.AppendLine($"APELLIDO: {apellido}");
                sb.AppendLine("--------------------------------------------------------------------------------");

                foreach (var a in grupo)
                {
                    sb.AppendLine($"  Legajo: {a.Legajo}");
                    sb.AppendLine($"  Nombres: {a.Nombres}");
                    sb.AppendLine($"  Documento: {a.NumeroDocumento}");
                    sb.AppendLine($"  Email: {a.Email}");
                    sb.AppendLine($"  Teléfono: {a.Telefono}");
                    sb.AppendLine();
                }

                sb.AppendLine($"  → Subtotal {apellido}: {subtotal} alumno(s)");
                sb.AppendLine();

                totalGeneral += subtotal;
                totalApellidos++;
            }

            sb.AppendLine("================================================================================");
            sb.AppendLine("                           RESUMEN GENERAL");
            sb.AppendLine("================================================================================");
            sb.AppendLine($"Total de Apellidos diferentes: {totalApellidos}");
            sb.AppendLine($"Total de Alumnos registrados: {totalGeneral}");
            sb.AppendLine("================================================================================");

            return sb.ToString();
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbReporte.Text))
            {
                MessageBox.Show("Primero genere un reporte.");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivo de Texto|*.txt";
            save.FileName = "Reporte_Alumnos.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save.FileName, rtbReporte.Text, Encoding.UTF8);
                MessageBox.Show("Reporte guardado correctamente.");
            }
        }

    }
}
