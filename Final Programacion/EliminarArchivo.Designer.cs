namespace Final_Programacion
{
    partial class EliminarArchivo
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
            label1 = new Label();
            txtRuta = new TextBox();
            label2 = new Label();
            txtConfirmacion = new TextBox();
            btnEliminar = new Button();
            btnVolver = new Button();
            btnBuscar = new Button();
            label3 = new Label();
            lblDatosArchivo = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(380, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 0;
            label1.Text = "ELIMINAR ARCHIVO";
            // 
            // txtRuta
            // 
            txtRuta.BackColor = Color.White;
            txtRuta.Location = new Point(10, 80);
            txtRuta.Margin = new Padding(3, 2, 3, 2);
            txtRuta.Name = "txtRuta";
            txtRuta.Size = new Size(231, 23);
            txtRuta.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 364);
            label2.Name = "label2";
            label2.Size = new Size(187, 15);
            label2.TabIndex = 4;
            label2.Text = "Escriba CONFIRMAR para eliminar";
            // 
            // txtConfirmacion
            // 
            txtConfirmacion.Location = new Point(13, 381);
            txtConfirmacion.Margin = new Padding(3, 2, 3, 2);
            txtConfirmacion.Name = "txtConfirmacion";
            txtConfirmacion.Size = new Size(184, 23);
            txtConfirmacion.TabIndex = 5;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(13, 408);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(122, 34);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(829, 408);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(95, 34);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(247, 77);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(88, 26);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 63);
            label3.Name = "label3";
            label3.Size = new Size(202, 15);
            label3.TabIndex = 9;
            label3.Text = "Nombre del archivo ( con extension )";
            // 
            // lblDatosArchivo
            // 
            lblDatosArchivo.BackColor = Color.Transparent;
            lblDatosArchivo.Location = new Point(0, 0);
            lblDatosArchivo.Name = "lblDatosArchivo";
            lblDatosArchivo.Size = new Size(914, 210);
            lblDatosArchivo.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(lblDatosArchivo);
            panel1.Location = new Point(10, 121);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 210);
            panel1.TabIndex = 3;
            // 
            // EliminarArchivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 453);
            Controls.Add(label3);
            Controls.Add(btnBuscar);
            Controls.Add(btnVolver);
            Controls.Add(btnEliminar);
            Controls.Add(txtConfirmacion);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(txtRuta);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EliminarArchivo";
            Text = "Eliminar archivo";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfirmacion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVolver;
        private Button btnBuscar;
        private Label label3;
        private Label lblDatosArchivo;
        private Panel panel1;
    }
}