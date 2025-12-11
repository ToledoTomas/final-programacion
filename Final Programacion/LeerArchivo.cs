using Final_Programacion.Models;
using Microsoft.Win32;
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
    public partial class LeerArchivo : Form
    {
        private List<string[]> registros = new List<string[]>();
        private int paginaActual = 0;
        private const int TamañoPagina = 20;

        public LeerArchivo()
        {
            InitializeComponent();
            cmbExtension.Items.Add("TXT");
            cmbExtension.Items.Add("CSV");
            cmbExtension.Items.Add("JSON");
            cmbExtension.Items.Add("XML");
            cmbExtension.SelectedIndex = 0;
            ConfigurarGrillaVisual();

            btnAnterior.Enabled = false;
            btnSiguiente.Enabled = false;
        }

        private void ConfigurarGrilla()
        {
            dgvAlumnos.Columns.Clear();

            dgvAlumnos.Columns.Add("Legajo", "Legajo");
            dgvAlumnos.Columns.Add("Apellido", "Apellido");
            dgvAlumnos.Columns.Add("Nombres", "Nombres");
            dgvAlumnos.Columns.Add("Documento", "Documento");
            dgvAlumnos.Columns.Add("Email", "Email");
            dgvAlumnos.Columns.Add("Telefono", "Telefono");
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

            string extension = formato.ToLower();
            string carpeta = Path.Combine(
                Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.Parent.FullName,
                "Registros"
            );
            string archivo = Path.Combine(carpeta, $"{nombreArchivo}.{extension}");

            if (!File.Exists(archivo))
            {
                MessageBox.Show("El archivo no existe.");
                return;
            }

            // Limpiamos la grilla antes de mostrar datos
            dgvAlumnos.Rows.Clear();
            ConfigurarGrilla(); // ← IMPORTANTE


            // Cargar según el formato
            switch (formato)
            {
                case "TXT":
                case "CSV":
                    CargarCSVTXT(archivo);
                    break;

                case "JSON":
                    CargarJSON(archivo);
                    break;

                case "XML":
                    CargarXML(archivo);
                    break;
            }

            // Habilitar o deshabilitar botones de paginación
            btnSiguiente.Enabled = (paginaActual + 1) * TamañoPagina < registros.Count;
        }

        private void CargarCSVTXT(string ruta)
        {
            registros.Clear();

            var lineas = File.ReadAllLines(ruta);

            foreach (var linea in lineas)
            {
                string[] datos;

                if (linea.Contains(","))            // CSV
                    datos = linea.Split(',');
                else if (linea.Contains("|"))       // TXT estilo pipe
                    datos = linea.Split('|');
                else
                    continue;

                if (datos.Length == 6)
                    registros.Add(datos);
            }

            paginaActual = 0;
            MostrarPagina();
        }



        private void CargarJSON(string ruta)
        {
            registros.Clear();

            string contenido = File.ReadAllText(ruta);
            var alumnos = JsonSerializer.Deserialize<List<Alumno>>(contenido);

            foreach (var a in alumnos)
            {
                registros.Add(new string[]
                {
            a.Legajo,
            a.Apellido,
            a.Nombres,
            a.NumeroDocumento,
            a.Email,
            a.Telefono
                });
            }

            paginaActual = 0;
            MostrarPagina();
        }



        private void CargarXML(string ruta)
        {
            registros.Clear();

            XDocument doc = XDocument.Load(ruta);

            foreach (var alumno in doc.Descendants("Alumno"))
            {
                registros.Add(new string[]
                {
                    alumno.Element("Legajo")?.Value,
                    alumno.Element("Apellido")?.Value,
                    alumno.Element("Nombres")?.Value,
                    alumno.Element("NumeroDocumento")?.Value,
                    alumno.Element("Email")?.Value,
                    alumno.Element("Telefono")?.Value
                });
            }

            paginaActual = 0;
            MostrarPagina();
        }


        private void MostrarPagina()
        {
            dgvAlumnos.Rows.Clear();

            var pagina = registros
                .Skip(paginaActual * TamañoPagina)
                .Take(TamañoPagina)
                .ToList();

            foreach (var fila in pagina)
                dgvAlumnos.Rows.Add(fila);

            ActualizarEstadoPaginacion();
        }


        private void ActualizarEstadoPaginacion()
        {
            int totalPaginas = (int)Math.Ceiling((double)registros.Count / TamañoPagina);

            lblPagina.Text = $"Página {paginaActual + 1} de {Math.Max(totalPaginas, 1)}";

            btnAnterior.Enabled = paginaActual > 0;
            btnSiguiente.Enabled = (paginaActual + 1) * TamañoPagina < registros.Count;
        }


        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            if ((paginaActual + 1) * TamañoPagina < registros.Count)
            {
                paginaActual++;
                MostrarPagina();
            }
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

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (paginaActual > 0)
            {
                paginaActual--;
                MostrarPagina();
            }
        }
    }
}
