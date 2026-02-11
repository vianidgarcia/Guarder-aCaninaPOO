using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace GuarderíaCanina
{
    public partial class FormReservasServicios : Form
    {
        private GestorReservas gestor;

        public class ClienteComboItem
        {
            public string Id { get; set; }
            public string Nombre { get; set; }

            public override string ToString() => $"{Id} - {Nombre}";
        }

        public FormReservasServicios(GestorReservas gestorReservas)
        {
            InitializeComponent();
            gestor = gestorReservas;
        }

        #region Pestaña Reservas

        private void cmbClientesReservas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientesReservas.SelectedIndex == -1) return;

            try
            {
                var clienteItem = (ClienteComboItem)cmbClientesReservas.SelectedItem;
                string idCliente = clienteItem.Id;

                var mascotas = gestor.ObtenerNombresMascotas(idCliente);
                cmbMascotasReservas.DataSource = mascotas;
                cmbMascotasReservas.Enabled = mascotas.Count > 0;
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Error al obtener la información del cliente.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearReserva_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbClientesReservas.SelectedIndex == -1 || cmbMascotasReservas.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione un cliente y una mascota.", "Campos requeridos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var clienteItem = (ClienteComboItem)cmbClientesReservas.SelectedItem;
                string idCliente = clienteItem.Id;
                string nombreMascota = cmbMascotasReservas.SelectedItem.ToString();

                gestor.CrearReserva(idCliente, nombreMascota, dtpFechaIngreso.Value);

                MessageBox.Show($"Reserva creada exitosamente para '{nombreMascota}'.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ActualizarListaReservas();
                // ERROR #8 CORREGIDO: Sincronización entre pestañas
                CargarReservasEnComboBox();
                tabControl.SelectedIndex = 1; // Cambiar a pestaña de Servicios
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarListaReservas()
        {
            txtReservas.Clear();
            var reservas = gestor.ObtenerTodasLasReservas();

            if (reservas.Count == 0)
            {
                txtReservas.Text = "No hay reservas registradas.";
                return;
            }

            for (int i = 0; i < reservas.Count; i++)
            {
                txtReservas.AppendText($"═══════════════════════════════════════════════════\r\n");
                txtReservas.AppendText($"RESERVA #{i + 1}\r\n");
                txtReservas.AppendText($"═══════════════════════════════════════════════════\r\n");
                txtReservas.AppendText(reservas[i].ObtenerResumenCompleto());
                txtReservas.AppendText("\r\n\r\n");
            }
        }

        private void CargarReservasEnComboBox()
        {
            var reservas = gestor.ObtenerResumenReservas();
            cmbReservasServicios.DataSource = null;
            cmbReservasServicios.DataSource = reservas;
        }

        #endregion

        #region Pestaña Servicios

        private void cmbReservasServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReservasServicios.SelectedIndex == -1) return;

            ActualizarListaServiciosDeReserva();
        }

        private void ActualizarListaServiciosDeReserva()
        {
            int indiceReserva = cmbReservasServicios.SelectedIndex;
            var servicios = gestor.ObtenerResumenServiciosEnReserva(indiceReserva);

            lstServicios.Items.Clear();

            if (servicios.Count == 0)
            {
                lstServicios.Items.Add("(Sin servicios registrados)");
            }
            else
            {
                foreach (var servicio in servicios)
                {
                    lstServicios.Items.Add(servicio);
                }
            }
        }

        private void cmbTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelHospedaje.Visible = false;
            panelLimpieza.Visible = false;
            panelPaseo.Visible = false;

            // ERROR #7 CORREGIDO: Agregar default case en switch
            switch (cmbTipoServicio.SelectedIndex)
            {
                case 0:
                    panelHospedaje.Visible = true;
                    break;
                case 1:
                    panelLimpieza.Visible = true;
                    break;
                case 2:
                    panelPaseo.Visible = true;
                    break;
                default:
                    // Si por alguna razón hay un índice inválido, mostrar Hospedaje por defecto
                    panelHospedaje.Visible = true;
                    break;
            }
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbReservasServicios.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione una reserva.", "Campo requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int indiceReserva = cmbReservasServicios.SelectedIndex;
                Servicio servicio = null;

                // ERROR #7 CORREGIDO: Agregar default case en switch
                switch (cmbTipoServicio.SelectedIndex)
                {
                    case 0: // Hospedaje
                        int dias = (int)numDias.Value;
                        if (dias == 0)
                        {
                            MessageBox.Show("La cantidad de días debe ser mayor a 0.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        servicio = gestor.CrearServicioHospedaje(dias, (double)numPrecioDia.Value);
                        break;

                    case 1: // Limpieza
                        servicio = gestor.CrearServicioLimpieza(chkIncluyeCorte.Checked, (double)numPrecioBaseLimpieza.Value);
                        break;

                    case 2: // Paseo
                        int horas = (int)numHoras.Value;
                        if (horas == 0)
                        {
                            MessageBox.Show("Las horas de paseo deben ser mayores a 0.", "Validación",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        servicio = gestor.CrearServicioPaseo(horas, chkEsGrupal.Checked, (double)numPrecioHora.Value);
                        break;

                    default:
                        MessageBox.Show("Por favor, seleccione un tipo de servicio válido.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                if (servicio != null)
                {
                    gestor.AgregarServicioAReserva(indiceReserva, servicio);
                    MessageBox.Show($"Servicio {servicio.NombreServicio} agregado exitosamente.\nCosto: ${servicio.CalcularCosto():F2}",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ActualizarListaServiciosDeReserva();
                    ActualizarListaReservas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar servicio: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstServicios.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione un servicio para eliminar.", "Selección requerida",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar si la lista realmente contiene servicios
                if (lstServicios.Items.Count == 1 &&
                    lstServicios.Items[0].ToString() == "(Sin servicios registrados)")
                {
                    MessageBox.Show("No hay servicios para eliminar.",
                        "Sin servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var resultado = MessageBox.Show("¿Está seguro de que desea eliminar este servicio?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    int indiceReserva = cmbReservasServicios.SelectedIndex;
                    int indiceServicio = lstServicios.SelectedIndex;

                    bool eliminado = gestor.EliminarServicioEnReserva(indiceReserva, indiceServicio);

                    if (eliminado)
                    {
                        MessageBox.Show("Servicio eliminado exitosamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ActualizarListaServiciosDeReserva();
                        ActualizarListaReservas();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el servicio. Por favor, intente nuevamente.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar servicio: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Eventos del Formulario

        private void FormReservasServicios_Load(object sender, EventArgs e)
        {
            // Inicializar controles básicos
            dtpFechaIngreso.Value = DateTime.Today;

            // Establecer visibilidad de paneles directamente ANTES de asignar SelectedIndex
            // Esto evita el NullReferenceException al cargar
            panelHospedaje.Visible = true;
            panelLimpieza.Visible = false;
            panelPaseo.Visible = false;

            // Ahora sí establecer el índice seleccionado
            cmbTipoServicio.SelectedIndex = 0;

            // Cargar datos iniciales
            CargarClientesEnComboBox();
            ActualizarListaReservas();
            CargarReservasEnComboBox();
        }

        private void CargarClientesEnComboBox()
        {
            var clientes = gestor.ObtenerTodosLosClientes();

            var clientesItemsCopy = clientes.Select(c => new ClienteComboItem
            {
                Id = c.IdCliente,
                Nombre = c.Nombre
            }).ToList();

            cmbClientesReservas.DataSource = null;
            cmbClientesReservas.DataSource = clientesItemsCopy;
            cmbClientesReservas.DisplayMember = "ToString";
        }

        private void btnVolverClientes_Click(object sender, EventArgs e)
        {
            FormClientesMascotas formClientes = new FormClientesMascotas(gestor);
            formClientes.Show();
            this.Hide();
        }

        private void FormReservasServicios_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cerrar la aplicación completamente si se cierra este formulario
            Application.Exit();
        }

        #endregion
    }
}