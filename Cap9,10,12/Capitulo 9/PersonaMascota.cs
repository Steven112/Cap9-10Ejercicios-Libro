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
    public partial class PersonaMascota : Form
    {
        public PersonaMascota()
        {
            InitializeComponent();
        }
        //La estructura dueño y Mascota Pertenecen al Mismo Ejercicio.
        public struct Mascota
        {
            public string NombreMascota;
            public int EdadMascota;
            public string RazaMascota;

            public Mascota(string sNombreMascota, int sEdadMascota, string sRazaMascota)
            {
                NombreMascota = sNombreMascota;
                EdadMascota = sEdadMascota;
                RazaMascota = sRazaMascota;
            }
        }

        public struct Dueño
        {
            public string NombreDueño;
            public int EdadDueño;
            public Mascota Perro;

            public Dueño(string sNombreDueño, int sEdadDueño, string NombreMascota, int EdadMascota, string RazaMascota)
            {
                NombreDueño = sNombreDueño;
                EdadDueño = sEdadDueño;
                Perro = new Mascota(NombreMascota, EdadMascota, RazaMascota);
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
           

           

            Dueño []dueño = new Dueño[5];

            dueño[1].NombreDueño = NombreDuenotextBox.Text;
            dueño[1].EdadDueño = Convert.ToInt32(EdadDuenotextBox.Text);
            dueño[1].Perro.NombreMascota = NombremascotatextBox.Text;
            dueño[1].Perro.EdadMascota = Convert.ToInt32(EdadMacotatextBox.Text);
            dueño[1].Perro.RazaMascota = RazatextBox.Text;

            if (dueño != null)
            {
                MessageBox.Show("Guardado");

            }
            else
            {
                MessageBox.Show("No Guardado");
            }
        }

        private void NombreDuenotextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
