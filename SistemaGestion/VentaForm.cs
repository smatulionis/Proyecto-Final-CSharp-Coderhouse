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
    public partial class VentaForm : Form
    {
        public VentaForm()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtId.Text = "";
            txtComentarios.Text = "";
            txtIdUsuario.Text = "";
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                Program.form1.id = 0;
                Program.form1.CargaVentas();
                Program.form1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar volver: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VentaForm_Load(object sender, EventArgs e)
        {
            try
            {
                int idVenta = Program.form1.id;
                if (idVenta > 0)
                {
                    Venta _txtVenta = VentaBusiness.ObtenerVenta(idVenta);

                    txtId.Text = idVenta.ToString();
                    txtComentarios.Text = _txtVenta.Comentarios;
                    txtIdUsuario.Text = _txtVenta.IdUsuario.ToString();
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
                VentaBusiness.EliminarVenta(int.Parse(id));
                MessageBox.Show("Se borró la venta");
                limpiar();
                Program.form1.id = 0;
                this.Close();
                Program.form1.CargaVentas();
                Program.form1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar eliminar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void boton_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string comentarios = txtComentarios.Text;
                int idUsuario = int.Parse(txtIdUsuario.Text);

                int idVenta = Program.form1.id;

                Venta nuevaVenta = new Venta(comentarios, idUsuario);

                if (idVenta > 0)
                {
                    VentaBusiness.ModificarVenta(idVenta, nuevaVenta);
                    MessageBox.Show("Se actualizó la venta");
                }
                else
                {
                    VentaBusiness.CrearVenta(nuevaVenta);
                    MessageBox.Show("Se creó la nueva venta");
                }

                limpiar();
                this.Close();
                Program.form1.id = 0;
                Program.form1.CargaVentas();
                Program.form1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}
