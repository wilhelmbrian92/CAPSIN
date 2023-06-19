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
    public partial class Salida : Form
    {
        Logica negocioSalida = new Logica();
        int idProducto=0;
        public Salida()
        {
            InitializeComponent();
          
        }

        private void Salida_Load(object sender, EventArgs e)
        {
            CargarNombresProductos();
        }

        private void CargarNombresProductos()
        {
            cboxProductos.Items.Clear();
            cboxProductos.Items.AddRange(negocioSalida.ObtenerNombresProductos());

            // Habilitar la función de autocompletar y establecer la fuente de autocompletar como CustomSource
            cboxProductos.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboxProductos.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Establecer la lista de sugerencias para el autocompletar utilizando los nombres de los productos
            cboxProductos.AutoCompleteCustomSource.AddRange(negocioSalida.ObtenerNombresProductos());
        }

        private void cboxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreProducto = cboxProductos.SelectedItem.ToString();
            idProducto = negocioSalida.ObtenerIDProducto(nombreProducto);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = negocioSalida.ObtenerProductosPorID(idProducto);

            dgvDetalle.DataSource = dt;
        }
    }
}
