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
    public partial class ProductoVendidoForm : Form
    {
        public ProductoVendidoForm()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtId.Text = "";
            txtStock.Text = "";
            txtIdProducto.Text = "";
            txtIdVenta.Text = "";         
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                Program.form1.id = 0;
                Program.form1.CargaProductosVendidos();
                Program.form1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar volver: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProductoVendido_Load(object sender, EventArgs e)
        {
            try
            {
                int idProductoVendido = Program.form1.id;
                if (idProductoVendido > 0)
                {
                    ProductoVendido _txtProductoVendido = ProductoVendidoBusiness.ObtenerProductoVendido(idProductoVendido);

                    txtId.Text = idProductoVendido.ToString();
                    txtStock.Text = _txtProductoVendido.Stock.ToString();
                    txtIdProducto.Text = _txtProductoVendido.IdProducto.ToString();
                    txtIdVenta.Text = _txtProductoVendido.IdVenta.ToString();
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
                ProductoVendidoBusiness.EliminarProductoVendido(int.Parse(id));
                MessageBox.Show("Se borró el producto");
                limpiar();
                Program.form1.id = 0;
                this.Close();
                Program.form1.CargaProductosVendidos();
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
                int stock = int.Parse(txtStock.Text);
                int idProducto = int.Parse(txtIdProducto.Text);
                int idVenta = int.Parse(txtIdVenta.Text);

                int idProductoVendido = Program.form1.id;

                ProductoVendido nuevoProductoVendido = new ProductoVendido(stock, idProducto, idVenta);

                if (idProductoVendido > 0)
                {
                    ProductoVendidoBusiness.ModificarProductoVendido(idProductoVendido, nuevoProductoVendido);
                    MessageBox.Show("Se actualizó el producto");
                }
                else
                {
                    ProductoVendidoBusiness.CrearProductoVendido(nuevoProductoVendido);
                    MessageBox.Show("Se creó el nuevo producto");
                }

                limpiar();
                this.Close();
                Program.form1.id = 0;
                Program.form1.CargaProductosVendidos();
                Program.form1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}
