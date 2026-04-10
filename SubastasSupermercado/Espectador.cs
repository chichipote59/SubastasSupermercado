using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubastasSupermercado
{
    public class Espectador : Usuario
    {
        public override void RealizarOferta(Subasta subasta, double monto)
        {
            MessageBox.Show("Los espectadores no pueden ofertar");
        }
    }
}
