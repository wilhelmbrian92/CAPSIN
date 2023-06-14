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
            picPulmones.ImageLocation = "https://img3.freepng.es/dy/9969a45ece9a773020572e4a08a2d6b2/L0KzQoG3U8AzN6dnkZH9cnHxg8HokvVvfF5xjdDwcz3mf8fwhL1kd6N0htM2dnn1hcS0hPl0bZJ4fZ8AZUXnQoLrhvI2QWNmS5CDMES3RIqAUsE2QGQ2TqMDMkO6RISATwBvbz==/transparent-lungs-covid-corona-virus-disease-5e5d21dfb592a3.8044497215831618237437.png";
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
            abrirPanelFrm(new Consulta());
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            abrirPanelFrm(new Calendario());
        }

        private void Presentacion_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
