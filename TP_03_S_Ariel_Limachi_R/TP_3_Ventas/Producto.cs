using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ExepcionesPropias;

namespace TP_3_Ventas
{
    [XmlInclude(typeof(AlimentoGato))]
    [XmlInclude(typeof(AlimentoPerro))]
    public abstract class Producto: Iimpuesto
    {
        protected string descripcion;
        protected double precio;
        protected string marca;
        protected int cantDisponible;
        public Producto()
        {
            this.descripcion = "";
            this.precio = 0;
            this.marca = "";
            this.cantDisponible = 0;
        }

        protected Producto(double precio, string marca, int cantDisponible) : this("", precio, marca, cantDisponible)
        {

        }
        protected Producto(string descripcion, double precio, string marca, int cantDisponible)
        {
            this.descripcion = descripcion;
            this.precio = precio;
            this.marca = marca;
            this.cantDisponible = cantDisponible;
        }


        /// <summary>
        /// muestra todos los datos del Producto
        /// </summary>
        /// <returns></returns> una cadena de texto con todos los datos del producto
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}  \t Marca:{1:14}\t   Precio Unitario:{2}  \tUnidades:{3}",this.Descripcion,this.Marca,this.precio,this.cantDisponible);
            return sb.ToString();
        }

        public virtual string Descripcion { get { return this.descripcion; } set { this.descripcion = value; } }
        public string Marca { get { return this.marca; } set { this.marca = value; } }
        public int CantUnidades{ get { return this.cantDisponible; } set { this.cantDisponible = value; } }
        public double Precio { get { return this.precio; } set { if (value > 0) { this.precio = value; } } }

        #region Interfaz Aplicada

        /// <summary>
        /// modifica el total de la factura aplicandole una tasa 
        /// </summary>
        /// <param name="porcentaje"> es la tasa por la cual se modificada el total</param>
        /// <returns>el valor por el cual se modificara el total</returns>
        public double AplicarImpuestoYdevolverValor(double porcentaje)
        {
            double valorImpuesto=0;
            if(porcentaje>0&& porcentaje <= 1)
            {
                valorImpuesto = this.precio * porcentaje;
                this.precio = this.precio + valorImpuesto;
            }
            else
            {
                throw new ImpuestoNoValidoException();
            }
            return valorImpuesto;
        }
        #endregion

        /// <summary>
        /// Obtiene una cantidad de Productos de un stock
        /// </summary>
        /// <param name="cuantos">indica la cantidad de unidades que obtendra del stock</param>
        /// <returns>un nuevo  producto </returns>
        public abstract Producto GetProducto(int cuantos);
        public static bool operator ==(Producto a, Producto b)
        {
            bool r = false;
            if (a.Descripcion == b.Descripcion && a.Marca == b.Marca)
            {
                r = true;
            }
            return r;
        }
        public static bool operator !=(Producto a, Producto b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Obtiene una determinado numero de producto de un stock
        /// </summary>
        /// <param name="cuantos">la cantidad de productos que obtendra</param>
        /// <returns>el producto obtenido del stock</returns>
        public abstract Producto Reservar(int cuantos);


        /// <summary>
        /// Agrega Productos a un stock de productos
        /// </summary>
        /// <param name="cuantos">Es la cantidad de Productos que se agregaran al stock</param>
        public void Agregar(int cuantos)
        {
            if (cuantos > 0)
            {
                this.cantDisponible -= cuantos;
            }
        }

        /// <summary>
        /// Realiza una copia del producto 
        /// </summary>
        /// <returns></returns>
        public abstract Producto Clone();
    }
}
