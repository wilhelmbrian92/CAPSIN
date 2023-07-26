using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Inicio : Form
    {

        public Inicio()
        {
            InitializeComponent();
            picLogoBrown.ImageLocation = "https://licencias.transito.brown.gob.ar/assets/images/brown-logo.png";
            picLogo.ImageLocation = "http://webserver92.somee.com/pngwing.com.png";
        }


        //funcion para cargar form hijo en panel
        private Form activefrm = null;
       private void abrirPanelFrm(Form frmHijo) {
            if (activefrm != null) activefrm.Close();
            activefrm = frmHijo;
            frmHijo.TopLevel = false;
            frmHijo.FormBorderStyle = FormBorderStyle.None;
            frmHijo.Dock = DockStyle.Fill;
            panelFrm.Controls.Add(frmHijo);
            panelFrm.Tag = frmHijo;
            panelFrm.BringToFront();
            frmHijo.Show();
        }

      
        private void btnAlta_Click(object sender, EventArgs e)
        {
            abrirPanelFrm(new Alta());
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            abrirPanelFrm(new Registrar_ENTRADA());
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            abrirPanelFrm(new Salida());
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            abrirPanelFrm(new Calendario());
        }

        private void Presentacion_Load(object sender, EventArgs e)
        {

        }
        
        private void btnSalida_Click(object sender, EventArgs e)
        {
            abrirPanelFrm(new Consulta());
            
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
