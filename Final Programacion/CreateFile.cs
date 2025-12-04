using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Final_Programacion.Models;

namespace Final_Programacion
{
    public partial class CreateFile : Form
    {
        public CreateFile()
        {
            InitializeComponent();

            cmbTypeFile.Items.Add("TXT");
            cmbTypeFile.Items.Add("CSV");
            cmbTypeFile.Items.Add("JSON");
            cmbTypeFile.Items.Add("XML");
            cmbTypeFile.SelectedIndex = 0;

            ConfigurarGrilla();
        }

        private void ConfigurarGrilla()
        {
            dgvAlumnos.ColumnCount = 6;
            dgvAlumnos.Columns[0].Name = "Legajo";
            dgvAlumnos.Columns[1].Name = "Apellido";
            dgvAlumnos.Columns[2].Name = "Nombres";
            dgvAlumnos.Columns[3].Name = "Documento";
            dgvAlumnos.Columns[4].Name = "Email";
            dgvAlumnos.Columns[5].Name = "Teléfono";

            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validamos que nombre de archivo no este vacio
                if (string.IsNullOrWhiteSpace(txtFileName.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre para el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dgvAlumnos.Rows.Count == 0 || dgvAlumnos.Rows[0].IsNewRow)
                {
                    MessageBox.Show("No hay alumnos registrados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var alumnos = ValidarYRecolectarAlumnos();
                if (alumnos == null) return;

                // Guardamos el archivo en el formato seleccionado
                string formato = cmbTypeFile.SelectedItem.ToString();
                string nombreArchivo = txtFileName.Text.Trim();
                string rutaCompleta = GuardarArchivo(formato, nombreArchivo, alumnos);

                if (!string.IsNullOrEmpty(rutaCompleta))
                {
                    MessageBox.Show($"Archivo guardado exitosamente en:\n{rutaCompleta}",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el archivo: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Alumno> ValidarYRecolectarAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();

            foreach (DataGridViewRow row in dgvAlumnos.Rows)
            {
                // Saltamos a la fila vacía de entrada
                if (row.IsNewRow) continue;

                // Validamos que ninguna celda este vacia
                for (int i = 0; i < 6; i++)
                {
                    if (row.Cells[i].Value == null || string.IsNullOrWhiteSpace(row.Cells[i].Value.ToString()))
                    {
                        MessageBox.Show($"Fila {row.Index + 1}: Todos los campos son obligatorios.",
                            "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }

                // Creamos un objeto Alumno
                var alumno = new Alumno
                {
                    Legajo = row.Cells[0].Value.ToString().Trim(),
                    Apellido = row.Cells[1].Value.ToString().Trim(),
                    Nombres = row.Cells[2].Value.ToString().Trim(),
                    NumeroDocumento = row.Cells[3].Value.ToString().Trim(),
                    Email = row.Cells[4].Value.ToString().Trim(),
                    Telefono = row.Cells[5].Value.ToString().Trim()
                };

                // Validamos que tenga formato de email
                if (!EsEmailValido(alumno.Email))
                {
                    var resultado = MessageBox.Show($"Fila {row.Index + 1}: El email '{alumno.Email}' no tiene un formato válido.\n¿Desea continuar de todos modos?",
                        "Validación de Email", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.No)
                    {
                        return null;
                    }
                }

                alumnos.Add(alumno);
            }

            return alumnos;
        }

        private bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Regex simple para validar formato de email
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        private string GuardarArchivo(string formato, string nombreArchivo, List<Alumno> alumnos)
        {
            // Creamos carpeta "Archivos" si no existe
            string carpetaBase = AppDomain.CurrentDomain.BaseDirectory;
            string carpetaArchivos = Path.Combine(carpetaBase, "Archivos");

            if (!Directory.Exists(carpetaArchivos))
                Directory.CreateDirectory(carpetaArchivos);

            // Agregamos extension segun el formato
            string extension = "";
            switch (formato)
            {
                case "TXT": extension = ".txt"; break;
                case "CSV": extension = ".csv"; break;
                case "JSON": extension = ".json"; break;
                case "XML": extension = ".xml"; break;
            }

            string rutaCompleta = Path.Combine(carpetaArchivos, nombreArchivo + extension);

            // Guardamos el archivo en el formato seleccionado
            switch (formato)
            {
                case "TXT":
                    GuardarComoTXT(rutaCompleta, alumnos);
                    break;

                case "CSV":
                    GuardarComoCSV(rutaCompleta, alumnos);
                    break;

                case "JSON":
                    GuardarComoJSON(rutaCompleta, alumnos);
                    break;

                case "XML":
                    GuardarComoXML(rutaCompleta, alumnos);
                    break;
            }

            return rutaCompleta;
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
                    var alumno = alumnos[i];
                    string alumnoJson = $"  {{\n" +
                                      $"    \"Legajo\": \"{alumno.Legajo}\",\n" +
                                      $"    \"Apellido\": \"{alumno.Apellido}\",\n" +
                                      $"    \"Nombres\": \"{alumno.Nombres}\",\n" +
                                      $"    \"NumeroDocumento\": \"{alumno.NumeroDocumento}\",\n" +
                                      $"    \"Email\": \"{alumno.Email}\",\n" +
                                      $"    \"Telefono\": \"{alumno.Telefono}\"\n" +
                                      $"  }}";

                    writer.Write(alumnoJson);

                    // Agregamos la coma si no es el ultimo elemento
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

                foreach (var alumno in alumnos)
                {
                    writer.WriteLine("  <Alumno>");
                    writer.WriteLine($"    <Legajo>{alumno.Legajo}</Legajo>");
                    writer.WriteLine($"    <Apellido>{alumno.Apellido}</Apellido>");
                    writer.WriteLine($"    <Nombres>{alumno.Nombres}</Nombres>");
                    writer.WriteLine($"    <NumeroDocumento>{alumno.NumeroDocumento}</NumeroDocumento>");
                    writer.WriteLine($"    <Email>{alumno.Email}</Email>");
                    writer.WriteLine($"    <Telefono>{alumno.Telefono}</Telefono>");
                    writer.WriteLine("  </Alumno>");
                }

                writer.WriteLine("</Alumnos>");
            }
        }

        private void LimpiarFormulario()
        {
            txtFileName.Clear();
            dgvAlumnos.Rows.Clear();
            nudMountStudent.Value = 0;
            cmbTypeFile.SelectedIndex = 0;
        }

        private void nudMountStudent_ValueChanged(object sender, EventArgs e)
        {
            int cantidad = (int)nudMountStudent.Value;
            int filasActuales = dgvAlumnos.Rows.Count;

            // Limpiamos la grilla si se reduce la cantidad
            if (cantidad < filasActuales)
            {
                dgvAlumnos.Rows.Clear();
                filasActuales = 0;
            }

            // Agregamos filas si se incrementa la cantidad
            if (cantidad > filasActuales)
            {
                for (int i = filasActuales; i < cantidad; i++)
                {
                    dgvAlumnos.Rows.Add();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}