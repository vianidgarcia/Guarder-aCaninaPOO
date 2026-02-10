using System;
using System.Collections.Generic;
using System.Linq;

namespace GuarderíaCanina
{
    public class GestorReservas
    {
        private List<Cliente> clientes;
        private List<Reserva> reservas;

        public GestorReservas()
        {
            clientes = new List<Cliente>();
            reservas = new List<Reserva>();
        }

        #region Gestión de Clientes

        public void RegistrarCliente(string idCliente, string nombre, string telefono)
        {
            if (RevisarIdClientes(idCliente))
            {
                throw new InvalidOperationException($"El ID '{idCliente}' ya está registrado para otro cliente.");
            }

            Cliente nuevoCliente = new Cliente(idCliente, nombre, telefono);
            clientes.Add(nuevoCliente);
        }

        public bool RevisarIdClientes(string idCliente)
        {
            if (clientes.Any(c => c.IdCliente == idCliente))
            {
                return true;
            }
            return false;
        }

        public Cliente? BuscarCliente(string idCliente)
        {
            return clientes.FirstOrDefault(c => c.IdCliente == idCliente);
        }

        public List<Cliente> ObtenerTodosLosClientes()
        {
            return clientes;
        }

        public List<string> ObtenerIdsClientes()
        {
            return clientes.Select(c => c.IdCliente).ToList();
        }

        public List<string> ObtenerClientesResumidos()
        {
            return clientes.Select(c => $"{c.IdCliente} - {c.Nombre}").ToList();
        }

        #endregion

        #region Gestión de Mascotas

        public void RegistrarMascota(string idCliente, string nombre, string raza, DateTime fechaNacimiento, string peso)
        {
            Cliente? cliente = BuscarCliente(idCliente);

            if (cliente == null)
            {
                throw new InvalidOperationException("Cliente no encontrado.");
            }

            var nombreLimpio = (nombre ?? string.Empty).Trim();
            if (cliente.ListaMascotas.Any(m => string.Equals(m.Nombre.Trim(), nombreLimpio, StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException("El cliente ya tiene una mascota con ese nombre.");
            }

            Mascota nuevaMascota = new Mascota(nombreLimpio, raza, fechaNacimiento, peso);
            cliente.AgregarMascota(nuevaMascota);
        }

        public List<string> ObtenerNombresMascotas(string idCliente)
        {
            var cliente = BuscarCliente(idCliente);
            if (cliente == null) return new List<string>();
            return cliente.ListaMascotas.Select(m => m.Nombre).ToList();
        }

        public List<Mascota> ObtenerMascotasCliente(string idCliente)
        {
            var cliente = BuscarCliente(idCliente);
            if (cliente == null) return new List<Mascota>();
            return cliente.ListaMascotas;
        }

        #endregion

        #region Gestión de Reservas

        public void CrearReserva(string idCliente, string nombreMascota, DateTime fechaIngreso)
        {
            Cliente? cliente = BuscarCliente(idCliente);

            if (cliente == null)
            {
                throw new InvalidOperationException("Cliente no encontrado.");
            }

            Mascota? mascota = cliente.ListaMascotas.FirstOrDefault(m => m.Nombre == nombreMascota);

            if (mascota == null)
            {
                throw new InvalidOperationException("Mascota no encontrada para este cliente.");
            }

            Reserva nuevaReserva = new Reserva(cliente, mascota, new List<Servicio>(), fechaIngreso);
            reservas.Add(nuevaReserva);
        }

        public void AgregarServicioAReserva(int indiceReserva, Servicio servicio)
        {
            if (indiceReserva < 0 || indiceReserva >= reservas.Count)
            {
                throw new ArgumentOutOfRangeException("Reserva no encontrada.");
            }

            reservas[indiceReserva].AñadirServicio(servicio);
        }

        public List<string> ObtenerResumenReservas()
        {
            return reservas.Select((r, i) => $"{i + 1}. {r.ObtenerResumenBreve()}").ToList();
        }

        public List<Reserva> ObtenerTodasLasReservas()
        {
            return reservas;
        }

        public Reserva? ObtenerReservaPorIndice(int indice)
        {
            if (indice < 0 || indice >= reservas.Count) return null;
            return reservas[indice];
        }

        public List<string> ObtenerResumenServiciosEnReserva(int indiceReserva)
        {
            if (indiceReserva < 0 || indiceReserva >= reservas.Count) return new List<string>();
            return reservas[indiceReserva].ObtenerResumenServicios();
        }

        public bool EliminarServicioEnReserva(int indiceReserva, int indiceServicio)
        {
            if (indiceReserva < 0 || indiceReserva >= reservas.Count) return false;
            return reservas[indiceReserva].EliminarServicioPorIndice(indiceServicio);
        }

        public int ObtenerTotalReservas() => reservas.Count;

        #endregion

        #region Creación de Servicios

        public Hospedaje CrearServicioHospedaje(int cantDias, double precioPorDia = 100)
        {
            return new Hospedaje(precioPorDia, cantDias);
        }

        public Limpieza CrearServicioLimpieza(bool incluyeCorte = false, double precioBase = 50)
        {
            return new Limpieza(precioBase, incluyeCorte);
        }

        public Paseo CrearServicioPaseo(int duracionHoras, bool esGrupal = false, double precioPorHora = 30)
        {
            return new Paseo(precioPorHora, duracionHoras, esGrupal);
        }

        #endregion
    }
}