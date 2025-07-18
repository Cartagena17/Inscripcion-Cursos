namespace Vistas.Formularios
{
    partial class frmVerCurso
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
            this.dgvEliminarCurso = new System.Windows.Forms.DataGridView();
            this.btnEliminarCurso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEliminarCurso
            // 
            this.dgvEliminarCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminarCurso.Location = new System.Drawing.Point(117, 44);
            this.dgvEliminarCurso.Name = "dgvEliminarCurso";
            this.dgvEliminarCurso.Size = new System.Drawing.Size(547, 254);
            this.dgvEliminarCurso.TabIndex = 0;
            // 
            // btnEliminarCurso
            // 
            this.btnEliminarCurso.Location = new System.Drawing.Point(197, 350);
            this.btnEliminarCurso.Name = "btnEliminarCurso";
            this.btnEliminarCurso.Size = new System.Drawing.Size(202, 57);
            this.btnEliminarCurso.TabIndex = 1;
            this.btnEliminarCurso.Text = "Eliminar Curso";
            this.btnEliminarCurso.UseVisualStyleBackColor = true;
            // 
            // frmVerCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarCurso);
            this.Controls.Add(this.dgvEliminarCurso);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmVerCurso";
            this.Text = "frmVerCurso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEliminarCurso;
        private System.Windows.Forms.Button btnEliminarCurso;
    }
}