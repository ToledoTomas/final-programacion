namespace Final_Programacion
{
    partial class ConvertirArchivos
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
            lblTitulo = new Label();
            lblArchivoOrigen = new Label();
            txtArchivoOrigen = new TextBox();
            btnCargarOrigen = new Button();
            lblFormatoOrigen = new Label();
            lblFormatoDestino = new Label();
            cmbFormatoDestino = new ComboBox();
            lblArchivoDestino = new Label();
            txtArchivoDestino = new TextBox();
            btnConvertir = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(267, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(228, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CONVERTIR ENTRE FORMATOS";
            // 
            // lblArchivoOrigen
            // 
            lblArchivoOrigen.AutoSize = true;
            lblArchivoOrigen.Location = new Point(12, 61);
            lblArchivoOrigen.Name = "lblArchivoOrigen";
            lblArchivoOrigen.Size = new Size(188, 15);
            lblArchivoOrigen.TabIndex = 1;
            lblArchivoOrigen.Text = "Archivo de origen (con extensión):";
            // 
            // txtArchivoOrigen
            // 
            txtArchivoOrigen.Location = new Point(12, 79);
            txtArchivoOrigen.Name = "txtArchivoOrigen";
            txtArchivoOrigen.Size = new Size(209, 23);
            txtArchivoOrigen.TabIndex = 2;
            // 
            // btnCargarOrigen
            // 
            btnCargarOrigen.Location = new Point(227, 61);
            btnCargarOrigen.Name = "btnCargarOrigen";
            btnCargarOrigen.Size = new Size(119, 41);
            btnCargarOrigen.TabIndex = 3;
            btnCargarOrigen.Text = "Cargar origen";
            btnCargarOrigen.Click += btnCargarOrigen_Click;
            btnCargarOrigen.UseVisualStyleBackColor = true;
            // 
            // lblFormatoOrigen
            // 
            lblFormatoOrigen.AutoSize = true;
            lblFormatoOrigen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormatoOrigen.Location = new Point(12, 139);
            lblFormatoOrigen.Name = "lblFormatoOrigen";
            lblFormatoOrigen.Size = new Size(114, 15);
            lblFormatoOrigen.TabIndex = 4;
            lblFormatoOrigen.Text = "Formato detectado";
            // 
            // lblFormatoDestino
            // 
            lblFormatoDestino.AutoSize = true;
            lblFormatoDestino.Location = new Point(12, 175);
            lblFormatoDestino.Name = "lblFormatoDestino";
            lblFormatoDestino.Size = new Size(110, 15);
            lblFormatoDestino.TabIndex = 5;
            lblFormatoDestino.Text = "Formato de destino";
            // 
            // cmbFormatoDestino
            // 
            cmbFormatoDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormatoDestino.FormattingEnabled = true;
            cmbFormatoDestino.Items.AddRange(new object[] { "TXT", "CSV", "JSON", "XML" });
            cmbFormatoDestino.Location = new Point(12, 193);
            cmbFormatoDestino.Name = "cmbFormatoDestino";
            cmbFormatoDestino.Size = new Size(121, 23);
            cmbFormatoDestino.TabIndex = 6;
            // 
            // lblArchivoDestino
            // 
            lblArchivoDestino.AutoSize = true;
            lblArchivoDestino.Location = new Point(12, 218);
            lblArchivoDestino.Name = "lblArchivoDestino";
            lblArchivoDestino.Size = new Size(217, 15);
            lblArchivoDestino.TabIndex = 7;
            lblArchivoDestino.Text = "Nombre archivo destino (sin extensión):";
            // 
            // txtArchivoDestino
            // 
            txtArchivoDestino.Location = new Point(12, 236);
            txtArchivoDestino.Name = "txtArchivoDestino";
            txtArchivoDestino.Size = new Size(233, 23);
            txtArchivoDestino.TabIndex = 8;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(251, 211);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(110, 48);
            btnConvertir.TabIndex = 9;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(691, 408);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(97, 30);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // ConvertirArchivos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnConvertir);
            Controls.Add(txtArchivoDestino);
            Controls.Add(lblArchivoDestino);
            Controls.Add(cmbFormatoDestino);
            Controls.Add(lblFormatoDestino);
            Controls.Add(lblFormatoOrigen);
            Controls.Add(btnCargarOrigen);
            Controls.Add(txtArchivoOrigen);
            Controls.Add(lblArchivoOrigen);
            Controls.Add(lblTitulo);
            Name = "ConvertirArchivos";
            Text = "ConvertirArchivos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblArchivoOrigen;
        private TextBox txtArchivoOrigen;
        private Button btnCargarOrigen;
        private Label lblFormatoOrigen;
        private Label lblFormatoDestino;
        private ComboBox cmbFormatoDestino;
        private Label lblArchivoDestino;
        private TextBox txtArchivoDestino;
        private Button btnConvertir;
        private Button btnSalir;
    }
}