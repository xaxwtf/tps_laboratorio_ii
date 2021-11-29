using System;

namespace ExepcionesPropias
{
    public class ExtencionNoValidaExepcion:Exception
    {
        public ExtencionNoValidaExepcion(string descripcion): base(descripcion)
        {
        }
    }
}
