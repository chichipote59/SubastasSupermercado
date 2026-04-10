using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubastasSupermercado
{
    public partial class Form1 : Form
    {
        Subasta subasta;
        Comprador comprador;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            comprador = new Comprador() { Nombre = "Santiago" };

            
            ProductoFactory fabrica = new FabricaElectronico();
            Producto producto = fabrica.CrearProducto();
            {
                producto.Nombre = "Televisor";
                producto.PrecioInicial = 1000;
            }
            ;

            
            subasta = new Subasta(new SubastaCerrada())
            {
                Producto = producto,
                OfertaActual = producto.PrecioInicial
            };

            lblProducto.Text = producto.Nombre;
            lblPrecio.Text = producto.PrecioInicial.ToString();
        }

        private void btnOfertar_Click(object sender, EventArgs e)
        {
            try
            {
                double monto = Convert.ToDouble(txtOferta.Text);

                if (!subasta.Activa)
                {
                    MessageBox.Show("La subasta ya está cerrada");
                    return;
                }

                if (monto <= 0)
                {
                    MessageBox.Show("Ingrese un valor válido");
                    return;
                }

                comprador.RealizarOferta(subasta, monto);

                lblPrecio.Text = subasta.OfertaActual.ToString();

            }
            catch
            {
                MessageBox.Show("Ingrese un número válido");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            subasta.Cerrar();
            lblPrecio.Text = subasta.OfertaActual.ToString();
        }
    }
}
