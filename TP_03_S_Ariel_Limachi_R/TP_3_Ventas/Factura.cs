using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ExepcionesPropias;

namespace TP_3_Ventas
{
    public class Factura
    {
        protected int nro;
        protected string nroIdentificacionFiscal;
        protected List<Producto> listaDeCompras;
        protected Persona vendedor;
        protected DateTime fEmision;
        protected double total;
        protected Persona comprador;
        public Factura()
        {
            this.listaDeCompras = new List<Producto>();
            this.nro = GenerarId();
            this.fEmision = DateTime.Now;

        }
        public Factura(string nif, List<Producto> listCompras, Persona vendedor, Persona comprador):this()
        {
            this.NumeroDeIdentificacionFiscal = nif;
            this.DetalleDeCompra = listCompras;
            this.Vendedor = vendedor;
            this.Cliente = comprador;
            this.Total = 0;
        }
        public Factura(string nif, List<Producto> listCompras, Persona vendedor, Persona comprador, DateTime f):this(nif,listCompras,vendedor,comprador)
        {
            this.fEmision = f;
        }

        /// <summary>
        /// genera un id lo retorna y guarda en un arhivo
        /// </summary>
        /// <returns>Retorna un id</returns>
        private int GenerarId()
        {
            int id = 1;
            int aux;
            if (File.Exists("id.txt"))
            {
                if (int.TryParse(File.ReadAllText("id.txt"), out aux))
                {
                    id += aux;
                    try
                    {
                        using (StreamWriter writer = new StreamWriter("id.txt"))
                        {
                            writer.Write(id.ToString());
                        }
                    }
                    catch( Exception)
                    {
                        throw;
                    }
                    
                }
            }
            else{
                try
                {
                    using(StreamWriter writer= new StreamWriter("id.txt"))
                    {
                        writer.Write(id.ToString());
                    }
                }
                catch(Exception)
                {
                    throw;
                }
            }
            return id;
        }

        /// <summary>
        /// Calcula el total de un Factura sumando todos los importes de los productos
        /// </summary>
        public void CalcularTotalFacturado()
        {
            double total = 0;
            foreach (Producto aux in this.listaDeCompras)
            {
                total = total + (aux.Precio * aux.CantUnidades);
            }
            this.total = total;
        }

        /// <summary>
        /// calculta el total de cada una de las facturas de una lista de facturas
        /// </summary>
        /// <param name="lista"> es la lista de facturas a la cual se le calcularan sus totales</param>
        public static void CalcularTodoslosTotalesDeRegisto(List<Factura> lista)
        {
            foreach(Factura aux in lista)
            {
                aux.CalcularTotalFacturado();
            }
        }

        /// <summary>
        /// mostra todos los datos de una factura
        /// </summary>
        /// <returns>retorna una cadena con la informacion de una factura</returns>
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Cliente:{0}\n\t\t\tLista de Productos\n", this.comprador.Mostrar());
            foreach (Producto aux in this.listaDeCompras)
            {
                sb.AppendFormat("\t\t\t\t{0}", aux.ToString());
            }
            return sb.ToString();
        }

        public int NroFactura { get { return this.nro; } set { this.nro = value; } }
        public string NumeroDeIdentificacionFiscal { get { return this.nroIdentificacionFiscal; }set { this.nroIdentificacionFiscal = value; } }
        public double Total { get { return this.total; } set { this.total = value; } }
        public DateTime FechaDeEmision { get { return this.fEmision; } set { this.fEmision = value; } }
        public Persona Cliente { get { return this.comprador; } set { this.comprador = value; } }
        public Persona Vendedor { get { return this.vendedor; } set { this.vendedor = value; } }
        public List<Producto> DetalleDeCompra { 
            get { return this.listaDeCompras; }
            set { 
                if (value.Count>0) {
                    this.listaDeCompras = value;
                }
                else
                {
                    throw new DetalleDeCompraVacioException();
                }
            }
        }

        /// <summary>
        /// comprueba que en una factura, el cliente sea de cierta localidad
        /// </summary>
        /// <param name="localidad">es la localidad de la que se supone es el cliente</param>
        /// <returns>true si el cliente de la factura es de esa localidad false en caso contrario</returns>
        public bool elCompradorEsDe(string localidad)
        {
            bool r = false;
            if (localidad == this.Cliente.Localidad)
            {
                r = true;
            }
            return r;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
