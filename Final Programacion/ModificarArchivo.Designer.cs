namespace Final_Programacion
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblArchivo = new Label();
            txtNombreArchivo = new TextBox();
            btnCargar = new Button();
            dgvAlumnos = new DataGridView();
            colLegajo = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            colDni = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            txtLegajo = new Label();
            txtApellido = new Label();
            txtNombre = new Label();
            txtDni = new Label();
            txtEmail = new Label();
            txtTelefono = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // lblArchivo
            // 
            lblArchivo.AutoSize = true;
            lblArchivo.Location = new Point(268, 20);
            lblArchivo.Name = "lblArchivo";
            lblArchivo.Size = new Size(112, 15);
            lblArchivo.TabIndex = 0;
            lblArchivo.Text = "Nombre del archivo";
            // 
            // txtNombreArchivo
            // 
            txtNombreArchivo.Location = new Point(386, 12);
            txtNombreArchivo.Name = "txtNombreArchivo";
            txtNombreArchivo.Size = new Size(106, 23);
            txtNombreArchivo.TabIndex = 1;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(630, 9);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(95, 37);
            btnCargar.TabIndex = 2;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Columns.AddRange(new DataGridViewColumn[] { colLegajo, colApellido, Nombre, colDni, colEmail, colTelefono });
            dgvAlumnos.Location = new Point(108, 55);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.Size = new Size(643, 121);
            dgvAlumnos.TabIndex = 3;
            dgvAlumnos.CellClick += dgvAlumnos_CellClick;
            // 
            // colLegajo
            // 
            colLegajo.HeaderText = "Legajo";
            colLegajo.Name = "colLegajo";
            // 
            // colApellido
            // 
            colApellido.HeaderText = "Apellido";
            colApellido.Name = "colApellido";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // colDni
            // 
            colDni.HeaderText = "DNI";
            colDni.Name = "colDni";
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            // 
            // colTelefono
            // 
            colTelefono.HeaderText = "Teléfono";
            colTelefono.Name = "colTelefono";
            // 
            // txtLegajo
            // 
            txtLegajo.AutoSize = true;
            txtLegajo.Location = new Point(167, 208);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(42, 15);
            txtLegajo.TabIndex = 4;
            txtLegajo.Text = "Legajo";
            // 
            // txtApellido
            // 
            txtApellido.AutoSize = true;
            txtApellido.Location = new Point(169, 246);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(51, 15);
            txtApellido.TabIndex = 5;
            txtApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.AutoSize = true;
            txtNombre.Location = new Point(169, 285);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(51, 15);
            txtNombre.TabIndex = 7;
            txtNombre.Text = "Nombre";
            // 
            // txtDni
            // 
            txtDni.AutoSize = true;
            txtDni.Location = new Point(173, 325);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(27, 15);
            txtDni.TabIndex = 6;
            txtDni.Text = "DNI";
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Location = new Point(173, 368);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(36, 15);
            txtEmail.TabIndex = 9;
            txtEmail.Text = "Email";
            // 
            // txtTelefono
            // 
            txtTelefono.AutoSize = true;
            txtTelefono.Location = new Point(167, 410);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(53, 15);
            txtTelefono.TabIndex = 8;
            txtTelefono.Text = "Telefono";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(226, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(226, 238);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(226, 317);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(226, 277);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(226, 402);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(226, 360);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 14;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(576, 191);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(123, 32);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(576, 246);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(123, 32);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(576, 302);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(123, 32);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(576, 356);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(123, 32);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar y salir";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(576, 408);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(123, 32);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtLegajo);
            Controls.Add(dgvAlumnos);
            Controls.Add(btnCargar);
            Controls.Add(txtNombreArchivo);
            Controls.Add(lblArchivo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblArchivo;
        private TextBox txtNombreArchivo;
        private Button btnCargar;
        private DataGridView dgvAlumnos;
        private Label txtLegajo;
        private Label txtApellido;
        private Label txtNombre;
        private Label txtDni;
        private Label txtEmail;
        private Label txtTelefono;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn colLegajo;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn colDni;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colTelefono;
    }
}