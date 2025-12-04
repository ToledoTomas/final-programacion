namespace Final_Programacion
{
    partial class CreateFile
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
            cmbTypeFile = new ComboBox();
            txtFileName = new TextBox();
            lblTitle = new Label();
            nudMountStudent = new NumericUpDown();
            dgvAlumnos = new DataGridView();
            btnSave = new Button();
            lblNameFile = new Label();
            lblTypeFile = new Label();
            label3 = new Label();
            label4 = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)nudMountStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // cmbTypeFile
            // 
            cmbTypeFile.FormattingEnabled = true;
            cmbTypeFile.Location = new Point(12, 133);
            cmbTypeFile.Name = "cmbTypeFile";
            cmbTypeFile.Size = new Size(240, 23);
            cmbTypeFile.TabIndex = 0;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(12, 89);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(240, 23);
            txtFileName.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(113, 21);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Crear Archivo";
            // 
            // nudMountStudent
            // 
            nudMountStudent.Location = new Point(12, 184);
            nudMountStudent.Name = "nudMountStudent";
            nudMountStudent.Size = new Size(240, 23);
            nudMountStudent.TabIndex = 3;
            nudMountStudent.ValueChanged += nudMountStudent_ValueChanged;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(12, 235);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.Size = new Size(776, 150);
            dgvAlumnos.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(296, 391);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 47);
            btnSave.TabIndex = 5;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblNameFile
            // 
            lblNameFile.AutoSize = true;
            lblNameFile.Location = new Point(12, 71);
            lblNameFile.Name = "lblNameFile";
            lblNameFile.Size = new Size(112, 15);
            lblNameFile.TabIndex = 6;
            lblNameFile.Text = "Nombre del archivo";
            // 
            // lblTypeFile
            // 
            lblTypeFile.AutoSize = true;
            lblTypeFile.Location = new Point(12, 115);
            lblTypeFile.Name = "lblTypeFile";
            lblTypeFile.Size = new Size(89, 15);
            lblTypeFile.TabIndex = 7;
            lblTypeFile.Text = "Tipo de archivo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 166);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 8;
            label3.Text = "Cantidad de Alumnos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 217);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 9;
            label4.Text = "Alumnos";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(676, 391);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 47);
            btnExit.TabIndex = 10;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // CreateFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblTypeFile);
            Controls.Add(lblNameFile);
            Controls.Add(btnSave);
            Controls.Add(dgvAlumnos);
            Controls.Add(nudMountStudent);
            Controls.Add(lblTitle);
            Controls.Add(txtFileName);
            Controls.Add(cmbTypeFile);
            Name = "CreateFile";
            Text = "CreateFile";
            ((System.ComponentModel.ISupportInitialize)nudMountStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTypeFile;
        private TextBox txtFileName;
        private Label lblTitle;
        private NumericUpDown nudMountStudent;
        private DataGridView dgvAlumnos;
        private Button btnSave;
        private Label lblNameFile;
        private Label lblTypeFile;
        private Label label3;
        private Label label4;
        private Button btnExit;
    }
}