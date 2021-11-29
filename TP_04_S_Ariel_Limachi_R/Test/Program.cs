using System;
using System.Collections.Generic;
using TP_3_Ventas;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneradorRegistro.HarcodearCarpetaEInfo();
            AdministracionVentas empresa1 = new AdministracionVentas();
            empresa1.CargarRegistros("petshop.xml");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(empresa1.InformeLocalidadVentas());
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(empresa1.InformeVentasAllVendedores());
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(empresa1.InformeProductosVendidos());
            Console.WriteLine("_______________________________________");
            Console.WriteLine(empresa1.InformeNroVentasXmes());
            Console.WriteLine("_______________________________________");
            Console.WriteLine(empresa1.InformeProductosVendidosxMeses());
        }
    }
}
