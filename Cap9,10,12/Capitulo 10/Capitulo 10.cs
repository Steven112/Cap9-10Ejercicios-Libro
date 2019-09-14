using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap9_10_12.Capitulo_10
{
    class Capitulo_10
    {
    }
    class Ejercicio1
    {
        public int Clave { get; set; }
        public String Articulo { get; set; }
        public DateTime FechaDeCompra { get; set; }
        public float Cantidad { get; set; }
        public float CostoUnitario { get; set; }
        public float CostoTotal { get; set; }
    }
    class Ejercicio2
    {
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public String CursoAcademico { get; set; }
        public String NombrePadre { get; set; }
        public String NombreMadre { get; set; }
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

    }

}
