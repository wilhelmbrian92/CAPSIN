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
    public partial class Calendario : Form
    {
        Logica calendarioNegocio = new Logica();
      
        public Calendario()
        {
            InitializeComponent();
        }

        private void Calendario_Load(object sender, EventArgs e)
        {
            CargarFechasResaltadas();
            
        }

        private void CargarFechasResaltadas()
        {
            Datos datos = new Datos();
            DateTime[] fechasResaltadas = datos.ObtenerFechasVencimiento();

          
                calendarioVencimientos.BoldedDates = fechasResaltadas;
            
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
