namespace Vistas.Formularios
{
    partial class frmVerInscripciones
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
            this.dgvVerInscripciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerInscripciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVerInscripciones
            // 
            this.dgvVerInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerInscripciones.Location = new System.Drawing.Point(128, 45);
            this.dgvVerInscripciones.Name = "dgvVerInscripciones";
            this.dgvVerInscripciones.Size = new System.Drawing.Size(616, 359);
            this.dgvVerInscripciones.TabIndex = 0;
            // 
            // frmVerInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvVerInscripciones);
            this.Name = "frmVerInscripciones";
            this.Text = "frmVerInscripciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerInscripciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVerInscripciones;
    }
}