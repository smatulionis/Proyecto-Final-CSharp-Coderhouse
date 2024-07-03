using SistemaGestionBusiness;

namespace SistemaGestion
{
    public partial class Form1 : Form
    {
        public int id;
        public string datosCargados;
        public Form1()
        {
            InitializeComponent();
            CargaProductos();
        }

        internal void CargaProductos()
        {
            try
            {
                comboBox1.SelectedIndex = 0;
                dgvGeneral.AutoGenerateColumns = true;
                dgvGeneral.DataSource = ProductoBusiness.TraerProductos();
                datosCargados = "Productos";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void CargaProductosVendidos()
        {
            try
            {
                comboBox1.SelectedIndex = 1;
                dgvGeneral.AutoGenerateColumns = true;
                dgvGeneral.DataSource = ProductoVendidoBusiness.ListarProductosVendidos();
                datosCargados = "Productos Vendidos";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos vendidos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void CargaUsuarios()
        {
            try
            {
                comboBox1.SelectedIndex = 2;
                dgvGeneral.AutoGenerateColumns = true;
                dgvGeneral.DataSource = UsuarioBusiness.ListarUsuarios();
                datosCargados = "Usuarios";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void CargaVentas()
        {
            try
            {
                comboBox1.SelectedIndex = 3;
                dgvGeneral.AutoGenerateColumns = true;
                dgvGeneral.DataSource = VentaBusiness.TraerVentas();
                datosCargados = "Ventas";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedValue = comboBox1.SelectedItem.ToString();
                switch (selectedValue)
                {
                    case "Productos":
                        CargaProductos();
                        break;
                    case "Productos Vendidos":
                        CargaProductosVendidos();
                        break;
                    case "Usuarios":
                        CargaUsuarios();
                        break;
                    case "Ventas":
                        CargaVentas();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar el elemento del combo box: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void boton_agregar_Click(object sender, EventArgs e)
        {
            MostrarFormulario(datosCargados);
        }

        private void dgvGeneral_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int filaSeleccionada = e.RowIndex;
                    id = int.Parse(dgvGeneral[0, filaSeleccionada].Value.ToString());
                }

                MostrarFormulario(datosCargados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar mostrar el formulario: " + ex.Message);
            }
        }

        private void MostrarFormulario(string datosCargados)
        {
            try
            {
                Form formularioAMostrar = null;

                switch (datosCargados)
                {
                    case "Productos":
                        formularioAMostrar = new ProductoForm();
                        break;
                    case "Productos Vendidos":
                        formularioAMostrar = new ProductoVendidoForm();
                        break;
                    case "Usuarios":
                        formularioAMostrar = new UsuarioForm();
                        break;
                    case "Ventas":
                        formularioAMostrar = new VentaForm();
                        break;
                    default:
                        throw new ArgumentException("Tipo de datos cargados no válido: " + datosCargados);
                }

                if (formularioAMostrar != null)
                {
                    Program.form1.Hide();
                    formularioAMostrar.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar mostrar el formulario: " + ex.Message);
            }
        }
    }
}
