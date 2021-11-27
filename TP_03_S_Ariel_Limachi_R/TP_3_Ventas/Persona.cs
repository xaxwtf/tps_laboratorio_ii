using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExepcionesPropias;

namespace TP_3_Ventas
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected string cuil;
        protected string localidad;
        public Persona() : this("na", "na", " ", "CABA")
        {

        }

        public Persona(string nombre, string apellido, string cuil, string localidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cuil = cuil;
            this.localidad = localidad;
        }

        /// <summary>
        /// muestra toda la informacion de una persona
        /// </summary>
        /// <returns>un string con la informacion</returns>
        public string Mostrar() {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0,-14} {1,-14} Cuil:{2,-14} con localidad en:{3,-30}", this.apellido, this.nombre, this.cuil, this.localidad);
            return sb.ToString();
        }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }
        public string Localidad { get { return this.localidad; } set { this.localidad = value; } }
        public string Cuil { get { return this.cuil; }set { this.cuil = value; } }
        public static bool operator ==(Persona a, Persona b)
        {
            bool r = false;
            if (a.cuil == b.cuil)
            {
                r = true;
            }
            return r;
        }
        public static bool operator !=(Persona a, Persona b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Valida que el cuil Ingresado sea valido
        /// </summary>
        /// <param name="cuil">es el cuil que sera validado</param>
        /// <returns>true si es valido y false en caso contrario</returns>
        public static bool ValidarCuil(string cuil)
        {
            bool r = false;
            if (cuil.All(char.IsDigit))
            {
                r=true;
            }
            else
            {
                throw new CuilNoValidoExeption();
            }
            return r;
        }
    }
}
