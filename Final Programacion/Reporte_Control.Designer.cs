namespace Final_Programacion
{
    partial class Reporte_Control
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            cmbExtension = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnBuscar = new Button();
            btnGuardar = new Button();
            btnSalir = new Button();
            rtbReporte = new RichTextBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(160, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Generar Reporte por Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 68);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(160, 23);
            txtNombre.TabIndex = 1;
            // 
            // cmbExtension
            // 
            cmbExtension.FormattingEnabled = true;
            cmbExtension.Location = new Point(178, 68);
            cmbExtension.Name = "cmbExtension";
            cmbExtension.Size = new Size(99, 23);
            cmbExtension.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(112, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre del archivo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 50);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Extension";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(283, 68);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 22);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(829, 437);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(83, 37);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Descargar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(740, 437);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(83, 37);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // rtbReporte
            // 
            rtbReporte.Location = new Point(12, 97);
            rtbReporte.Name = "rtbReporte";
            rtbReporte.Size = new Size(900, 334);
            rtbReporte.TabIndex = 8;
            rtbReporte.Text = "";
            // 
            // Reporte_Control
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 486);
            Controls.Add(rtbReporte);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(btnBuscar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbExtension);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "Reporte_Control";
            Text = "Reporte_Control";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private ComboBox cmbExtension;
        private Label label1;
        private Label label2;
        private Button btnBuscar;
        private Button btnGuardar;
        private Button btnSalir;
        private RichTextBox rtbReporte;
    }
}