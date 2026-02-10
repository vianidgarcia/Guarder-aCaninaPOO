using System;

namespace GuarderíaCanina
{
    public class Paseo : Servicio
    {
        private int horasPaseo;
        public bool esGrupal;

        public bool EsGrupal
        {
            get { return esGrupal; }
            private set { esGrupal = value; }
        }

        public int HorasPaseo
        {
            get { return horasPaseo; }
            set
            {
                if (value > 0)
                {
                    horasPaseo = value;
                }
                else
                {
                    throw new ArgumentException("Las horas de paseo deben ser mayores a cero.");
                }
            }
        }

        public Paseo(double precioBase, int horasPaseo, bool esGrupal)
            : base(precioBase)
        {
            HorasPaseo = horasPaseo;
            EsGrupal = esGrupal;
        }

        public override double CalcularCosto()
        {
            if (EsGrupal)
            {
                return PrecioBase * HorasPaseo * 1.25;
            }
            else
            {
                return PrecioBase * HorasPaseo;
            }
        }

        public bool EstablecerGrupal(bool esGrupal)
        {
            EsGrupal = esGrupal;
            return EsGrupal;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nHoras de Paseo: {HorasPaseo} | Es Grupal: {(EsGrupal ? "Sí" : "No")}";
        }
    }
}