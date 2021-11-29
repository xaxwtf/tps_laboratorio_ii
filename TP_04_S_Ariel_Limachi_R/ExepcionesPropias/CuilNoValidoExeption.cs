using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExepcionesPropias
{
    public class CuilNoValidoExeption: Exception
    {
        public CuilNoValidoExeption() : base()
        {

        }
        public CuilNoValidoExeption(string mensaje) : base(mensaje)
        {

        }
    }
}
