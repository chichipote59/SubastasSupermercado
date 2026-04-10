using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubastasSupermercado
{
    public class ProductoElectronico : Producto
    {
        public override double CalcularPrecioFinal()
        {
            return PrecioInicial * 1.10;
        }
    }
}
