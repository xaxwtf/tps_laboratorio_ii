using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_3_Ventas
{
    public interface Iimpuesto
    {
        double AplicarImpuestoYdevolverValor(double porcentaje);
    }
}
