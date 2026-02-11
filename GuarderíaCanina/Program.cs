using System;
using System.Windows.Forms;

namespace GuarderíaCanina
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Crear instancia compartida del gestor
            GestorReservas gestor = new GestorReservas();

            // Iniciar con el formulario de Clientes y Mascotas
            Application.Run(new FormClientesMascotas(gestor));
        }
    }
}