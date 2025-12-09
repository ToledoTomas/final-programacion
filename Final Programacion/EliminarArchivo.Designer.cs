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
            btnBuscar = new Button();
            panel1 = new Panel();
            lblDatosArchivo = new Label();
            label2 = new Label();
            txtConfirmacion = new TextBox();
            btnEliminar = new Button();
            btnVolver = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 31);
            label1.TabIndex = 0;
            label1.Text = "Eliminar Archivo";
            // 
            // txtRuta
            // 
            txtRuta.BackColor = Color.Gainsboro;
            txtRuta.Location = new Point(12, 107);
            txtRuta.Name = "txtRuta";
            txtRuta.Size = new Size(719, 27);
            txtRuta.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            btnBuscar.Location = new Point(747, 107);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(131, 29);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(lblDatosArchivo);
            panel1.Location = new Point(12, 161);
            panel1.Name = "panel1";
            panel1.Size = new Size(979, 319);
            panel1.TabIndex = 3;
            // 
            // lblDatosArchivo
            // 
            lblDatosArchivo.BackColor = Color.Transparent;
            lblDatosArchivo.Location = new Point(3, 0);
            lblDatosArchivo.Name = "lblDatosArchivo";
            lblDatosArchivo.Size = new Size(973, 319);
            lblDatosArchivo.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 483);
            label2.Name = "label2";
            label2.Size = new Size(235, 20);
            label2.TabIndex = 4;
            label2.Text = "Escriba CONFIRMAR para eliminar";
            // 
            // txtConfirmacion
            // 
            txtConfirmacion.Location = new Point(253, 480);
            txtConfirmacion.Name = "txtConfirmacion";
            txtConfirmacion.Size = new Size(161, 27);
            txtConfirmacion.TabIndex = 5;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(12, 528);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 45);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(890, 528);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(101, 35);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // EliminarArchivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 604);
            Controls.Add(btnVolver);
            Controls.Add(btnEliminar);
            Controls.Add(txtConfirmacion);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnBuscar);
            Controls.Add(txtRuta);
            Controls.Add(label1);
            Name = "EliminarArchivo";
            Text = "a";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDatosArchivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfirmacion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVolver;
    }
}