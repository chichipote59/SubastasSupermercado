using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubastasSupermercado
{
    public class SubastaDescendente : SubastaStrategy
    {
        public void ProcesarOferta(Subasta subasta, Usuario usuario, double monto)
        {
            // El primero que acepte gana
            subasta.Ganador = usuario;
            subasta.OfertaActual = monto;
            subasta.Activa = false;

            MessageBox.Show("Subasta cerrada, ganador: " + usuario.Nombre);
        }
    }
}
