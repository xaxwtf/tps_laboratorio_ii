﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_3_Ventas
{
    public class AlimentoPerro : Alimento
    {
        public AlimentoPerro():base()
        {

        }
        public AlimentoPerro(double precio, string marca, int cantDisp, ETipo tipo, double kg) : base("Alimento Balanceado para Perros", precio, marca, cantDisp, tipo, kg)
        {

        }
        /// <summary>
        /// muestra todos los datos de un Producto
        /// </summary>
        /// <returns>un string con la informacion</returns>
        protected override string Mostrar()
        {
            return base.Mostrar();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        public static AlimentoPerro operator -(AlimentoPerro p, int cantidad)
        {
            AlimentoPerro np = new(p.precio, p.marca, cantidad, p.tipo, p.kilos);
            if (np != null)
            {
                p.cantDisponible -= cantidad;
            }
            return np;
        }

        /// <summary>
        /// obtiene un producto de un stock de productos
        /// </summary>
        /// <param name="cuantos">es la cantidad de productos que obtendra</param>
        /// <returns>retorna una deteminada cantidad e productos</returns>
        public override Producto GetProducto(int cuantos)
        {
            return this - cuantos;
        }

        public override Producto Clone()
        {
            return new AlimentoPerro(this.precio, this.marca, this.cantDisponible, this.tipo, this.kilos);
        }
        public static AlimentoPerro operator +(AlimentoPerro a, AlimentoPerro b)
        {
            if (a == b)
            {
                a.cantDisponible += b.cantDisponible;
            }
            return a;
        }
        public static AlimentoPerro operator -(AlimentoPerro a, AlimentoPerro b)
        {
            if (a == b)
            {
                a.cantDisponible -= b.cantDisponible;
            }
            return a;
        }


    }
}
