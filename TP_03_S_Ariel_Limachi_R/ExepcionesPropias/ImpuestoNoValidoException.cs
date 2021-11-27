using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExepcionesPropias
{
    public class ImpuestoNoValidoException:Exception
    {
        public ImpuestoNoValidoException():base()
        {

        }
        public ImpuestoNoValidoException(string mensaje):base(mensaje)
        {

        }
    }
}
