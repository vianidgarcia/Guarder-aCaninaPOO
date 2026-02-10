using System;

namespace GuarderíaCanina
{
    public class Hospedaje : Servicio
    {
        private int cantDias;
        public int CantDias
        {
            get { return cantDias; }
            set
            {
                if (value > 0)
                {
                    cantDias = value;
                }
                else
                {
                    throw new ArgumentException("La cantidad de días debe ser mayor a cero.");
                }
            }
        }

        public Hospedaje(double precioBase, int cantDias)
            : base(precioBase)
        {
            this.cantDias = cantDias;
        }

        public override double CalcularCosto()
        {
            return CantDias * PrecioBase;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nDías de Hospedaje: {CantDias}";
        }
    }
}