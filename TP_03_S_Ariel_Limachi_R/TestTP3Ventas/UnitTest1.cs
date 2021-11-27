using NUnit.Framework;
using TP_3_Ventas;

namespace TestTP3Ventas
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestIdFacturaEsIncremental()
        {
            Factura actual = new Factura();
            Factura nueva = new Factura();
            Assert.IsTrue(nueva.NroFactura > actual.NroFactura);
        }
    }
}