using System;
using System.IO;
using System.Windows.Forms;

namespace Final_Programacion
{
    public partial class EliminarArchivo : Form
    {
        public EliminarArchivo()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccionar archivo";
            openFileDialog.Filter = "Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = openFileDialog.FileName;
                FileInfo info = new FileInfo(openFileDialog.FileName);

                double tamanoKB = info.Length / 1024.0;

                string datosArchivo = "INFORMACIÓN DEL ARCHIVO:\n\n" +
                                     "Nombre: " + info.Name + "\n\n" +
                                     "Tamaño: " + tamanoKB.ToString("0.00") + " KB\n\n" +
                                     "Creación: " + info.CreationTime + "\n\n" +
                                     "Modificación: " + info.LastWriteTime;

                lblDatosArchivo.Text = datosArchivo;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string ruta = txtRuta.Text;

            if (string.IsNullOrEmpty(ruta) || !File.Exists(ruta))
            {
                MessageBox.Show("Seleccione un archivo válido primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtConfirmacion.Text != "CONFIRMAR")
            {
                MessageBox.Show("Debe escribir 'CONFIRMAR' en mayúsculas para borrar.", "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            try
            {
                File.Delete(ruta);
                MessageBox.Show("Archivo eliminado con éxito.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtRuta.Clear();
                lblDatosArchivo.Text = ""; 
                txtConfirmacion.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}