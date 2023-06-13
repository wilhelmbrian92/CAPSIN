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
    public partial class Presentacion : Form
    {

        
        public Presentacion()
        {
            InitializeComponent();
        }
        //creamos variable de formulario para cargar form en panel
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
            abrirPanelFrm(new Consulta());
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            abrirPanelFrm(new Calendario());
        }
    }
}
