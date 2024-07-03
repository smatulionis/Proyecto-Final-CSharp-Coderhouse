using SistemaGestionBusiness;
using SistemaGestionData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion
{
    public partial class ProductoForm : Form
    {
        public ProductoForm()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtId.Text = "";
            txtDescripcion.Text = "";
            txtCosto.Text = "";
            txtPrecioVenta.Text = "";
            txtStock.Text = "";
            txtIdUsuario.Text = "";
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                Program.form1.id = 0;
                Program.form1.CargaProductos();
                Program.form1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar volver: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProductoForm_Load(object sender, EventArgs e)
        {
            try
            {
                int idProducto = Program.form1.id;
                if (idProducto > 0)
                {
                    Producto _txtProducto = ProductoBusiness.ObtenerProducto(idProducto);

                    txtId.Text = idProducto.ToString();
                    txtDescripcion.Text = _txtProducto.Descripcion;
                    txtCosto.Text = _txtProducto.Costo.ToString();
                    txtPrecioVenta.Text = _txtProducto.PrecioVenta.ToString();
                    txtStock.Text = _txtProducto.Stock.ToString();
                    txtIdUsuario.Text = _txtProducto.IdUsuario.ToString();
                }
                else
                {
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void boton_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtId.Text;
                ProductoBusiness.EliminarProducto(int.Parse(id));
                MessageBox.Show("Se borró el producto");
                limpiar();
                Program.form1.id = 0;
                this.Close();
                Program.form1.CargaProductos();
                Program.form1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void boton_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string descripcion = txtDescripcion.Text;
                double costo = double.Parse(txtCosto.Text);
                double precioVenta = double.Parse(txtPrecioVenta.Text);
                int stock = int.Parse(txtStock.Text);
                int idUsuario = int.Parse(txtIdUsuario.Text);

                int idProducto = Program.form1.id;

                Producto nuevoProducto = new Producto(descripcion, costo, precioVenta, stock, idUsuario);

                if (idProducto > 0)
                {
                    ProductoBusiness.ModificarProducto(idProducto, nuevoProducto);
                    MessageBox.Show("Se actualizó el producto");
                }
                else
                {
                    ProductoBusiness.CrearProducto(nuevoProducto);
                    MessageBox.Show("Se creó el nuevo producto");
                }

                limpiar();
                this.Close();
                Program.form1.id = 0;
                Program.form1.CargaProductos();
                Program.form1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}
