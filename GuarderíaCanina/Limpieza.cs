using System;

namespace GuarderíaCanina
{
    public class Limpieza : Servicio
    {
        public bool IncluyeCorte { get; private set; }

        public Limpieza(double precioBase, bool incluyeCorte)
            : base(precioBase)
        {
            IncluyeCorte = incluyeCorte;
        }

        public void IncluyeCorteServicio()
        {
            IncluyeCorte = true;
        }

        public override double CalcularCosto()
        {
            double costo = PrecioBase;
            if (IncluyeCorte)
            {
                costo += 15;
            }
            return costo;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nIncluye Corte: {(IncluyeCorte ? "Sí" : "No")}";
        }
    }
}