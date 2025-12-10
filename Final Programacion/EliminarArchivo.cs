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
            string nombreArchivo = txtRuta.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombreArchivo))
            {
                MessageBox.Show("Ingrese el nombre del archivo con la extensión.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string carpetaArchivos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Archivos");
            string rutaCompleta = Path.Combine(carpetaArchivos, nombreArchivo);

            if (!File.Exists(rutaCompleta))
            {
                MessageBox.Show("El archivo NO existe en la carpeta Archivos.", "No encontrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileInfo info = new FileInfo(rutaCompleta);
            double tamKB = info.Length / 1024.0;

            lblDatosArchivo.Text =
                "INFORMACIÓN DEL ARCHIVO:\n\n" +
                $"Nombre: {info.Name}\n\n" +
                $"Tamaño: {tamKB:0.00} KB\n\n" +
                $"Creación: {info.CreationTime}\n\n" +
                $"Modificación: {info.LastWriteTime}";

            txtRuta.Tag = rutaCompleta; // Guardamos ruta real para eliminar
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string ruta = txtRuta.Tag as string;

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