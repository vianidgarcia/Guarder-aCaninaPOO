using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace GuarderíaCanina
{
    public partial class FormClientesMascotas : Form
    {
        private GestorReservas gestor;

        public class ClienteComboItem
        {
            public string Id { get; set; }
            public string Nombre { get; set; }

            public override string ToString() => $"{Id} - {Nombre}";
        }

        public FormClientesMascotas(GestorReservas gestorReservas)
        {
            InitializeComponent();
            gestor = gestorReservas;
        }

        #region Registro de Clientes

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdCliente.Text) ||
                    string.IsNullOrWhiteSpace(txtNombreCliente.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefono.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos del cliente.", "Campos requeridos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                gestor.RegistrarCliente(txtIdCliente.Text.Trim(), txtNombreCliente.Text.Trim(), txtTelefono.Text.Trim());

                MessageBox.Show($"Cliente '{txtNombreCliente.Text.Trim()}' registrado exitosamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCamposCliente();
                ActualizarListaClientes();
                CargarClientesEnComboBox();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Registro de Mascotas

        private void btnAgregarMascota_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbClientesMascotas.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione un cliente.", "Cliente requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombreMascota.Text) ||
                    string.IsNullOrWhiteSpace(txtRaza.Text) ||
                    string.IsNullOrWhiteSpace(txtPeso.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos de la mascota.", "Campos requeridos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var clienteItem = (ClienteComboItem)cmbClientesMascotas.SelectedItem;
                string idCliente = clienteItem.Id;

                DateTime fechaNacimiento = DateTime.Today.AddYears(-(int)numEdad.Value);

                gestor.RegistrarMascota(idCliente, txtNombreMascota.Text.Trim(),
                    txtRaza.Text.Trim(), fechaNacimiento, txtPeso.Text.Trim());

                MessageBox.Show($"Mascota '{txtNombreMascota.Text.Trim()}' registrada exitosamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCamposMascota();
                ActualizarListaClientes();
                // ERROR #4 CORREGIDO: Actualizar ComboBox después de agregar mascota
                CargarClientesEnComboBox();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Error al obtener la información del cliente seleccionado.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Métodos de Actualización

        private void ActualizarListaClientes()
        {
            lstClientes.Items.Clear();
            var clientes = gestor.ObtenerTodosLosClientes();

            if (clientes.Count == 0)
            {
                lstClientes.Items.Add("No hay clientes registrados.");
                return;
            }

            foreach (var cliente in clientes)
            {
                lstClientes.Items.Add(cliente.ToString());

                if (cliente.ListaMascotas.Count > 0)
                {
                    foreach (var mascota in cliente.ListaMascotas)
                    {
                        lstClientes.Items.Add($"    🐕 {mascota.ToString()}");
                    }
                }
                else
                {
                    lstClientes.Items.Add("    (Sin mascotas registradas)");
                }

                lstClientes.Items.Add("");
            }
        }

        private void CargarClientesEnComboBox()
        {
            var clientes = gestor.ObtenerTodosLosClientes();

            var clientesItems = clientes.Select(c => new ClienteComboItem
            {
                Id = c.IdCliente,
                Nombre = c.Nombre
            }).ToList();

            cmbClientesMascotas.DataSource = null;
            cmbClientesMascotas.DataSource = clientesItems;
            cmbClientesMascotas.DisplayMember = "ToString";
        }

        #endregion

        #region Métodos de Limpieza

        private void LimpiarCamposCliente()
        {
            txtIdCliente.Clear();
            txtNombreCliente.Clear();
            txtTelefono.Clear();
        }

        private void LimpiarCamposMascota()
        {
            txtNombreMascota.Clear();
            txtRaza.Clear();
            txtPeso.Clear();
            numEdad.Value = 0;
        }

        #endregion

        #region Eventos del Formulario

        private void FormClientesMascotas_Load(object sender, EventArgs e)
        {
            ActualizarListaClientes();
            CargarClientesEnComboBox();
        }

        private void btnIrReservas_Click(object sender, EventArgs e)
        {
            FormReservasServicios formReservas = new FormReservasServicios(gestor);
            formReservas.Show();
            this.Hide();
        }

        private void FormClientesMascotas_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cerrar la aplicación completamente si se cierra este formulario
            Application.Exit();
        }

        #endregion

        private void lblPeso_Click(object sender, EventArgs e)
        {

        }

        private void txtRaza_TextChanged(object sender, EventArgs e)
        {

        }
    }
}