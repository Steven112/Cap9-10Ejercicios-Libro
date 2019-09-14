using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap9_10_12.Capitulo_9
{
    public partial class Estructuraproducto : Form
    {
        public Estructuraproducto()
        {
            InitializeComponent();
        }
        public struct ProductoTienda
        {
            public int CodigoDeBarras;
            public string NombreProducto;
            public int PrecioProducto;

            public ProductoTienda(int nCodigoDeBarras, string nNombreProducto, int nPrecioProducto)
            {
                CodigoDeBarras = nCodigoDeBarras;
                NombreProducto = nNombreProducto;
                PrecioProducto = nPrecioProducto;
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            ProductoTienda[] producto = new ProductoTienda[5];

            producto[1].CodigoDeBarras = Convert.ToInt32(CodigotextBox.Text);
            producto[1].NombreProducto = NombretextBox.Text;
            producto[1].PrecioProducto = Convert.ToInt32(PreciotextBox.Text);
            if (producto != null)
            {
                MessageBox.Show("Guardado");

            }
            else
            {
                MessageBox.Show("No Guardado");
            }
        }
    }
}
