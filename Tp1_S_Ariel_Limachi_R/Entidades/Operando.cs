using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        public Operando(string strNum)
        {
            Numero = strNum;
        }
        public Operando(double num) : this(num.ToString())
        {

        }
        public Operando():this(0)
        {

        }
        
       
        /// <summary>
        /// valida que el string pasado sea un numero retorna 0 en casi de no serlo
        /// </summary>
        /// <param name="strNumero"></param> es el supuesto numero en formato string
        /// <returns></returns>
        public double ValidarOperando(string strNumero)
        {
            double r = 0;
            if(!double.TryParse(strNumero,out r))
            {
                r = 0;
            }
            return r;
        }

        /// <summary>
        /// permite cargar el atributo numero del objeto Operando
        /// </summary>
        public string Numero { 
            set { 
                this.numero = ValidarOperando(value); 
            } 
        } 

        /// <summary>
        /// retorna true, si el strin pasado es un binario, false en caso contrario
        /// </summary>
        /// <param name="strBinario"></param> es el string que se supone es un binario
        /// <returns></returns>
        private bool EsBinario(string strBinario)
        {
            bool r = true;
            foreach(Char aux in strBinario)
            {
                if (aux != '0' && aux != '1')
                {
                    r = false;
                    break;
                }
            }
            return r;
        }


        /// <summary>
        /// convierte el numero decimal en un numero binario
        /// </summary>
        /// <param name="numero"></param> es el numero decimal pasado en formato string
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {
            string r = "Valor Invalido";
            double num;
            int auxNum;
            long digito = 0;
            long reAux = 0;
                num = double.Parse(numero);
                auxNum = Convert.ToInt32(num);
                if (num >= 0)
                {

                    if (auxNum > num)
                    {
                        auxNum = auxNum - 1;
                    }
                    for (int i = auxNum % 2, j = 0; auxNum > 0; auxNum /= 2, i = auxNum % 2, j++)
                    {
                        digito = i % 2;
                        reAux += digito * (long)Math.Pow(10, j);
                    }
                    r = reAux.ToString();
                }
            return r;
        }

        /// <summary>
        /// convierte el numero decimal pasado(formato double) en un numero binario
        /// </summary>
        /// <param name="numero"></param> es el numero decimal pasado
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());
        }


        /// <summary>
        /// convierte un numero binario a formato decimal
        /// </summary>
        /// <param name="strBinario"></param> es  el numero binario 
        /// <returns></returns>
        public string BinarioDecimal(string strBinario)
        {
            double r = 0;
            string retorno = "Valor Invalido";
            int j = strBinario.Length-1;
            if (EsBinario(strBinario))
            {
                foreach (char aux in strBinario)
                {
                    if (aux == '1')
                    {
                        r = r + Math.Pow(2, j);
                    }
                    j--;
                }
                retorno = r.ToString();
            }
            return retorno;
        }

        public static double operator +(Operando n1 , Operando n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Operando n1, Operando n2)
        {
            double r = double.MinValue;
            if (n2.numero != 0)
            {
                r = n1.numero / n2.numero;
            }
            return r;
        }
    }
}
