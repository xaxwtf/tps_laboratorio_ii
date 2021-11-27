using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_3_Ventas
{
    public abstract class Alimento : Producto
    {
        protected ETipo tipo;
        protected double kilos;
        public Alimento():this(" ",0," ",0,ETipo.adulto,0)
        {

        }
        public Alimento(string descripcion, double precio, string marca, int cantDisponible, ETipo tipo, double kg) : base(descripcion, precio, marca, cantDisponible)
        {
            this.tipo = tipo;
            this.kilos = kg;
        }
        public ETipo Tipo { get { return this.tipo; } set { this.tipo = value; } }
        public double Peso { get { return this.kilos; } set { this.kilos = value; } }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            switch (this.tipo)
            {
                case ETipo.adulto:
                    sb.Append("\tTipo: Adultos  ");
                    break;
                case ETipo.cachorro:
                    sb.Append("\tTipo: Cachorro ");
                    break;
            }
            sb.AppendFormat("\tPeso: {0}Kg\n", this.kilos);
            return sb.ToString();
        }

    }
    public enum ETipo { adulto, cachorro }
}
