namespace Final_Programacion
{
    partial class ModificarArchivo
    {
        /// <summary>
        /// Variable del diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            dgvAlumnos = new DataGridView();
            colLegajo = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colDni = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            lblNombreArchivo = new Label();
            txtNombreArchivo = new TextBox();
            btnCargar = new Button();
            lblLegajo = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            lblDni = new Label();
            lblEmail = new Label();
            lblTelefono = new Label();
            txtLegajo = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtDni = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Columns.AddRange(new DataGridViewColumn[] { colLegajo, colApellido, colNombre, colDni, colEmail, colTelefono });
            dgvAlumnos.Location = new Point(35, 69);
            dgvAlumnos.Margin = new Padding(4, 3, 4, 3);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowTemplate.Height = 24;
            dgvAlumnos.Size = new Size(840, 285);
            dgvAlumnos.TabIndex = 0;
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
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
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
            // lblNombreArchivo
            // 
            lblNombreArchivo.AutoSize = true;
            lblNombreArchivo.Location = new Point(35, 9);
            lblNombreArchivo.Margin = new Padding(4, 0, 4, 0);
            lblNombreArchivo.Name = "lblNombreArchivo";
            lblNombreArchivo.Size = new Size(202, 15);
            lblNombreArchivo.TabIndex = 1;
            lblNombreArchivo.Text = "Nombre del archivo ( con extension )";
            // 
            // txtNombreArchivo
            // 
            txtNombreArchivo.Location = new Point(35, 27);
            txtNombreArchivo.Margin = new Padding(4, 3, 4, 3);
            txtNombreArchivo.Name = "txtNombreArchivo";
            txtNombreArchivo.Size = new Size(233, 23);
            txtNombreArchivo.TabIndex = 2;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(276, 23);
            btnCargar.Margin = new Padding(4, 3, 4, 3);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(117, 27);
            btnCargar.TabIndex = 3;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new Point(35, 375);
            lblLegajo.Margin = new Padding(4, 0, 4, 0);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(45, 15);
            lblLegajo.TabIndex = 4;
            lblLegajo.Text = "Legajo:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(217, 375);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(35, 424);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(217, 424);
            lblDni.Margin = new Padding(4, 0, 4, 0);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(30, 15);
            lblDni.TabIndex = 10;
            lblDni.Text = "DNI:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(35, 471);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(217, 471);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 14;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(35, 393);
            txtLegajo.Margin = new Padding(4, 3, 4, 3);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(174, 23);
            txtLegajo.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(217, 393);
            txtApellido.Margin = new Padding(4, 3, 4, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(174, 23);
            txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(35, 442);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(174, 23);
            txtNombre.TabIndex = 9;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(217, 442);
            txtDni.Margin = new Padding(4, 3, 4, 3);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(174, 23);
            txtDni.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(35, 489);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(174, 23);
            txtEmail.TabIndex = 13;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(217, 489);
            txtTelefono.Margin = new Padding(4, 3, 4, 3);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(174, 23);
            txtTelefono.TabIndex = 15;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(399, 402);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(140, 29);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(399, 442);
            btnModificar.Margin = new Padding(4, 3, 4, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(140, 29);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(399, 483);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 29);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(547, 442);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 29);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar y salir";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(547, 482);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 29);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // ModificarArchivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 532);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtLegajo);
            Controls.Add(lblLegajo);
            Controls.Add(btnCargar);
            Controls.Add(txtNombreArchivo);
            Controls.Add(lblNombreArchivo);
            Controls.Add(dgvAlumnos);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ModificarArchivo";
            Text = "Modificar archivo";
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLegajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.Label lblNombreArchivo;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
