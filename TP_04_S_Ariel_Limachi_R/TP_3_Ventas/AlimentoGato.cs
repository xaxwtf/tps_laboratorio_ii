using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_3_Ventas
{
    public class AlimentoGato : Alimento
    {
        public AlimentoGato():base()
        {

        }
        public AlimentoGato(double precio, string marca, int cantDisp, ETipo tipo, double kg) : base("Alimento Balanceado para Gatos", precio, marca, cantDisp, tipo, kg)
        {

        }

        protected override string Mostrar()
        {
            return base.Mostrar();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        /// <summary>
        /// obtiene un producto de un stock de productos(hace una copia del objeto con un determinado tamaño)
        /// </summary>
        /// <param name="cuantos">es la cantidad de unidades que tendra el producto</param>
        /// <returns>un objeto del tipo producto del tamaño indicado</returns>
        public override Producto GetProducto(int cuantos)
        {
            return this - cuantos;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cuantos"></param>
        /// <returns></returns>
        /// 
        public override Producto Clone()
        {
            return new AlimentoGato(this.precio, this.marca, this.cantDisponible, this.tipo, this.kilos);
        }
        public static AlimentoGato operator +(AlimentoGato a, AlimentoGato b)
        {
            if (a == b)
            {
                a.cantDisponible += b.cantDisponible;
            }
            return a;
        }
        public static AlimentoGato operator -(AlimentoGato a, AlimentoGato b)
        {
            if (a == b)
            {
                a.cantDisponible -= b.cantDisponible;
            }
            return a;
        }
        public static AlimentoGato operator -(AlimentoGato p, int cantidad)
        {
            AlimentoGato np = new(p.precio, p.marca, cantidad, p.tipo, p.kilos);
            if (np != null)
            {
                p.cantDisponible -= cantidad;
            }
            return np;
        }
 
    }
}
