using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_3_Ventas
{
    public static class GeneradorRegistro
    {
        public static List<Factura> generarLista()
        {
            List<Factura> NuevoRegistro = new List<Factura>();
            #region Vendedores
                Persona vendedor1 = new Persona("Alice", "Ramos", "2222222222", "CABA");
                Persona vendedor2 = new Persona("Jonatan", "Trigo", "2522222252", "CABA");
                Persona vendedor3 = new Persona("Hernar", "Herrera", "2522232252", "Prov. Buenos Aires");


            #endregion

            #region Compradores
            Persona comprador1 = new Persona("jose", "farias", "1111111111", "CABA");
                Persona comprador2 = new Persona("agustin", "centurion", "33333333333", "Prov. Buenos Aires");
                Persona comprador3 = new Persona("Damian", "Gonzales", "1211111121", "CABA");
            #endregion

            #region ListaCompras1
                List<Producto> ordenCompra1 = new List<Producto>();
                AlimentoGato nP1 = new AlimentoGato(800, "Pro Plan", 1, ETipo.adulto, 10);
                ordenCompra1.Add(nP1);
                AlimentoGato nP2 = new AlimentoGato(300, "Cat chow", 2, ETipo.adulto, 10);
                ordenCompra1.Add(nP2);
                AlimentoGato nP3 = new AlimentoGato(200, "Wiscas", 1, ETipo.cachorro, 10);
                ordenCompra1.Add(nP3);
                AlimentoGato nP4 = new AlimentoGato(1500, "Pro Plan", 1, ETipo.adulto, 20);
                ordenCompra1.Add(nP4);
                AlimentoGato nP5 = new AlimentoGato(2000, "Pro Plan", 1, ETipo.cachorro, 20);
                ordenCompra1.Add(nP5);
            #endregion

            #region ListaCompras 2
                List<Producto> ordenCompra2 = new List<Producto>();
                AlimentoGato nP6 = new AlimentoGato(800, "Pro Plan", 1, ETipo.adulto, 10);
                ordenCompra2.Add(nP6);
                AlimentoGato nP7 = new AlimentoGato(300, "Cat chow", 2, ETipo.adulto, 10);
                ordenCompra2.Add(nP7);
                AlimentoGato nP8 = new AlimentoGato(200, "Wiscas", 1, ETipo.cachorro, 10);
                ordenCompra2.Add(nP8);
                AlimentoGato nP9 = new AlimentoGato(1500, "Pro Plan", 1, ETipo.adulto, 20);
                ordenCompra2.Add(nP9);
                AlimentoGato nP10 = new AlimentoGato(2000, "Pro Plan", 1, ETipo.cachorro, 20);
                ordenCompra2.Add(nP10);
            #endregion

            #region ListaCompras3
            List<Producto> ordenCompra3 = new List<Producto>();
            AlimentoGato producto11 = new AlimentoGato(800, "Pro Plan", 1, ETipo.adulto, 10);
            ordenCompra3.Add(producto11);
            AlimentoGato producto12 = new AlimentoGato(300, "Cat chow", 2, ETipo.adulto, 10);
            ordenCompra3.Add(producto12);
            AlimentoPerro producto13 = new AlimentoPerro(5000, "Pro Plan", 1, ETipo.cachorro, 10);
            ordenCompra3.Add(producto13);
            AlimentoPerro producto14 = new AlimentoPerro(6000, "Pedigree", 1, ETipo.adulto, 20);
            ordenCompra3.Add(producto14);
            AlimentoGato producto15 = new AlimentoGato(2000, "Pro Plan", 1, ETipo.cachorro, 20);
            ordenCompra3.Add(producto15);
            #endregion
            Factura nF1 = new Factura("20407331193",ordenCompra1,vendedor1, comprador2,DateTime.Parse("5 / 10 / 2020 8:30:52 AM"));
            NuevoRegistro.Add(nF1);
            Factura nF2 = new Factura("20407331193", ordenCompra1, vendedor1, comprador1,DateTime.Parse("5 / 10 / 2020 9:30:01 AM"));
            NuevoRegistro.Add(nF2);
            Factura nF3 = new Factura("20407331193", ordenCompra3, vendedor2, comprador3, DateTime.Parse("5 / 10 / 2020 12:00:01 AM"));
            NuevoRegistro.Add(nF3);
            Factura nF4 = new Factura("20407331193", ordenCompra2, vendedor2, comprador2, DateTime.Parse("6 / 10 / 2020 1:15:02 PM"));
            NuevoRegistro.Add(nF4);
            Factura nF5 = new Factura("20407331193", ordenCompra2, vendedor2, comprador2, DateTime.Parse("10 / 11 / 2020 9:30:01 AM"));
            NuevoRegistro.Add(nF5);
            Factura nF6 = new Factura("20407331193", ordenCompra1, vendedor3, comprador2, DateTime.Parse("11 / 11 / 2020 10:30:01 AM"));
            NuevoRegistro.Add(nF6);
            return NuevoRegistro;
        }
        /// <summary>
        /// es una lista de Productos Harcodeada
        /// </summary>
        /// <returns>dicha lista</returns>
        public static List<Producto> ListaHarcodeada1()
        {
            List<Producto> ordenCompra1 = new List<Producto>();
            AlimentoGato nP1 = new AlimentoGato(800, "Pro Plan", 1, ETipo.adulto, 10);
            ordenCompra1.Add(nP1);
            AlimentoGato nP2 = new AlimentoGato(300, "Cat chow", 2, ETipo.adulto, 10);
            ordenCompra1.Add(nP2);
            AlimentoGato nP3 = new AlimentoGato(200, "Wiscas", 1, ETipo.cachorro, 10);
            ordenCompra1.Add(nP3);
            AlimentoGato nP4 = new AlimentoGato(1500, "Pro Plan", 1, ETipo.adulto, 20);
            ordenCompra1.Add(nP4);
            AlimentoGato nP5 = new AlimentoGato(2000, "Pro Plan", 1, ETipo.cachorro, 20);
            ordenCompra1.Add(nP5);
            return ordenCompra1;
        }

        /// <summary>
        /// es una lista de Productos Harcodeada
        /// </summary>
        /// <returns>dicha lista</returns>
        public static List<Producto> ListaHarcodeada2()
        {
            List<Producto> ordenCompra2 = new List<Producto>();
            AlimentoGato nP6 = new AlimentoGato(800, "Pro Plan", 1, ETipo.adulto, 10);
            ordenCompra2.Add(nP6);
            AlimentoGato nP7 = new AlimentoGato(300, "Cat chow", 2, ETipo.adulto, 10);
            ordenCompra2.Add(nP7);
            AlimentoGato nP8 = new AlimentoGato(200, "Wiscas", 1, ETipo.cachorro, 10);
            ordenCompra2.Add(nP8);
            AlimentoGato nP9 = new AlimentoGato(1500, "Pro Plan", 1, ETipo.adulto, 20);
            ordenCompra2.Add(nP9);
            AlimentoGato nP10 = new AlimentoGato(2000, "Pro Plan", 1, ETipo.cachorro, 20);
            ordenCompra2.Add(nP10);
            return ordenCompra2;
        }

        /// <summary>
        /// es una lista de Productos Harcodeada
        /// </summary>
        /// <returns>dicha lista</returns>
        public static List<Producto> ListaHarcodeada3()
        {
            List<Producto> ordenCompra3 = new List<Producto>();
            AlimentoGato producto11 = new AlimentoGato(800, "Pro Plan", 1, ETipo.adulto, 10);
            ordenCompra3.Add(producto11);
            AlimentoGato producto12 = new AlimentoGato(300, "Cat chow", 2, ETipo.adulto, 10);
            ordenCompra3.Add(producto12);
            AlimentoPerro producto13 = new AlimentoPerro(5000, "Pro Plan", 1, ETipo.cachorro, 10);
            ordenCompra3.Add(producto13);
            AlimentoPerro producto14 = new AlimentoPerro(6000, "Pedigree", 1, ETipo.adulto, 20);
            ordenCompra3.Add(producto14);
            AlimentoGato producto15 = new AlimentoGato(2000, "Pro Plan", 1, ETipo.cachorro, 20);
            ordenCompra3.Add(producto15);
            return ordenCompra3;
        }

        /// <summary>
        /// harcodea informacion, crea una carpeta en el escritorio y un archivo
        /// </summary>
        /// <returns></returns>
        public static void HarcodearCarpetaEInfo()
        {
            List<Factura> RegistroVentasPetShop = GeneradorRegistro.generarLista();
            Factura.CalcularTodoslosTotalesDeRegisto(RegistroVentasPetShop);
            Archivos.Save<List<Factura>>("petshop.xml", RegistroVentasPetShop);
        }
    }
}
