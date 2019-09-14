using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cap9_10_12.Capitulo_9;
using Cap9_10_12.Capitulo_10;

namespace Cap9_10_12
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EstructuraProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form estruct = new Estructuraproducto();
            estruct.Show();
        }

        private void EstructuraEnlazadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form estruct = new PersonaMascota();
            estruct.Show();
        }

        private void EnumeracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ENUM = new Numeracion();
            ENUM.Show();
        }

        private void PolicogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form pol = new Poligono();
            pol.Show();
        }
    }
}
