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
            btnCreateFile.Location = new Point(383, 137);
            btnCreateFile.Name = "btnCreateFile";
            btnCreateFile.Size = new Size(352, 52);
            btnCreateFile.TabIndex = 0;
            btnCreateFile.Text = "Crear nuevo archivo";
            btnCreateFile.UseVisualStyleBackColor = true;
            btnCreateFile.Click += btnCreateFile_Click;
            // 
            // btnReadFile
            // 
            btnReadFile.Location = new Point(383, 195);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(352, 52);
            btnReadFile.TabIndex = 1;
            btnReadFile.Text = "Leer archivo existente";
            btnReadFile.UseVisualStyleBackColor = true;
            // 
            // btnModifyFile
            // 
            btnModifyFile.Location = new Point(383, 253);
            btnModifyFile.Name = "btnModifyFile";
            btnModifyFile.Size = new Size(352, 52);
            btnModifyFile.TabIndex = 2;
            btnModifyFile.Text = "Modificar archivo";
            btnModifyFile.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFile
            // 
            btnDeleteFile.Location = new Point(383, 311);
            btnDeleteFile.Name = "btnDeleteFile";
            btnDeleteFile.Size = new Size(352, 52);
            btnDeleteFile.TabIndex = 3;
            btnDeleteFile.Text = "Eliminar archivo";
            btnDeleteFile.UseVisualStyleBackColor = true;
            // 
            // btnConvertFile
            // 
            btnConvertFile.Location = new Point(383, 369);
            btnConvertFile.Name = "btnConvertFile";
            btnConvertFile.Size = new Size(352, 52);
            btnConvertFile.TabIndex = 4;
            btnConvertFile.Text = "Convertir archivos";
            btnConvertFile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(346, 9);
            label1.Name = "label1";
            label1.Size = new Size(436, 37);
            label1.TabIndex = 5;
            label1.Text = "GESTOR DE ARCHIVOS DE TEXTO";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(383, 485);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(352, 52);
            btnExit.TabIndex = 6;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += this.btnExit_Click;
            // 
            // btnReportControl
            // 
            btnReportControl.Location = new Point(383, 427);
            btnReportControl.Name = "btnReportControl";
            btnReportControl.Size = new Size(352, 52);
            btnReportControl.TabIndex = 7;
            btnReportControl.Text = "Reporte con corte de control";
            btnReportControl.UseVisualStyleBackColor = true;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 610);
            Controls.Add(btnReportControl);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(btnConvertFile);
            Controls.Add(btnDeleteFile);
            Controls.Add(btnModifyFile);
            Controls.Add(btnReadFile);
            Controls.Add(btnCreateFile);
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
