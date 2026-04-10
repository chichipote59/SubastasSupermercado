using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubastasSupermercado
{
    public abstract class Usuario
    {
        public string Nombre { get; set; }

        public abstract void RealizarOferta(Subasta subasta, double monto);
    }
}
