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

        public Materia(string nombre)
        {
            this.nombre = nombre;
        }
        public int CalcularNotaFinal()
        {
            int nota = 0;
            return nota;
        
        }
        public string Nombre { get => nombre;}
        public int NotaPrimerParcial { get => notaPrimerParcial; set => notaPrimerParcial = value; }
        public int NotaSegundoParcial { get => notaSegundoParcial; set => notaSegundoParcial = value; }
    }
}
