namespace Final_Programacion
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCreateFile = new Button();
            btnReadFile = new Button();
            btnModifyFile = new Button();
            btnDeleteFile = new Button();
            btnConvertFile = new Button();
            label1 = new Label();
            btnExit = new Button();
            btnReportControl = new Button();
            SuspendLayout();
            // 
            // btnCreateFile
            // 
            btnCreateFile.Location = new Point(438, 183);
            btnCreateFile.Margin = new Padding(3, 4, 3, 4);
            btnCreateFile.Name = "btnCreateFile";
            btnCreateFile.Size = new Size(402, 69);
            btnCreateFile.TabIndex = 0;
            btnCreateFile.Text = "Crear nuevo archivo";
            btnCreateFile.UseVisualStyleBackColor = true;
            btnCreateFile.Click += btnCreateFile_Click;
            // 
            // btnReadFile
            // 
            btnReadFile.Location = new Point(438, 260);
            btnReadFile.Margin = new Padding(3, 4, 3, 4);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(402, 69);
            btnReadFile.TabIndex = 1;
            btnReadFile.Text = "Leer archivo existente";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // btnModifyFile
            // 
            btnModifyFile.Location = new Point(438, 337);
            btnModifyFile.Margin = new Padding(3, 4, 3, 4);
            btnModifyFile.Name = "btnModifyFile";
            btnModifyFile.Size = new Size(402, 69);
            btnModifyFile.TabIndex = 2;
            btnModifyFile.Text = "Modificar archivo";
            btnModifyFile.UseVisualStyleBackColor = true;
            btnModifyFile.Click += btnModifyFile_Click;
            // 
            // btnDeleteFile
            // 
            btnDeleteFile.Location = new Point(438, 415);
            btnDeleteFile.Margin = new Padding(3, 4, 3, 4);
            btnDeleteFile.Name = "btnDeleteFile";
            btnDeleteFile.Size = new Size(402, 69);
            btnDeleteFile.TabIndex = 3;
            btnDeleteFile.Text = "Eliminar archivo";
            btnDeleteFile.UseVisualStyleBackColor = true;
            btnDeleteFile.Click += btnDeleteFile_Click;
            // 
            // btnConvertFile
            // 
            btnConvertFile.Location = new Point(438, 492);
            btnConvertFile.Margin = new Padding(3, 4, 3, 4);
            btnConvertFile.Name = "btnConvertFile";
            btnConvertFile.Size = new Size(402, 69);
            btnConvertFile.TabIndex = 4;
            btnConvertFile.Text = "Convertir archivos";
            btnConvertFile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(395, 12);
            label1.Name = "label1";
            label1.Size = new Size(549, 46);
            label1.TabIndex = 5;
            label1.Text = "GESTOR DE ARCHIVOS DE TEXTO";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(438, 647);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(402, 69);
            btnExit.TabIndex = 6;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReportControl
            // 
            btnReportControl.Location = new Point(438, 569);
            btnReportControl.Margin = new Padding(3, 4, 3, 4);
            btnReportControl.Name = "btnReportControl";
            btnReportControl.Size = new Size(402, 69);
            btnReportControl.TabIndex = 7;
            btnReportControl.Text = "Reporte con corte de control";
            btnReportControl.UseVisualStyleBackColor = true;
            btnReportControl.Click += btnReportControl_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 813);
            Controls.Add(btnReportControl);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(btnConvertFile);
            Controls.Add(btnDeleteFile);
            Controls.Add(btnModifyFile);
            Controls.Add(btnReadFile);
            Controls.Add(btnCreateFile);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMenu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateFile;
        private Button btnReadFile;
        private Button btnModifyFile;
        private Button btnDeleteFile;
        private Button btnConvertFile;
        private Label label1;
        private Button btnExit;
        private Button btnReportControl;
    }
}
