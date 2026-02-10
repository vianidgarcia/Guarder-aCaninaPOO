using System;

namespace GuarderíaCanina
{
    public class Mascota
    {
        private string nombre;
        private string raza;
        private DateTime fechaNacimiento;
        private string peso;

        public string Nombre
        {
            get => nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre de la mascota no puede estar vacío.");
                nombre = value.Trim();
            }
        }

        public string Raza
        {
            get => raza;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La raza de la mascota no puede estar vacía.");
                raza = value.Trim();
            }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public string Peso
        {
            get => peso;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El peso de la mascota no puede estar vacío.");
                peso = value.Trim();
            }
        }
        public int Edad
        {
            get
            {
                DateTime hoy = DateTime.Today;
                int age = hoy.Year - fechaNacimiento.Year;
                if (fechaNacimiento > hoy.AddYears(-age)) age--;
                return age;
            }
        }

        public Mascota()
        {
            this.nombre = "";
            this.raza = "";
            this.fechaNacimiento = DateTime.Now;
            this.peso = "";
        }
        public Mascota(string nombre, string raza, DateTime fechaNacimiento, string peso)
        {
            this.nombre = nombre;
            this.raza = raza;
            this.fechaNacimiento = fechaNacimiento;
            this.peso = peso;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Raza: {Raza}, Edad: {Edad} años, Peso: {Peso} kg";
        }
    }
}