using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubastasSupermercado
{
    public class Comprador : Usuario
    {
        public override void RealizarOferta(Subasta subasta, double monto)
        {
            subasta.RecibirOferta(this, monto);
        }
    }
}
