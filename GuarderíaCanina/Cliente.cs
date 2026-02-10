using System;
using System.Collections.Generic;
using System.Linq;

namespace GuarderíaCanina
{
    public class Cliente
    {
        private string idCliente;
        private string nombre;
        public string telefono;
        public List<Mascota> listaMascotas;

        public string IdCliente
        {
            get => idCliente;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El ID del cliente no puede estar vacío.");
                idCliente = value.Trim();
            }
        }
        public string Nombre
        {
            get => nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre del cliente no puede estar vacío.");
                nombre = value.Trim();
            }
        }

        public string Telefono
        {
            get => telefono;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El teléfono del cliente no puede estar vacío.");
                telefono = value.Trim();
            }
        }

        public List<Mascota> ListaMascotas
        {
            get => listaMascotas;
            set
            {
                if (value == null)
                    throw new ArgumentNullException("La lista de mascotas no puede ser nula.");
                listaMascotas = value;
            }
        }

        public Cliente()
        {
            this.idCliente = "";
            this.nombre = "";
            this.telefono = "";
            ListaMascotas = new List<Mascota>();
        }

        public Cliente(string idCliente, string nombre, string telefono)
        {
            this.idCliente = idCliente;
            this.nombre = nombre;
            this.telefono = telefono;
            this.listaMascotas = new List<Mascota>();
        }

        public void AgregarMascota(Mascota m)
        {
            ListaMascotas.Add(m);
        }

        public void EliminarMascota(Mascota m)
        {
            ListaMascotas.Remove(m);
        }

        public override string ToString()
        {
            return $"ID: {IdCliente} | Nombre: {Nombre} | Teléfono: {Telefono} | Mascotas: {ListaMascotas.Count}";
        }
    }
}