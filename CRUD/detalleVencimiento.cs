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
    public partial class detalleVencimiento : Form
    {
        DateTime fechaSel;
        Logica detalleNegocio = new Logica();
        //constructor
        public detalleVencimiento(DateTime fechaSeleccionada)
        {
            InitializeComponent();
            fechaSel = fechaSeleccionada; 
        }



        private void detalleVencimiento_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            CargarDatos();
        }
        private void CargarDatos()
        {

            //aca faltaria una variable que contenga el DateTime de la fecha vencimiento




            DataTable dtRegistros = detalleNegocio.ObtenerRegistrosPorFechaVencimiento(fechaSel);

            // Haz lo que necesites con los registros obtenidos, como mostrarlos en un DataGridView
            dataGridView1.DataSource = dtRegistros;
        }


    }
}
