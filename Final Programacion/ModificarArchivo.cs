using Final_Programacion.Models;
using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Final_Programacion
{
    public partial class ModificarArchivo : Form
    {
        private string carpetaArchivos;
        private string archivoActual = null;

        public ModificarArchivo()
        {
            InitializeComponent();

            ConfigurarGrillaVisual();

            carpetaArchivos = Path.Combine(
              Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)
                       .Parent.Parent.Parent.Parent.FullName,
              "Registros"
            );

            if (!Directory.Exists(carpetaArchivos))
                Directory.CreateDirectory(carpetaArchivos);


            if (!Directory.Exists(carpetaArchivos))
                Directory.CreateDirectory(carpetaArchivos);
        }
        private void ConfigurarGrillaVisual()
        {
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.AllowUserToDeleteRows = false;
            dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlumnos.MultiSelect = false;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnos.RowHeadersVisible = false;
        }
        // ===================================================================
        // FUNCIÓN PARA BUSCAR LA FILA POR LEGAJO  <<< AGREGÁS ESTO AQUÍ ABAJO
        // ===================================================================
        private DataGridViewRow BuscarFilaPorLegajo(string legajoBuscado)
        {
            foreach (DataGridViewRow fila in dgvAlumnos.Rows)
            {
                if (fila.IsNewRow) continue;

                string legajo = fila.Cells[0].Value?.ToString() ?? "";

                if (legajo == legajoBuscado)
                    return fila;
            }

            return null;
        }

        // ============================
        // CARGAR ARCHIVO
        // ============================

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreArchivo.Text))
            {
                MessageBox.Show("Ingresá el nombre del archivo (sin extensión).");
                return;
            }

            string nombreBase = txtNombreArchivo.Text.Trim();
            string patron = nombreBase + ".*";
            string[] archivos = Directory.GetFiles(carpetaArchivos, patron);

            if (archivos.Length == 0)
            {
                MessageBox.Show("No se encontró ningún archivo con ese nombre.");
                return;
            }

            string rutaFinal = archivos[0]; // toma el primero encontrado
            archivoActual = rutaFinal;

            dgvAlumnos.Rows.Clear();

            string extension = Path.GetExtension(rutaFinal).ToLower();

            try
            {
                switch (extension)
                {
                    case ".txt":
                        CargarDesdeTXT(rutaFinal);
                        break;

                    case ".csv":
                        CargarDesdeCSV(rutaFinal);
                        break;

                    case ".json":
                        CargarDesdeJSON(rutaFinal);
                        break;

                    case ".xml":
                        CargarDesdeXML(rutaFinal);
                        break;

                    default:
                        MessageBox.Show("Formato no soportado: " + extension);
                        return;
                }

                MessageBox.Show("Archivo cargado OK (" + Path.GetFileName(rutaFinal) + ")");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message);
            }
        }

        private void CargarDesdeCSV(string ruta)
        {
            string[] lineas = File.ReadAllLines(ruta);

            bool primeraLineaEsHeader = lineas[0].Contains("Legajo");
            int inicio = primeraLineaEsHeader ? 1 : 0;

            for (int i = inicio; i < lineas.Length; i++)
            {
                string[] partes = lineas[i].Split(',');

                if (partes.Length >= 6)
                {
                    dgvAlumnos.Rows.Add(
                        partes[0], partes[1], partes[2],
                        partes[3], partes[4], partes[5]
                    );
                }
            }
        }

        private void CargarDesdeTXT(string ruta)
        {
            string[] lineas = File.ReadAllLines(ruta);

            foreach (string linea in lineas)
            {
                string[] partes = linea.Split('|');
                if (partes.Length >= 6)
                {
                    dgvAlumnos.Rows.Add(
                        partes[0], partes[1], partes[2],
                        partes[3], partes[4], partes[5]
                    );
                }
            }
        }

        private void CargarDesdeJSON(string ruta)
        {
            string json = File.ReadAllText(ruta);
            var alumnos = JsonSerializer.Deserialize<List<Alumno>>(json);

            foreach (var a in alumnos)
            {
                dgvAlumnos.Rows.Add(
                    a.Legajo, a.Apellido, a.Nombres,
                    a.NumeroDocumento, a.Email, a.Telefono
                );
            }
        }

        private void CargarDesdeXML(string ruta)
        {
            XDocument doc = XDocument.Load(ruta);

            foreach (var nodo in doc.Descendants("Alumno"))
            {
                dgvAlumnos.Rows.Add(
                    nodo.Element("Legajo")?.Value,
                    nodo.Element("Apellido")?.Value,
                    nodo.Element("Nombres")?.Value,
                    nodo.Element("NumeroDocumento")?.Value,
                    nodo.Element("Email")?.Value,
                    nodo.Element("Telefono")?.Value
                );
            }
        }



        // ============================
        // CELLCLICK (podés dejarlo vacío o usarlo)
        // ============================
        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvAlumnos.Rows[e.RowIndex];
            if (fila.IsNewRow) return;

            txtLegajo.Text = fila.Cells[0].Value?.ToString() ?? "";
            txtApellido.Text = fila.Cells[1].Value?.ToString() ?? "";
            txtNombre.Text = fila.Cells[2].Value?.ToString() ?? "";
            txtDni.Text = fila.Cells[3].Value?.ToString() ?? "";
            txtEmail.Text = fila.Cells[4].Value?.ToString() ?? "";
            txtTelefono.Text = fila.Cells[5].Value?.ToString() ?? "";
        }


        // ============================
        // AGREGAR
        // ============================
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLegajo.Text))
            {
                MessageBox.Show("Poné un legajo primero.");
                return;
            }

            if (!EsEmailValido(txtEmail.Text))
            {
                MessageBox.Show("Email inválido. Ejemplo: nombre@gmail.com");
                return;
            }

            if (BuscarFilaPorLegajo(txtLegajo.Text) != null)
            {
                MessageBox.Show("Ya existe un alumno con ese legajo.");
                return;
            }

            dgvAlumnos.Rows.Add(
                txtLegajo.Text,
                txtApellido.Text,
                txtNombre.Text,
                txtDni.Text,
                txtEmail.Text,
                txtTelefono.Text
            );

            LimpiarTextos();
        }

        // ============================
        // MODIFICAR (por LEGAJO)
        // ============================
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLegajo.Text))
            {
                MessageBox.Show("Poné un legajo primero.");
                return;
            }

            if (!EsEmailValido(txtEmail.Text))
            {
                MessageBox.Show("Email inválido.");
                return;
            }

            // BUSCA LA FILA POR LEGAJO, NO POR SELECCIÓN
            DataGridViewRow fila = BuscarFilaPorLegajo(txtLegajo.Text);

            if (fila == null)
            {
                MessageBox.Show("No existe un alumno con ese legajo.");
                return;
            }

            // chequeo por si cambiaste el legajo y choca con otro
            foreach (DataGridViewRow otra in dgvAlumnos.Rows)
            {
                if (otra.IsNewRow) continue;
                if (otra == fila) continue;

                if (otra.Cells[0].Value?.ToString() == txtLegajo.Text)
                {
                    MessageBox.Show("Ya existe otro alumno con ese legajo.");
                    return;
                }
            }

            // ACTUALIZA LA FILA ENCONTRADA POR LEGAJO
            fila.Cells[0].Value = txtLegajo.Text;
            fila.Cells[1].Value = txtApellido.Text;
            fila.Cells[2].Value = txtNombre.Text;
            fila.Cells[3].Value = txtDni.Text;
            fila.Cells[4].Value = txtEmail.Text;
            fila.Cells[5].Value = txtTelefono.Text;

            MessageBox.Show("Alumno modificado OK.");
        }

        // ============================
        // ELIMINAR (por LEGAJO)
        // ============================
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLegajo.Text))
            {
                MessageBox.Show("Ingresá el legajo del alumno a borrar.");
                return;
            }

            // BUSCA LA FILA POR LEGAJO

            DataGridViewRow fila = BuscarFilaPorLegajo(txtLegajo.Text);

            if (fila == null)
            {
                MessageBox.Show("No existe un alumno con ese legajo.");
                return;
            }

            string apellido = fila.Cells[1].Value?.ToString() ?? "";
            string nombre = fila.Cells[2].Value?.ToString() ?? "";

            DialogResult rta = MessageBox.Show(
                $"¿Querés borrar a {apellido}, {nombre} (legajo {txtLegajo.Text})?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rta == DialogResult.No) return;

            dgvAlumnos.Rows.Remove(fila);
            LimpiarTextos();

            MessageBox.Show("Alumno eliminado.");
        }



        // ============================
        // GUARDAR ARCHIVO (con backup)
        // ============================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (archivoActual == null)
            {
                MessageBox.Show("Primero cargá un archivo.");
                return;
            }

            string extension = Path.GetExtension(archivoActual).ToLower();
            string backup = archivoActual + ".bak";

            // Crear backup
            try
            {
                if (File.Exists(backup))
                    File.Delete(backup);

                File.Copy(archivoActual, backup);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creando backup: " + ex.Message);
                return;
            }

            try
            {
                switch (extension)
                {
                    case ".txt":
                        GuardarComoTXT(archivoActual);
                        break;

                    case ".csv":
                        GuardarComoCSV(archivoActual);
                        break;

                    case ".json":
                        GuardarComoJSON(archivoActual);
                        break;

                    case ".xml":
                        GuardarComoXML(archivoActual);
                        break;

                    default:
                        MessageBox.Show("Formato no soportado: " + extension);
                        return;
                }

                MessageBox.Show("Archivo guardado correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al guardar: " + ex.Message);
            }
        }

        private void GuardarComoTXT(string ruta)
        {
            using (StreamWriter sw = new StreamWriter(ruta, false))
            {
                foreach (DataGridViewRow fila in dgvAlumnos.Rows)
                {
                    if (fila.IsNewRow) continue;

                    sw.WriteLine(string.Join("|", new string[]
                    {
                        fila.Cells[0].Value?.ToString(),
                        fila.Cells[1].Value?.ToString(),
                        fila.Cells[2].Value?.ToString(),
                        fila.Cells[3].Value?.ToString(),
                        fila.Cells[4].Value?.ToString(),
                        fila.Cells[5].Value?.ToString()
                    }));
                }
            }
        }

        private void GuardarComoCSV(string ruta)
        {
            using (StreamWriter sw = new StreamWriter(ruta, false))
            {
                sw.WriteLine("Legajo,Apellido,Nombres,NumeroDocumento,Email,Telefono");

                foreach (DataGridViewRow fila in dgvAlumnos.Rows)
                {
                    if (fila.IsNewRow) continue;

                    sw.WriteLine(string.Join(",", new string[]
                    {
                        fila.Cells[0].Value?.ToString(),
                        fila.Cells[1].Value?.ToString(),
                        fila.Cells[2].Value?.ToString(),
                        fila.Cells[3].Value?.ToString(),
                        fila.Cells[4].Value?.ToString(),
                        fila.Cells[5].Value?.ToString()
                    }));
                }
            }
        }

        private void GuardarComoJSON(string ruta)
        {
            var lista = new List<Alumno>();

            foreach (DataGridViewRow fila in dgvAlumnos.Rows)
            {
                if (fila.IsNewRow) continue;

                lista.Add(new Alumno
                {
                    Legajo = fila.Cells[0].Value?.ToString(),
                    Apellido = fila.Cells[1].Value?.ToString(),
                    Nombres = fila.Cells[2].Value?.ToString(),
                    NumeroDocumento = fila.Cells[3].Value?.ToString(),
                    Email = fila.Cells[4].Value?.ToString(),
                    Telefono = fila.Cells[5].Value?.ToString()
                });
            }

            File.WriteAllText(ruta, JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true }));
        }

        private void GuardarComoXML(string ruta)
        {
            XElement root = new XElement("Alumnos");

            foreach (DataGridViewRow fila in dgvAlumnos.Rows)
            {
                if (fila.IsNewRow) continue;

                XElement alumno = new XElement("Alumno",
                    new XElement("Legajo", fila.Cells[0].Value?.ToString()),
                    new XElement("Apellido", fila.Cells[1].Value?.ToString()),
                    new XElement("Nombres", fila.Cells[2].Value?.ToString()),
                    new XElement("NumeroDocumento", fila.Cells[3].Value?.ToString()),
                    new XElement("Email", fila.Cells[4].Value?.ToString()),
                    new XElement("Telefono", fila.Cells[5].Value?.ToString())
                );

                root.Add(alumno);
            }

            root.Save(ruta);
        }



        // ============================
        // CANCELAR
        // ============================
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ============================
        // UTILIDADES
        // ============================
        private bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, pattern);
        }

        private void LimpiarTextos()
        {
            txtLegajo.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtDni.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtLegajo.Focus();
        }
    }
}
