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
    public partial class Registrar_ENTRADA : Form
    {
        int idProducto;
        string proveedor;
        string presentacion;
        int loteID;
        string NCaja;
        Logica logica = new Logica();
        DateTime fechaEntrada = DateTime.Now.Date;

        //constructor
        public Registrar_ENTRADA()
        {
            InitializeComponent();
            CargarNombresProductos();
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.BackColor = Color.FromArgb(45, 45, 45);
            btnAceptar.ForeColor = Color.Silver;

        }

        private void Registrar_ENTRADA_Load(object sender, EventArgs e)
        {
           
        }

        private void CargarNombresProductos()
        {
            cboxProductos.Items.Clear();
            cboxProductos.Items.AddRange(logica.ObtenerNombresProductos());

            // Habilitar la función de autocompletar y establecer la fuente de autocompletar como CustomSource
            cboxProductos.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboxProductos.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Establecer la lista de sugerencias para el autocompletar utilizando los nombres de los productos
            cboxProductos.AutoCompleteCustomSource.AddRange(logica.ObtenerNombresProductos());
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try { Convert.ToInt32(txtCantidad.Text); }
            catch 
            {
                MessageBox.Show("Los datos ingresados son incorrectos. Debe ingresar un valor numérico para cantidad.","Error");
                txtCantidad.Text = "";
            }

            if ((cboxProductos.Text == "")||(txtCantidad.Text=="")|| (txtCaja.Text == "") || (txtProveedor.Text == "") || (txtPresentacion.Text == "")) MessageBox.Show("Error. Debe completar todos los campos");
            else
            {
                //inserta registro en tabla Lote
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                DateTime fechaVencimiento = dtpVencimiento.Value.Date;
                NCaja = txtCaja.Text;
               proveedor = txtProveedor.Text;
                presentacion = txtPresentacion.Text;

                if (logica.InsertarLote(presentacion,NCaja,idProducto, cantidad, fechaVencimiento, out int idLote))
                {
                    MessageBox.Show("Los registros se han insertado correctamente en la tabla Lote." );
                    loteID = idLote;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al insertar los registros en la tabla Lote.");
                }


                if (logica.InsertarEntrada(cantidad,loteID, fechaEntrada, proveedor))
                {
                    MessageBox.Show("El registro se ha insertado correctamente en la tabla Entradas.");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al insertar el registro en la tabla Entradas.");
                }
               
            }
            txtCantidad.Text = "";
            cboxProductos.Text = "";
            txtCaja.Text = "";
            txtProveedor.Text = "";
            txtPresentacion.Text = "";
        }
        
        private void cboxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreProducto = cboxProductos.SelectedItem.ToString();
            idProducto = logica.ObtenerIDProducto(nombreProducto);
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
