using System;
using System.IO;
using System.Windows.Forms;

namespace Final_Programacion
{
    public partial class Form1 : Form   // formulario de modificar archivo
    {
        // ruta a la carpeta donde se guardan los txt
        string carpetaArchivos;

        public Form1()
        {
            InitializeComponent();

            // armamos la ruta base como en createfile
            string carpetaBase = AppDomain.CurrentDomain.BaseDirectory;
            carpetaArchivos = Path.Combine(carpetaBase, "Archivos");

            // si la carpeta no existe la creamos
            if (!Directory.Exists(carpetaArchivos))
                Directory.CreateDirectory(carpetaArchivos);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            // armamos el nombre completo del archivo dentro de la carpeta archivos
            string nombreTxt = txtNombreArchivo.Text + ".txt";
            string rutaCompleta = Path.Combine(carpetaArchivos, nombreTxt);

            // verificamos si existe
            if (!File.Exists(rutaCompleta))
            {
                MessageBox.Show("el archivo no existe en la carpeta archivos");
                return;
            }

            // limpiamos el datagrid
            dgvAlumnos.Rows.Clear();

            // leemos todas las lineas
            string[] lineas = File.ReadAllLines(rutaCompleta);

            // recorremos las lineas
            foreach (string linea in lineas)
            {
                // separamos por |
                string[] partes = linea.Split('|');

                // por las dudas si viene una linea incompleta
                if (partes.Length < 6)
                    continue;

                // cargamos la fila en el datagrid
                dgvAlumnos.Rows.Add(
                    partes[0],  // legajo
                    partes[1],  // apellido
                    partes[2],  // nombre
                    partes[3],  // dni
                    partes[4],  // email
                    partes[5]   // telefono
                );
            }

            MessageBox.Show("archivo cargado ok");
        }

        // cuando hago click en una fila del datagrid
        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // si clickeo arriba o fuera de las filas, salgo
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvAlumnos.Rows[e.RowIndex];

            // si la fila es la vacia del final, salgo
            if (fila.IsNewRow) return;

            // cargo los textbox
            txtLegajo.Text = fila.Cells[0].Value?.ToString() ?? "";
            txtApellido.Text = fila.Cells[1].Value?.ToString() ?? "";
            txtNombre.Text = fila.Cells[2].Value?.ToString() ?? "";
            txtDni.Text = fila.Cells[3].Value?.ToString() ?? "";
            txtEmail.Text = fila.Cells[4].Value?.ToString() ?? "";
            txtTelefono.Text = fila.Cells[5].Value?.ToString() ?? "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLegajo.Text))
            {
                MessageBox.Show("pone un legajo primero");
                return;
            }

            // validamos email
            if (!EsEmailValido(txtEmail.Text))
            {
                MessageBox.Show("el email no es valido. debe tener formato ejemplo: nombre@gmail.com");
                return;
            }

            foreach (DataGridViewRow fila in dgvAlumnos.Rows)
            {
                if (fila.IsNewRow) continue;

                if (fila.Cells[0].Value != null &&
                    fila.Cells[0].Value.ToString() == txtLegajo.Text)
                {
                    MessageBox.Show("ya existe un alumno con ese legajo");
                    return;
                }
            }

            dgvAlumnos.Rows.Add(
                txtLegajo.Text,
                txtApellido.Text,
                txtNombre.Text,
                txtDni.Text,
                txtEmail.Text,
                txtTelefono.Text
            );

            limpiarTextos();
        }


