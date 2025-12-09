using System;
using System.IO;
using System.Windows.Forms;

namespace Final_Programacion
{
    public partial class ModificarArchivo : Form
    {
        private string carpetaArchivos;

        public ModificarArchivo()
        {
            InitializeComponent();

            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            string carpetaBase = AppDomain.CurrentDomain.BaseDirectory;
            carpetaArchivos = Path.Combine(carpetaBase, "Archivos");

            if (!Directory.Exists(carpetaArchivos))
                Directory.CreateDirectory(carpetaArchivos);
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
                MessageBox.Show("Poné el nombre del archivo arriba.");
                return;
            }

            string rutaTxt = Path.Combine(carpetaArchivos, txtNombreArchivo.Text + ".txt");

            if (!File.Exists(rutaTxt))
            {
                MessageBox.Show("El archivo no existe en la carpeta Archivos.");
                return;
            }

            dgvAlumnos.Rows.Clear();

            string[] lineas = File.ReadAllLines(rutaTxt);

            foreach (string linea in lineas)
            {
                string[] partes = linea.Split('|');
                if (partes.Length < 6) continue;

                dgvAlumnos.Rows.Add(
                    partes[0], // legajo
                    partes[1], // apellido
                    partes[2], // nombre
                    partes[3], // dni
                    partes[4], // email
                    partes[5]  // telefono
                );
            }

            MessageBox.Show("Archivo cargado OK.");
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
            if (string.IsNullOrWhiteSpace(txtNombreArchivo.Text))
            {
                MessageBox.Show("Poné el nombre del archivo arriba.");
                return;
            }

            string nombreBase = txtNombreArchivo.Text;
            string rutaTxt = Path.Combine(carpetaArchivos, nombreBase + ".txt");
            string rutaBak = Path.Combine(carpetaArchivos, nombreBase + ".bak");

            // backup
            if (File.Exists(rutaTxt))
            {
                try
                {
                    if (File.Exists(rutaBak))
                        File.Delete(rutaBak);

                    File.Move(rutaTxt, rutaBak);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo hacer el backup: " + ex.Message);
                    return;
                }
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(rutaTxt, false))
                {
                    foreach (DataGridViewRow fila in dgvAlumnos.Rows)
                    {
                        if (fila.IsNewRow) continue;

                        string legajo = fila.Cells[0].Value?.ToString() ?? "";
                        string apellido = fila.Cells[1].Value?.ToString() ?? "";
                        string nombre = fila.Cells[2].Value?.ToString() ?? "";
                        string dni = fila.Cells[3].Value?.ToString() ?? "";
                        string email = fila.Cells[4].Value?.ToString() ?? "";
                        string telefono = fila.Cells[5].Value?.ToString() ?? "";

                        string linea = legajo + "|" + apellido + "|" + nombre + "|" +
                                       dni + "|" + email + "|" + telefono;

                        sw.WriteLine(linea);
                    }
                }

                MessageBox.Show("Archivo guardado OK.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema al guardar: " + ex.Message);
            }
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
