using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubastasSupermercado
{
    public class Subasta
    {
        public Producto Producto { get; set; }
        public double OfertaActual { get; set; }
        public Usuario Ganador { get; set; }
        public bool Activa { get; set; } = true;

        private SubastaStrategy estrategia;

        public Subasta(SubastaStrategy estrategia)
        {
            this.estrategia = estrategia;
        }

        public void RecibirOferta(Usuario usuario, double monto)
        {
            if (!Activa)
            {
                MessageBox.Show("Subasta cerrada");
                return;
            }

            estrategia.ProcesarOferta(this, usuario, monto);
        }
    }
}
