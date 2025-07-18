namespace Vistas.Formularios
{
    partial class frmIngresarCursos
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
            this.gbRegistroCursos = new System.Windows.Forms.GroupBox();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbRegistroCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegistroCursos
            // 
            this.gbRegistroCursos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbRegistroCursos.Controls.Add(this.txtNombreCurso);
            this.gbRegistroCursos.Controls.Add(this.lblNombreCurso);
            this.gbRegistroCursos.ForeColor = System.Drawing.Color.SandyBrown;
            this.gbRegistroCursos.Location = new System.Drawing.Point(219, 119);
            this.gbRegistroCursos.Name = "gbRegistroCursos";
            this.gbRegistroCursos.Size = new System.Drawing.Size(251, 142);
            this.gbRegistroCursos.TabIndex = 0;
            this.gbRegistroCursos.TabStop = false;
            this.gbRegistroCursos.Text = "Registro de cursos";
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.ForeColor = System.Drawing.Color.PeachPuff;
            this.lblNombreCurso.Location = new System.Drawing.Point(7, 37);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(91, 13);
            this.lblNombreCurso.TabIndex = 0;
            this.lblNombreCurso.Text = "Nombre de curso:";
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(10, 62);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCurso.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.ForeColor = System.Drawing.Color.PeachPuff;
            this.button1.Location = new System.Drawing.Point(229, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Registrar Cursos";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmIngresarCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbRegistroCursos);
            this.Name = "frmIngresarCursos";
            this.Text = "frmCursos";
            this.gbRegistroCursos.ResumeLayout(false);
            this.gbRegistroCursos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistroCursos;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.Button button1;
    }
}