using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Programacion
{
    public partial class CreateFile : Form
    {
        public CreateFile()
        {
            InitializeComponent();

            // Cargar formatos
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

        }

        private void nudMountStudent_ValueChanged(object sender, EventArgs e)
        {
            dgvAlumnos.Rows.Clear();

          //  int cantidad = (int)numericUpDownCantidad.Value;

          //  for (int i = 0; i < cantidad; i++)
          //      dgvAlumnos.Rows.Add();

        }
    }
}
