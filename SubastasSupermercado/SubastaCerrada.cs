using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubastasSupermercado
{
    public class SubastaCerrada : SubastaStrategy
    {
        public void ProcesarOferta(Subasta subasta, Usuario usuario, double monto)
        {
            subasta.Ofertas.Add(monto);
            subasta.Usuarios.Add(usuario);

            MessageBox.Show("Oferta registrada");
        }
    }
}
