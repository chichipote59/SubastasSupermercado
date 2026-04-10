using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubastasSupermercado
{
    public interface SubastaStrategy
    {
        void ProcesarOferta(Subasta subasta, Usuario usuario, double monto);
    }
}
