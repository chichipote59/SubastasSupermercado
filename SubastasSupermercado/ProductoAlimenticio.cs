using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubastasSupermercado
{
    public class ProductoAlimenticio : Producto
    {
        public bool CercaCaducidad { get; set; }

        public override double CalcularPrecioFinal()
        {
            if (CercaCaducidad)
                return PrecioInicial * 0.85;

            return PrecioInicial;
        }
    }
}
