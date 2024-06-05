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
        private int duracion;
        private int notaPrimerParcial;
        private int notaSegundoParcial;

        public Materia(string nombre, int duracion)
        {
            this.nombre = nombre;
            this.duracion = duracion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public int NotaPrimerParcial { get => notaPrimerParcial; set => notaPrimerParcial = value; }
        public int NotaSegundoParcial { get => notaSegundoParcial; set => notaSegundoParcial = value; }
    }
}
