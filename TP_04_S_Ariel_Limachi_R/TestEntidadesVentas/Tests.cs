using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP_3_Ventas;
using ExepcionesPropias;
using System.Collections.Generic;

namespace TestEntidadesVentas
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestGuardarEnArhivo()
        {
            Persona Guardada = new Persona("sergio", "ramos", "11101010101", "CABA");
            Archivos.Save<Persona>("testUnitario.xml", Guardada);
            Persona Recuperada = Archivos.Leer<Persona>("testUnitario.xml");
            Assert.IsTrue(Guardada == Recuperada);
        }

        [TestMethod]
        public void TestNumeroDeFacturaDiferenteEIncremental()
        {
            Factura actual = new Factura();
            Factura nuevo = new Factura();
            Assert.IsTrue(actual.NroFactura != nuevo.NroFactura && actual.NroFactura < nuevo.NroFactura);
        }
        [TestMethod]
        public void TestElDetalledeCompraEstaVacio()
        {
            bool r = false;
            try
            {

                List<Producto> DetalleComprasvacia = new List<Producto>();
                Persona algo = new Persona();
                Factura aux = new Factura("25252525", DetalleComprasvacia, algo, algo);
            }
            catch (DetalleDeCompraVacioException)
            {
                r = true;
            }
            finally
            {
                Assert.IsTrue(r);
            }
        }
        [TestMethod]
        public void ObteniendoInfoDeSql()
        {
            DB connexion = new DB("Server=DESKTOP-6B54B0U;Database=petShop;Trusted_Connection=True;");
            Persona recuperada=connexion.RetornarDataEmpleados();
            Assert.IsNotNull(recuperada);
            Assert.IsTrue(recuperada.Nombre == "Gabriel" && recuperada.Apellido == "Trigo" && recuperada.Cuil == "20353535352");
        }
    }
}
