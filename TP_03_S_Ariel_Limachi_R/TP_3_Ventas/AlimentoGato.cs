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

        public override Producto GetProducto(int cuantos)
        {
            return this - cuantos;
        }
        public override Producto Reservar(int cuantos)
        {
            AlimentoGato nuevo = (AlimentoGato)this.Clone();
            nuevo.cantDisponible = cuantos;
            this.cantDisponible = this.cantDisponible - cuantos;
            return nuevo;
        }
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
