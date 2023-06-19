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
            CargarSalidas();

            dgvEntrada.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEntrada.DefaultCellStyle.Font = new Font("Arial", 8);
            dgvEntrada.ForeColor = Color.Black;
            dgvEntrada.ReadOnly = true;
        }

        private void CargarDatos()
        {
            dgvEntrada.DataSource = negocio.ObtenerVistaProductoLoteEntradas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el registro seleccionado? Una vez que se elimine no podrá recuperarlo.","Alerta",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (resultado == DialogResult.OK) { }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modificar frmModificar = new Modificar();
            frmModificar.ShowDialog();
        }
        private void CargarSalidas()
        {
            DataTable dtSalidas = negocio.ObtenerSalidas();
            dgvSalida.DataSource = dtSalidas;
        }

    }
}
