using System;
using System.Collections.Generic;
using System.Linq;

namespace GuarderíaCanina
{
    public class Reserva
    {
        private Cliente Cliente { get; set; }
        private Mascota Mascota { get; set; }
        private List<Servicio> Servicios { get; set; }
        private DateTime FechaIngreso { get; set; }

        public Reserva(Cliente cliente, Mascota mascota, List<Servicio> servicios, DateTime fechaIngreso)
        {
            Servicios = servicios ?? new List<Servicio>();
            Cliente = cliente;
            Mascota = mascota;
            FechaIngreso = fechaIngreso;
        }

        public void AñadirServicio(Servicio s)
        {
            Servicios.Add(s);
        }

        public void EliminarServicio(Servicio s)
        {
            Servicios.Remove(s);
        }

        public double CalcularCostoTotal()
        {
            double costoTotal = 0;
            foreach (var servicio in Servicios)
            {
                costoTotal += servicio.CalcularCosto();
            }
            return costoTotal;
        }

        public string ObtenerResumenCompleto()
        {
            var resultado = $"=== RESUMEN DE RESERVA ===\n";
            resultado += $"Fecha de Ingreso: {FechaIngreso:dd/MM/yyyy}\n";
            resultado += $"Cliente: {Cliente.Nombre} (Tel: {Cliente.Telefono})\n";
            resultado += $"Mascota: {Mascota.Nombre} - {Mascota.Raza}\n\n";
            resultado += $"Servicios contratados ({Servicios.Count}):\n";

            if (Servicios.Count == 0)
            {
                resultado += "  - Sin servicios agregados\n";
            }
            else
            {
                foreach (var servicio in Servicios)
                {
                    resultado += $"  - {servicio.NombreServicio}: ${servicio.CalcularCosto():F2}\n";
                }
            }

            resultado += $"\nCOSTO TOTAL: ${CalcularCostoTotal():F2}";
            return resultado;
        }

        public override string ToString() => $"{Cliente.Nombre} - {Mascota.Nombre} ({FechaIngreso:dd/MM/yyyy})";

        public string ObtenerResumenBreve() => ToString();

        public List<string> ObtenerResumenServicios()
        {
            return Servicios.Select((s, i) => $"{i + 1}. {s.NombreServicio} - ${s.CalcularCosto():F2}").ToList();
        }

        public bool EliminarServicioPorIndice(int indice)
        {
            if (indice < 0 || indice >= Servicios.Count) return false;
            Servicios.RemoveAt(indice);
            return true;
        }
    }
}
