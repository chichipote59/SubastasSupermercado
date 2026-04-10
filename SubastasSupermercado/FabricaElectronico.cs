using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubastasSupermercado
{
    public class FabricaElectronico : ProductoFactory
    {
        public override Producto CrearProducto()
        {
            return new ProductoElectronico();
        }
    }
}
