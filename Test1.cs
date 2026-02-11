using DoggyCareProyect;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace DoggyCareTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestClass]
        public class GestorReservasTests
        {
            [TestMethod]
            public void RegistrarCliente_BuscarCliente_ObtenerClientesResumidos()
            {
                var gestor = new GestorReservas();

                gestor.RegistrarCliente("c1", "César", "600000000");

                var cliente = gestor.BuscarCliente("c1");
                Assert.IsNotNull(cliente);
                Assert.AreEqual("César", cliente!.GetNombre());

                var resumen = gestor.ObtenerClientesResumidos();
                CollectionAssert.Contains(resumen, "c1 - César");
            }

            [TestMethod]
            public void RegistrarMascota_CrearReserva_ResumenReservasContieneClienteYMascota()
            {
                var gestor = new GestorReservas();

                gestor.RegistrarCliente("c2", "Ana", "611111111");
                gestor.RegistrarMascota("c2", "Fido", "Labrador", 3, 12.5);
                gestor.CrearReserva("c2", "Fido", new DateTime(2026, 1, 1));

                Assert.AreEqual(1, gestor.ObtenerTotalReservas());

                var resumen = gestor.ObtenerResumenReservas().FirstOrDefault() ?? string.Empty;
                StringAssert.Contains(resumen, "Fido");
                StringAssert.Contains(resumen, "Ana");
            }

            [TestMethod]
            public void AgregarYEliminarServicios_VerificaCostesTotales()
            {
                var gestor = new GestorReservas();

                gestor.RegistrarCliente("c3", "Luis", "622222222");
                gestor.RegistrarMascota("c3", "Luna", "Beagle", 2, 8.0);
                gestor.CrearReserva("c3", "Luna", DateTime.Today);

                // Crear servicios con valores esperados:
                // hospedaje 2 días * 100 = 200
                // limpieza base 50 + extra 10 + corte 15 = 75
                // paseo 2 horas * 30 * 1.25 (grupal) = 75
                var hospedaje = gestor.CrearServicioHospedaje(2, 100);
                var limpieza = gestor.CrearServicioLimpieza(10, true, 50);
                var paseo = gestor.CrearServicioPaseo(2, true, 30);

                gestor.AgregarServicioAReserva(0, hospedaje);
                gestor.AgregarServicioAReserva(0, limpieza);
                gestor.AgregarServicioAReserva(0, paseo);

                var servicios = gestor.ObtenerResumenServiciosEnReserva(0);
                Assert.AreEqual(3, servicios.Count);

                double ParseAndSumCosts(IEnumerable<string> lines)
                {
                    double sum = 0;
                    foreach (var line in lines)
                    {
                        // Formato esperado: "N. Nombre - $123.45"
                        var parts = line.Split('-');
                        if (parts.Length < 2) continue;
                        var costText = parts.Last().Trim().TrimStart('$').Trim();
                        if (!double.TryParse(costText, NumberStyles.Any, CultureInfo.InvariantCulture, out var v)
                            && !double.TryParse(costText, NumberStyles.Any, CultureInfo.CurrentCulture, out v))
                        {
                            continue;
                        }

                        sum += v;
                    }
                    return sum;
                }

                var total = ParseAndSumCosts(servicios);
                Assert.AreEqual(350.0, total, 0.01);

                // Eliminar el servicio "limpieza" (índice 1) y comprobar nuevo total
                var eliminado = gestor.EliminarServicioEnReserva(0, 1);
                Assert.IsTrue(eliminado);

                var serviciosDespues = gestor.ObtenerResumenServiciosEnReserva(0);
                Assert.AreEqual(2, serviciosDespues.Count);

                var totalDespues = ParseAndSumCosts(serviciosDespues);
                Assert.AreEqual(275.0, totalDespues, 0.01);
            }
        }
    }
}

