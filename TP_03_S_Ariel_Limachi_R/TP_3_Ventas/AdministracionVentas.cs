using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_3_Ventas
{
    public  class AdministracionVentas
    {
        public  List<Factura> facturacion;
        private string archivoCargado;
        public AdministracionVentas()
        {
            facturacion = new List<Factura>();
        }
        public bool CargarRegistros(string path)
        {
            bool r = false;
            try
            {
                facturacion = Archivos.Leer<List<Factura>>(path);
                if (facturacion != null)
                {
                    r = true;
                    this.archivoCargado = path;
                }
            }
            catch(Exception )
            {
                throw;
            }
            
            
            return r;
        }

        /// <summary>
        /// Recibe una Lista de Facturas y retorna El Promedio 
        /// </summary>
        /// <param name="lista">es la lista de facturas que recibe</param> 
        /// <returns>Retorna el promedio de los totales de las facturas</returns>
        public static double CalcularPromedioDeVentas(List<Factura> lista)
        {
            double total=0;
            foreach(Factura aux in lista)
            {
                total = total + aux.Total;
            }
            return total/lista.Count;
        }

        /// <summary>
        /// Genera un Informe de Ventas de cada una de las Localidades existentes
        /// </summary>
        /// <returns>retorna un string con el informe</returns>
        public string InformeLocalidadVentas()
        {
            StringBuilder sb = new StringBuilder();
            List<string> localidades = this.ObtenerTodasLasLocalidades();
            int nro = 0;
            foreach( string loc in localidades)
            {
                nro++;
                sb.AppendFormat("{0}\t{1}",nro,this.ObtenerInformeDeCiertaLocalidad(loc));
            }
            return sb.ToString();
        }

        /// <summary>
        /// Genera un Informe de Numero de Ventas por cada Vendedor existente
        /// </summary>
        /// <returns>retorna un string con el informe de datos</returns>
        public string InformeVentasAllVendedores()
        {
            StringBuilder sb = new StringBuilder();
            List<Persona> Vendedores = obentenerTodosLosVendedores();
            foreach(Persona aux in Vendedores)
            { 
                sb.AppendFormat("\n =>\tEmpleado: {0:40}  Cant Ventas Realizadas: {1}", aux.Mostrar(), this.VentasXEmpleado(aux));
            }
            
            return sb.ToString();
        }

        /// <summary>
        /// Filtra las las Localidades Existentes en una Lista y las Retorna
        /// </summary>
        /// <returns>retorna el una lista con cada una de las localidades existentes</returns>
        private List<string> ObtenerTodasLasLocalidades()
        {
            List<string> listaLocalidades= new List<string>();
            foreach(Factura aux in this.facturacion)
            {
                if (LocalidadNoRegistrada(listaLocalidades, aux.Cliente.Localidad))
                {
                    listaLocalidades.Add(aux.Cliente.Localidad);
                }
            }
            return listaLocalidades;
        }
        /// <summary>
        /// Valida si la Localidad existe en la Lista
        /// </summary>
        /// <param name="listaLocalidades">es la lista de referencia donde se buscara la localidad</param> 
        /// <param name="localidadEncontrada"> Es la localidad que se buscara en la lista</param>
        /// <returns> true si no esta agregada y false en caso contrario</returns>
        private static bool LocalidadNoRegistrada(List<string> listaLocalidades, string localidadEncontrada)
        {
            bool r = true;
            foreach(string aux in listaLocalidades)
            {
                if(aux == localidadEncontrada)
                {
                    r = false;
                }
            }
            return r;
        }

        /// <summary>
        /// Obtiene una Lista con todos Los vendedores existentes en una lista(no repetidos)
        /// </summary>
        /// <returns>retorna una lista de vendedores </returns>
        private List<Persona> obentenerTodosLosVendedores()
        {
            List<Persona> listaVendedores = new List<Persona>();
            foreach (Factura aux in this.facturacion)
            {
                if (vendedorNoRegistrado(listaVendedores, aux.Vendedor))
                {
                    listaVendedores.Add(aux.Vendedor);
                }
            }
            return listaVendedores;
        }

        /// <summary>
        /// Valida si un vendedor No existe en la lista
        /// </summary>
        /// <param name="lista"></param> es la lista donde se buscara que no exista el vendedor 
        /// <param name="vendedor">es el vendedor que se buscara</param> 
        /// <returns>true si no existe en la lista false si existe</returns>
        private static bool vendedorNoRegistrado(List<Persona> lista, Persona vendedor)
        {
            bool r = true;
            foreach (Persona aux in lista)
            {
                if (aux == vendedor)
                {
                    r = false;
                }
            }
            return r;
        }

        /// <summary>
        /// Genera un Informe de Cierta Localidad 
        /// </summary>
        /// <param name="localidad">es la localidad de la cual se buscara el informe</param>
        /// <returns>retorna un strign con el informe</returns>
        private string ObtenerInformeDeCiertaLocalidad(string localidad)
        {
            double totalFacturado = 0;
            double promedio = 0;
            StringBuilder sb = new StringBuilder();
            List<Factura> facturacionDeXlocalidad= this.FiltarFacturasDeCiertaLocalidad(localidad);
            totalFacturado = AdministracionVentas.CalcularTotalRegistro(facturacionDeXlocalidad);
            promedio = totalFacturado / (double)facturacionDeXlocalidad.Count;
            sb.AppendFormat("\t{0}  TotalFacturado: {1}  NroVentas:{2}  Promedio de Ventas: {3}\n", localidad, totalFacturado, facturacionDeXlocalidad.Count, promedio);
            foreach(Factura aux in facturacionDeXlocalidad)
            {
                sb.AppendFormat("\t\t {0}", aux.ToString());
            }
            return sb.ToString();
        }

        /// <summary>
        ///  Recibe una lista y suma todos los Totales para obtener el total del Registro
        /// </summary>
        /// <param name="lista">Es la lista de la cual se sumaran los totales de cada factura</param> 
        /// <returns></returns>
        public static double CalcularTotalRegistro(List<Factura> lista)
        {
            double r = 0;
            foreach(Factura aux in lista)
            {
                r = r + aux.Total;
            }
            return r;
        }

        /// <summary>
        /// Filtra todas las Facturas de una una misma Localidad
        /// </summary>
        /// <param name="localidad"> es la Localidad que buscara </param>
        /// <returns>retorna una lista con todas las facturas de una misma localidad</returns>
        private List<Factura> FiltarFacturasDeCiertaLocalidad(string localidad)
        {
            List<Factura> nuevaListaFiltrada = new List<Factura>();
            foreach(Factura aux in facturacion)
            {
                if (aux.Cliente.Localidad == localidad)
                {
                    nuevaListaFiltrada.Add(aux);
                }
            }
            return nuevaListaFiltrada;
        }

        /// <summary>
        /// Busca y retorna todas las Facturas que tienen el Mismo Vendedor
        /// </summary>
        /// <param name="empleado"> es el vendedor que se buscara en las facturas</param>
        /// <returns>una lista de facturas con todas las facturas de un mismo vendedor</returns>
        private int VentasXEmpleado(Persona empleado)
        {
            int r = 0;
            foreach(Factura aux in this.facturacion)
            {
                if (aux.Vendedor == empleado)
                {
                    r++;
                }
            }
            return r;
        }

        /// <summary>
        /// Obtiene la cantidad de Productos Vendidos en una lista, mediante la descripcion del producto
        /// </summary>
        /// <param name="lista">es la lista donde buscara los productos con dicha descripcion</param>
        /// <param name="description">es la descripcion por la cual buscara los productos</param>
        /// <returns>la cantidad de productos con la misma descripcion en la lista</returns>
        private static int CantidadVendidaxTipoProducto(List<Factura> lista, string description)
        {
            int unidadesVendidas = 0;
            foreach(Factura aux in lista)
            {

                foreach(Producto P in aux.DetalleDeCompra)
                {
                    if (P.Descripcion == description)
                    {
                        unidadesVendidas += P.CantUnidades;
                    }
                }

            }
            return unidadesVendidas;
        }

        /// <summary>
        /// Genera un informe  la cantidad de Productos vendidos de cada producto
        /// </summary>
        /// <returns>un string con el informe</returns>
        public string InformeProductosVendidos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nAlimento Balanceado para Gatos   Nro de Unidades Vendidas: {0}", CantidadVendidaxTipoProducto(this.facturacion, "Alimento Balanceado para Gatos"));
            sb.AppendFormat("\nAlimento Balanceado para Perro   Nro de Unidades Vendidas: {0}", CantidadVendidaxTipoProducto(this.facturacion, "Alimento Balanceado para Perros"));

            return sb.ToString();
        }

        /// <summary>
        /// Genera un Informe de ventas mes x mes
        /// </summary>
        /// <returns>un string con el informe de ventas </returns>
        public string InformeNroVentasXmes()
        {
            List<Factura> ventasMes=null;
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 12; i++)
            {
                ventasMes = ObtenerVentasDeCiertoMes(facturacion, i);
                if (ventasMes.Count>0)
                {
                    sb.AppendFormat("\nMes: {0}  NroVentas:{1}", ventasMes[0].FechaDeEmision.ToString("MMMM/yyyy"), ventasMes.Count);
                }
            }            
            return sb.ToString();
        }

        /// <summary>
        /// crea un lista de facturas con todas las facturas de un determinado mes
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="mes"></param>
        /// <returns>un lista de facturas del mismo mes</returns>
        public  static List<Factura> ObtenerVentasDeCiertoMes(List<Factura> lista, int mes)
        {
            List<Factura> nuevo=null;
            if (mes > 0 && mes<13)
            {
                nuevo = new List<Factura>();
                nuevo = lista.FindAll(factura => factura.FechaDeEmision.Month == mes);
            }
            
            return nuevo;
        }

        /// <summary>
        /// Crea un Informe con la cantidad De Productos vendidos por cada tipo en un mes determinado
        /// </summary>
        /// <param name="mes">es el mes del cual se creara el informe</param>
        /// <returns>retorna un informe del mes determinado</returns>
        public string CantidadProductosVendidosEnDeterminadoMes(int mes)
        {
            StringBuilder sb = new StringBuilder();
            List<Factura> ventasMes;
                ventasMes = ObtenerVentasDeCiertoMes(facturacion, mes);
                if (ventasMes.Count > 0)
                {
                    sb.AppendFormat("\nMes: {0}  NroTotal de Ventas:{1}",mes, ventasMes.Count);
                    sb.AppendFormat("\nAlimento Balanceado para Gatos   Nro de Unidades Vendidas: {0}", CantidadVendidaxTipoProducto(ventasMes, "Alimento Balanceado para Gatos"));
                    sb.AppendFormat("\nAlimento Balanceado para Perro   Nro de Unidades Vendidas: {0}", CantidadVendidaxTipoProducto(ventasMes, "Alimento Balanceado para Perros"));

                }
                else
                {
                    sb.AppendFormat("\nMes: {0}  NroTotal de Ventas:{1}", mes, ventasMes.Count);
                    sb.AppendFormat("\n No hay Ventas Realizadas este Mes");
                }
            return sb.ToString();
        }


        /// <summary>
        /// Genera un Informe de cada uno de los meses, los tipos de productos y la cantidad de ventas de cada uno
        /// </summary>
        /// <returns>un string con el informe de cada uno de los meses</returns>
        public string InformeProductosVendidosxMeses()
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 1; i < 13; i++)
            {
                sb.AppendFormat(CantidadProductosVendidosEnDeterminadoMes(i));
            }
            return sb.ToString();
        }
        public bool SaveRegistro(string path)
        {
            this.archivoCargado = path;
            return Archivos.Save<List<Factura>>(path, this.facturacion);
        }
        public bool ActualizarRegistro()
        {
            return Archivos.Save<List<Factura>>(this.archivoCargado, this.facturacion);
        }
    }
}
