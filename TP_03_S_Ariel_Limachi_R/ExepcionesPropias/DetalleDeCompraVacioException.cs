using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExepcionesPropias
{
    public class DetalleDeCompraVacioException : Exception
    {
        public DetalleDeCompraVacioException() : base("El Detalle del Producto esta Vacio")
        {

        }
        public DetalleDeCompraVacioException(string mensaje) : base(mensaje)
        {

        }
    }
}
