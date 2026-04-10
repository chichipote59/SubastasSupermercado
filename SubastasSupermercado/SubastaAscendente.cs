using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubastasSupermercado
{
    public class SubastaAscendente : SubastaStrategy
    {
        public void ProcesarOferta(Subasta subasta, Usuario usuario, double monto)
        {
            if (monto > subasta.OfertaActual)
            {
                subasta.OfertaActual = monto;
                subasta.Ganador = usuario;
            }
        }
    }
}
