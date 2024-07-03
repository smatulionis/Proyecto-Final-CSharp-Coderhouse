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
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";         
            txtNombreUsuario.Text = "";
            txtContrasenia.Text = "";         
            txtMail.Text = "";
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                Program.form1.id = 0;
                Program.form1.CargaUsuarios();
                Program.form1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar volver: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {
            try
            {
                int idUsuario = Program.form1.id;
                if (idUsuario > 0)
                {
                    Usuario _txtUsuario = UsuarioBusiness.TraerUsuario(idUsuario);

                    txtId.Text = idUsuario.ToString();
                    txtNombre.Text = _txtUsuario.Nombre;
                    txtApellido.Text = _txtUsuario.Apellido;
                    txtNombreUsuario.Text = _txtUsuario.NombreUsuario;
                    txtContrasenia.Text = _txtUsuario.Contrasenia;
                    txtMail.Text = _txtUsuario.Mail;
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
                UsuarioBusiness.EliminarUsuario(int.Parse(id));
                MessageBox.Show("Se borró el usuario");
                limpiar();
                Program.form1.id = 0;
                this.Close();
                Program.form1.CargaUsuarios();
                Program.form1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar eliminar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void boton_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string nombreUsuario = txtNombreUsuario.Text;
                string contrasenia = txtContrasenia.Text;
                string mail = txtMail.Text;

                int idUsuario = Program.form1.id;

                Usuario nuevoUsuario = new Usuario(nombre, apellido, nombreUsuario, contrasenia, mail);

                if (idUsuario > 0)
                {
                    UsuarioBusiness.ModificarUsuario(idUsuario, nuevoUsuario);
                    MessageBox.Show("Se actualizó el usuario");
                }
                else
                {
                    UsuarioBusiness.CrearUsuario(nuevoUsuario);
                    MessageBox.Show("Se creó el nuevo usuario");
                }

                limpiar();
                this.Close();
                Program.form1.id = 0;
                Program.form1.CargaUsuarios();
                Program.form1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}
