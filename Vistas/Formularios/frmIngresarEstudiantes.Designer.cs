namespace Vistas.Formularios
{
    partial class frmIngresarEstudiantes
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
            this.gbRegistroAlumnos = new System.Windows.Forms.GroupBox();
            this.lblRegistroNombre = new System.Windows.Forms.Label();
            this.lblRegistroApellido = new System.Windows.Forms.Label();
            this.lblRegistrocarnet = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbnRegistrarAlumnos = new System.Windows.Forms.Button();
            this.gbRegistroAlumnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegistroAlumnos
            // 
            this.gbRegistroAlumnos.Controls.Add(this.textBox3);
            this.gbRegistroAlumnos.Controls.Add(this.textBox2);
            this.gbRegistroAlumnos.Controls.Add(this.textBox1);
            this.gbRegistroAlumnos.Controls.Add(this.lblRegistrocarnet);
            this.gbRegistroAlumnos.Controls.Add(this.lblRegistroApellido);
            this.gbRegistroAlumnos.Controls.Add(this.lblRegistroNombre);
            this.gbRegistroAlumnos.Location = new System.Drawing.Point(251, 110);
            this.gbRegistroAlumnos.Name = "gbRegistroAlumnos";
            this.gbRegistroAlumnos.Size = new System.Drawing.Size(200, 230);
            this.gbRegistroAlumnos.TabIndex = 0;
            this.gbRegistroAlumnos.TabStop = false;
            this.gbRegistroAlumnos.Text = "Registro de Alumnos";
            // 
            // lblRegistroNombre
            // 
            this.lblRegistroNombre.AutoSize = true;
            this.lblRegistroNombre.Location = new System.Drawing.Point(19, 20);
            this.lblRegistroNombre.Name = "lblRegistroNombre";
            this.lblRegistroNombre.Size = new System.Drawing.Size(44, 13);
            this.lblRegistroNombre.TabIndex = 0;
            this.lblRegistroNombre.Text = "Nombre";
            // 
            // lblRegistroApellido
            // 
            this.lblRegistroApellido.AutoSize = true;
            this.lblRegistroApellido.Location = new System.Drawing.Point(19, 89);
            this.lblRegistroApellido.Name = "lblRegistroApellido";
            this.lblRegistroApellido.Size = new System.Drawing.Size(44, 13);
            this.lblRegistroApellido.TabIndex = 1;
            this.lblRegistroApellido.Text = "Apellido";
            // 
            // lblRegistrocarnet
            // 
            this.lblRegistrocarnet.AutoSize = true;
            this.lblRegistrocarnet.Location = new System.Drawing.Point(19, 151);
            this.lblRegistrocarnet.Name = "lblRegistrocarnet";
            this.lblRegistrocarnet.Size = new System.Drawing.Size(38, 13);
            this.lblRegistrocarnet.TabIndex = 1;
            this.lblRegistrocarnet.Text = "Carnet";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(22, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(22, 185);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // tbnRegistrarAlumnos
            // 
            this.tbnRegistrarAlumnos.Location = new System.Drawing.Point(273, 346);
            this.tbnRegistrarAlumnos.Name = "tbnRegistrarAlumnos";
            this.tbnRegistrarAlumnos.Size = new System.Drawing.Size(100, 23);
            this.tbnRegistrarAlumnos.TabIndex = 1;
            this.tbnRegistrarAlumnos.Text = "Registrar alumnos";
            this.tbnRegistrarAlumnos.UseVisualStyleBackColor = true;
            // 
            // frmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbnRegistrarAlumnos);
            this.Controls.Add(this.gbRegistroAlumnos);
            this.Name = "frmEstudiante";
            this.Text = "frmEstudiante";
            this.gbRegistroAlumnos.ResumeLayout(false);
            this.gbRegistroAlumnos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistroAlumnos;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblRegistrocarnet;
        private System.Windows.Forms.Label lblRegistroApellido;
        private System.Windows.Forms.Label lblRegistroNombre;
        private System.Windows.Forms.Button tbnRegistrarAlumnos;
    }
}