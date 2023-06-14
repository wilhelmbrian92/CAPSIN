using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD
{
    public partial class Consulta : Form
    {
        Logica negocio = new Logica();
        public Consulta()
        {
            InitializeComponent();
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();      }

        private void Consulta_Load(object sender, EventArgs e)
        {
            CargarDatos();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 8);
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.ReadOnly = true;
        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = negocio.ObtenerVistaProductoLoteEntradas();
        }


    }
}
