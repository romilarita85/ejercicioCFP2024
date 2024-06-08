using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeAlumnos
{
    public class Materia
    {
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;
        public Materia(string nombre)
        {
            this.nombre = nombre;
        }
        public int CalcularNotaFinal()
        {
            int nota = 0;
            if ((this.notaPrimerParcial >3) && (this.notaSegundoParcial >3))
            {
                nota = Materia.random.Next(6, 10);//numero aleatorio entre 6 y 10
            }
            return nota;
        
        }
        public double CalcularPromedio()
        {
            return ((double)this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }
        public string Nombre { get => nombre;}
        public int NotaPrimerParcial { get => notaPrimerParcial; set => notaPrimerParcial = value; }
        public int NotaSegundoParcial { get => notaSegundoParcial; set => notaSegundoParcial = value; }

        public double NotaFinal
        {
            get
            {
                return CalcularNotaFinal();
            }

        }
    }
}
