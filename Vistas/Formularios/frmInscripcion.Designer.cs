namespace Vistas.Formularios
{
    partial class frmInscripcion
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
            this.lblDatosInscripcion = new System.Windows.Forms.Label();
            this.lblCarnet = new System.Windows.Forms.Label();
            this.lblSeleccionCurso = new System.Windows.Forms.Label();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.cbCarnet = new System.Windows.Forms.ComboBox();
            this.dtpFechaInscripcion = new System.Windows.Forms.DateTimePicker();
            this.cbSeleccionCurso = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDatosInscripcion
            // 
            this.lblDatosInscripcion.AutoSize = true;
            this.lblDatosInscripcion.Location = new System.Drawing.Point(256, 49);
            this.lblDatosInscripcion.Name = "lblDatosInscripcion";
            this.lblDatosInscripcion.Size = new System.Drawing.Size(104, 13);
            this.lblDatosInscripcion.TabIndex = 0;
            this.lblDatosInscripcion.Text = "Datos de Inscripcion";
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Location = new System.Drawing.Point(213, 76);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(38, 13);
            this.lblCarnet.TabIndex = 1;
            this.lblCarnet.Text = "Carnet";
            // 
            // lblSeleccionCurso
            // 
            this.lblSeleccionCurso.AutoSize = true;
            this.lblSeleccionCurso.Location = new System.Drawing.Point(213, 132);
            this.lblSeleccionCurso.Name = "lblSeleccionCurso";
            this.lblSeleccionCurso.Size = new System.Drawing.Size(107, 13);
            this.lblSeleccionCurso.TabIndex = 2;
            this.lblSeleccionCurso.Text = "Seleccionar un curso";
            // 
            // btnInscribir
            // 
            this.btnInscribir.Location = new System.Drawing.Point(216, 253);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(75, 23);
            this.btnInscribir.TabIndex = 3;
            this.btnInscribir.Text = "INSCRIBIR";
            this.btnInscribir.UseVisualStyleBackColor = true;
            // 
            // cbCarnet
            // 
            this.cbCarnet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarnet.FormattingEnabled = true;
            this.cbCarnet.Location = new System.Drawing.Point(216, 92);
            this.cbCarnet.Name = "cbCarnet";
            this.cbCarnet.Size = new System.Drawing.Size(121, 21);
            this.cbCarnet.TabIndex = 4;
            // 
            // dtpFechaInscripcion
            // 
            this.dtpFechaInscripcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInscripcion.Location = new System.Drawing.Point(216, 188);
            this.dtpFechaInscripcion.Name = "dtpFechaInscripcion";
            this.dtpFechaInscripcion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInscripcion.TabIndex = 5;
            // 
            // cbSeleccionCurso
            // 
            this.cbSeleccionCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeleccionCurso.FormattingEnabled = true;
            this.cbSeleccionCurso.Location = new System.Drawing.Point(216, 148);
            this.cbSeleccionCurso.Name = "cbSeleccionCurso";
            this.cbSeleccionCurso.Size = new System.Drawing.Size(121, 21);
            this.cbSeleccionCurso.TabIndex = 6;
            // 
            // frmInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbSeleccionCurso);
            this.Controls.Add(this.dtpFechaInscripcion);
            this.Controls.Add(this.cbCarnet);
            this.Controls.Add(this.btnInscribir);
            this.Controls.Add(this.lblSeleccionCurso);
            this.Controls.Add(this.lblCarnet);
            this.Controls.Add(this.lblDatosInscripcion);
            this.Name = "frmInscripcion";
            this.Text = "frmInscripcion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatosInscripcion;
        private System.Windows.Forms.Label lblCarnet;
        private System.Windows.Forms.Label lblSeleccionCurso;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.ComboBox cbCarnet;
        private System.Windows.Forms.DateTimePicker dtpFechaInscripcion;
        private System.Windows.Forms.ComboBox cbSeleccionCurso;
    }
}