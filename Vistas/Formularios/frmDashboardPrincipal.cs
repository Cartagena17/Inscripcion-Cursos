using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{

    public partial class frmDashboardPrincipal : Form
    {
        public frmDashboardPrincipal()
        {
            InitializeComponent();
        }
     

     


        private void frmDashboardPrincipal_Load(object sender, EventArgs e)
        {
            OcultarSubMenu(false);
        }
        #region
        private void OcultarSubMenu (bool estado)
        {
            pnlMantenimientoCursos.Visible = estado;
            pnlMantenimientoEstudiante.Visible = estado;
            pnlMantenimientoInscripcion.Visible = estado;
            
        }
        #endregion

        private void btnGestionarCurso_Click(object sender, EventArgs e)
        {
            pnlMantenimientoEstudiante.Visible = false;
            pnlMantenimientoInscripcion.Visible = false;
            if (pnlMantenimientoCursos.Visible == false)
            {
                pnlMantenimientoCursos.Visible = true;
            }
            else
            {
                OcultarSubMenu(false);
            }
        }

        private void btnGestionarEstudiantes_Click(object sender, EventArgs e)
        {
            pnlMantenimientoCursos.Visible = false;
            pnlMantenimientoInscripcion.Visible = false;
            if (pnlMantenimientoEstudiante.Visible == false)
            {
                pnlMantenimientoEstudiante.Visible = true;
            }
            else
            {
                OcultarSubMenu(false);
            }
        }

        private void btnGestionarInscripcion_Click(object sender, EventArgs e)
        {
            pnlMantenimientoEstudiante.Visible = false;
            pnlMantenimientoEstudiante.Visible = false;
            if (pnlMantenimientoInscripcion.Visible == false)
            {
                pnlMantenimientoInscripcion.Visible = true;
            }
            else
            {
                OcultarSubMenu(false);
            }
           
        }
        #region
        //crear atributo priv tipo FORM
        private Form activarForm = null;
        private void AbrirForm(Form formularioPintar)
        {
            if (activarForm!=null)
            {
                activarForm.Close();
            }
            //Vamos a darle todo lo q recibe por parametros al atributo
            //Esto con el fin de manipular los formularios q se reciben por parametro
            activarForm = formularioPintar;
            formularioPintar.TopLevel = false;
            formularioPintar.FormBorderStyle=FormBorderStyle.None;
            formularioPintar.Dock = DockStyle.Fill;
            pnlCentral.Controls.Add(formularioPintar);
            formularioPintar.BringToFront();
            formularioPintar.Show();
        }



        #endregion

        private void btnVerCurso_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmVerCurso());
        }

        private void btnRegistrarCurso_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmIngresarCursos());
        }

        private void btnVerEstudiante_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmVerEstudiantes());
        }

        private void btnIngresarEstudiante_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmIngresarEstudiantes());
        }

        private void btnVerInscripcion_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmVerInscripciones());
        }

        private void btnRegistrarInscripcion_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmInscripcion());
        }
    }
}
