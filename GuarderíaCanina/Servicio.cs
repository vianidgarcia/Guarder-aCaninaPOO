using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuarderíaCanina
{
    public abstract class Servicio
    {
        protected string nombreServicio;
        protected double PrecioBase { get; set; }

        public string NombreServicio
        {
            get { return nombreServicio; }
            private set { nombreServicio = value; }
        }

        public Servicio(double precioBase)
        {
            this.nombreServicio = GetType().Name;
            PrecioBase = precioBase;
        }

        public abstract double CalcularCosto();

        public override string ToString()
        {
            return $"{NombreServicio} - Precio Base: ${PrecioBase:F2}";
        }
    }
}