        private bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // validacion simple: algo@algo.algo
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, pattern);
        }


        // funcion para limpiar todos los textbox
        private void limpiarTextos()
        {
            txtLegajo.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDni.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";

            txtLegajo.Focus(); // volvemos al legajo para cargar rapido otro
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.CurrentRow == null)
            {
                MessageBox.Show("selecciona un alumno en la tabla");
                return;
            }

            DataGridViewRow fila = dgvAlumnos.CurrentRow;

            if (fila.IsNewRow)
            {
                MessageBox.Show("esa fila esta vacia");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLegajo.Text))
            {
                MessageBox.Show("pone un legajo primero");
                return;
            }

            // validamos email
            if (!EsEmailValido(txtEmail.Text))
            {
                MessageBox.Show("el email no es valido. debe tener formato ejemplo: nombre@gmail.com");
                return;
            }

            foreach (DataGridViewRow otraFila in dgvAlumnos.Rows)
            {
                if (otraFila.IsNewRow) continue;
                if (otraFila == fila) continue;

                if (otraFila.Cells[0].Value != null &&
                    otraFila.Cells[0].Value.ToString() == txtLegajo.Text)
                {
                    MessageBox.Show("ya existe otro alumno con ese legajo");
                    return;
                }
            }

            fila.Cells[0].Value = txtLegajo.Text;
            fila.Cells[1].Value = txtApellido.Text;
            fila.Cells[2].Value = txtNombre.Text;
            fila.Cells[3].Value = txtDni.Text;
            fila.Cells[4].Value = txtEmail.Text;
            fila.Cells[5].Value = txtTelefono.Text;

            MessageBox.Show("alumno modificado ok");
        }


        // boton eliminar alumno
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // si no hay fila seleccionada, salimos
            if (dgvAlumnos.CurrentRow == null)
            {
                MessageBox.Show("selecciona un alumno en la tabla primero");
                return;
            }

            DataGridViewRow fila = dgvAlumnos.CurrentRow;

            // si es la fila vacia del final, salimos
            if (fila.IsNewRow)
            {
                MessageBox.Show("esa fila esta vacia, no hay nada para borrar");
                return;
            }

            // mostramos los datos para confirmar
            string legajo = fila.Cells[0].Value?.ToString() ?? "";
            string nombre = fila.Cells[2].Value?.ToString() ?? "";
            string apellido = fila.Cells[1].Value?.ToString() ?? "";

            DialogResult rta = MessageBox.Show(
                "queres borrar al alumno " + apellido + ", " + nombre + " (legajo " + legajo + ")?",
                "confirmar eliminacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // si el usuario dijo que no, nos vamos
            if (rta == DialogResult.No)
                return;

            // si dijo que si, borramos la fila del datagrid
            dgvAlumnos.Rows.Remove(fila);

            // limpiamos los textbox
            limpiarTextos();

            MessageBox.Show("alumno eliminado");
        }

        // boton guardar y salir
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // validamos que haya nombre de archivo
            if (string.IsNullOrWhiteSpace(txtNombreArchivo.Text))
            {
                MessageBox.Show("pone el nombre del archivo arriba");
                return;
            }

            // nombres de archivo dentro de la carpeta archivos
            string nombreBase = txtNombreArchivo.Text;
            string rutaTxt = Path.Combine(carpetaArchivos, nombreBase + ".txt");
            string rutaBak = Path.Combine(carpetaArchivos, nombreBase + ".bak");

            // hacemos backup si existe el txt original
            if (File.Exists(rutaTxt))
            {
                try
                {
                    // si ya hay un bak viejo, lo borramos
                    if (File.Exists(rutaBak))
                        File.Delete(rutaBak);

                    // renombramos el txt original a .bak
                    File.Move(rutaTxt, rutaBak);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo hacer el backup: " + ex.Message);
                    return;
                }
            }

            try
            {
                // abrimos el archivo nuevo .txt para escribir todo de cero
                using (StreamWriter sw = new StreamWriter(rutaTxt, false))
                {
                    // recorremos las filas del datagrid
                    foreach (DataGridViewRow fila in dgvAlumnos.Rows)
                    {
                        // saltamos la fila vacia del final
                        if (fila.IsNewRow) continue;

                        // levantamos los datos de cada columna
                        string legajo = fila.Cells[0].Value?.ToString() ?? "";
                        string apellido = fila.Cells[1].Value?.ToString() ?? "";
                        string nombre = fila.Cells[2].Value?.ToString() ?? "";
                        string dni = fila.Cells[3].Value?.ToString() ?? "";
                        string email = fila.Cells[4].Value?.ToString() ?? "";
                        string telefono = fila.Cells[5].Value?.ToString() ?? "";

                        // armamos la linea con el mismo formato del tp: campo|campo|campo...
                        string linea = legajo + "|" + apellido + "|" + nombre + "|" +
                                       dni + "|" + email + "|" + telefono;

                        // escribimos la linea en el archivo
                        sw.WriteLine(linea);
                    }
                }

                MessageBox.Show("archivo guardado ok");
                this.Close();   // cerramos el formulario y volvemos al menu
            }
            catch (Exception ex)
            {
                MessageBox.Show("hubo un problema al guardar: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // cerramos la ventana sin hacer nada
            this.Close();
        }
    }
}










