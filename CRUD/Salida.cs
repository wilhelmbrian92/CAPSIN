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
        int restante = 0;


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
            lblLoteN.Text = "";
            DataTable dt = new DataTable();
            dt = negocioSalida.ObtenerProductosPorID(idProducto);
            dgvDetalle.DataSource = dt;
            try {
                lblLoteN.Text = dgvDetalle.Rows[0].Cells[0].Value.ToString();
                restante= Convert.ToInt32(dgvDetalle.Rows[0].Cells[4].Value.ToString());

            }
            catch { MessageBox.Show("La consulta no obtuvo ningun registro."); }
        }

        private void dgvDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener el valor de la celda en la fila y columna seleccionadas
                DataGridViewCell cell = dgvDetalle.Rows[e.RowIndex].Cells[0];
                string valor = cell.Value.ToString();
                restante = Convert.ToInt32(dgvDetalle.Rows[e.RowIndex].Cells[4].Value.ToString());

                lblLoteN.Text = valor;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            if (restante >= int.Parse(txtCantidad.Text)) {
                DialogResult resultado = MessageBox.Show("Confirmar salida", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    try
                    {
                        int loteID = int.Parse(lblLoteN.Text);
                        int nuevaCantidad = int.Parse(txtCantidad.Text);
                        nuevaCantidad = restante - nuevaCantidad;
                        negocioSalida.ActualizarCantidad(loteID, nuevaCantidad);
                        MessageBox.Show("La actualización se realizó correctamente.");
                        btnBuscar_Click(null,null);
                    }
                    catch { MessageBox.Show("Hubo un error al tratar de procesar su solicitud. Por favor verifique que los campos sean correctos y vuelva a intentarlo."); }
                }
            }
            else { MessageBox.Show("El valor de extraccion debe ser mayor al restante"); }
        }


        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
