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
    public partial class Numeracion : Form
    {
        public Numeracion()
        {
            InitializeComponent();
        }
        public enum Neumaticos
        {
            NeumáticosAnchos,
            NeumáticosXL,
            NeumáticosBajo,
            NeumáticosUsados,
            NeumáticosRecauchutados,
            NeumáticosVerano,
            NeumáticosInvierno,
            NeumáticosTodoTiempo
        };

        
    



        private void Llenarbutton_Click(object sender, EventArgs e)
        {
         
            NeumaticostextBox.Text = Neumaticos.NeumáticosRecauchutados.ToString();
            NumeraciontextBox1.Text = Neumaticos.NeumáticosAnchos.ToString();
            NumeraciontextBox2.Text = Neumaticos.NeumáticosBajo.ToString();
            NumeraciontextBox3.Text = Neumaticos.NeumáticosInvierno.ToString();
            NumeraciontextBox4.Text = Neumaticos.NeumáticosTodoTiempo.ToString();
            NumeraciontextBox5.Text = Neumaticos.NeumáticosUsados.ToString();
            NumeraciontextBox6.Text = Neumaticos.NeumáticosXL.ToString();
            NumeraciontextBox7.Text = Neumaticos.NeumáticosVerano.ToString();
        }

        private void NeumaticostextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void NumeraciontextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
