namespace Final_Programacion
{
    partial class LeerArchivo
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
            btnBuscar = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            dgvAlumnos = new DataGridView();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            lblPagina = new Label();
            cmbExtension = new ComboBox();
            lblExtensionBuscar = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(365, 14);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(121, 41);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(26, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(244, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(26, 14);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(95, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre Archivo";
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(12, 89);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.Size = new Size(776, 302);
            dgvAlumnos.TabIndex = 3;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(149, 397);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(121, 41);
            btnAnterior.TabIndex = 6;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(509, 397);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(121, 41);
            btnSiguiente.TabIndex = 7;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // lblPagina
            // 
            lblPagina.AutoSize = true;
            lblPagina.Location = new Point(359, 410);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(0, 15);
            lblPagina.TabIndex = 8;
            // 
            // cmbExtension
            // 
            cmbExtension.FormattingEnabled = true;
            cmbExtension.Location = new Point(276, 32);
            cmbExtension.Name = "cmbExtension";
            cmbExtension.Size = new Size(83, 23);
            cmbExtension.TabIndex = 9;
            // 
            // lblExtensionBuscar
            // 
            lblExtensionBuscar.AutoSize = true;
            lblExtensionBuscar.Location = new Point(276, 14);
            lblExtensionBuscar.Name = "lblExtensionBuscar";
            lblExtensionBuscar.Size = new Size(57, 15);
            lblExtensionBuscar.TabIndex = 10;
            lblExtensionBuscar.Text = "Extension";
            // 
            // LeerArchivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblExtensionBuscar);
            Controls.Add(cmbExtension);
            Controls.Add(lblPagina);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(dgvAlumnos);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(btnBuscar);
            Name = "LeerArchivo";
            Text = "LeerArchivo";
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private TextBox txtNombre;
        private Label lblNombre;
        private DataGridView dgvAlumnos;
        private Button btnAnterior;
        private Button btnSiguiente;
        private Label lblPagina;
        private ComboBox cmbExtension;
        private Label lblExtensionBuscar;
    }
}