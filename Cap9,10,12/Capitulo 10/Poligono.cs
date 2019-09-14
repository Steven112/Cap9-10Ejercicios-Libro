using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cap9_10_12.Capitulo_10;

namespace Cap9_10_12.Capitulo_10
{
    public partial class Poligono : Form
    {
        public Poligono()
        {
            InitializeComponent();
        }

        class Ejercicio3
        {
            public float LongitudLado { get; set; }
            public int CantidadLado { get; set; }

            public Ejercicio3()
            {
                LongitudLado = 0;
                CantidadLado = 0;
            }
            public Ejercicio3(float longitud, int cantidad)
            {
                LongitudLado = longitud;
                CantidadLado = cantidad;
            }

        }
        public class Ejercicio4
        {
            public float LongitudLado
            {
                get
                {
                    return LongitudLado;
                }
                set
                {
                    if (LongitudLado > 0)
                    {
                        LongitudLado = value;
                        return;
                    }
                    LongitudLado = 0;

                }
            }
            public int CantidadLado
            {
                get
                {
                    return CantidadLado;
                }
                set
                {
                    if (CantidadLado > 0)
                    {
                        CantidadLado = value;
                        return;
                    }
                    CantidadLado = 0;

                }
            }
            public Ejercicio4()
            {
                CantidadLado = 0;
                LongitudLado = 0;
            }
            public Ejercicio4(int lados, float longitud)
            {
                CantidadLado = lados;
                LongitudLado = longitud;
            }
        }
        class Ejercicio5 : Ejercicio4
        {
            public override string ToString()
            {
                return "La cantidad de Lado es: " + CantidadLado + "\nLa longitud de Cada Lado es: " + LongitudLado;
            }
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            Ejercicio3 ejercicio4 = new Ejercicio3();

            ejercicio4.CantidadLado = Convert.ToInt32(CantidadtextBox.Text);
            ejercicio4.LongitudLado = Convert.ToSingle (LongitudtextBox.Text);
            float total = Convert.ToInt32(CantidadtextBox.Text) * Convert.ToSingle(LongitudtextBox.Text);
            PerimetrotextBox.Text = Convert.ToString(total);
        }
    }
}
