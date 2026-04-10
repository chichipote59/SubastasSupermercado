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

        
        public List<double> Ofertas = new List<double>();
        public List<Usuario> Usuarios = new List<Usuario>();

        private SubastaStrategy estrategia;

        public Subasta(SubastaStrategy estrategia)
        {
            this.estrategia = estrategia;
        }

        public void RecibirOferta(Usuario usuario, double monto)
        {
            if (!Activa)
            {
                MessageBox.Show("La subasta ya está cerrada");
                return;
            }

            estrategia.ProcesarOferta(this, usuario, monto);
        }

        public void Cerrar()
        {
            Activa = false;

            
            if (Ofertas.Count > 0)
            {
                double mayor = Ofertas[0];
                int posicion = 0;

                for (int i = 1; i < Ofertas.Count; i++)
                {
                    if (Ofertas[i] > mayor)
                    {
                        mayor = Ofertas[i];
                        posicion = i;
                    }
                }

                Ganador = Usuarios[posicion];
                OfertaActual = mayor;
            }

            MessageBox.Show("Ganador: " + Ganador?.Nombre + " con $" + OfertaActual);
        }
    }
}
