using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeAlumnos
{
    public class Evaluacion
    {
        private Alumno alumno;
        private List<Materia> materias;
        
        //SOBRECARGA DE CONSTRUCTORES:
        public Evaluacion()
        {
            this.materias = new List<Materia>();    
        }
        public Evaluacion(Alumno alumno):this()
        {
            this.alumno = alumno;
        }
        public Evaluacion(Alumno alumno, List<Materia> materias):this(alumno)
        {
            this.materias = materias;
        }

        public Materia SetMateria 
        {
            set
            {
                this.materias.Add(value);
            }
        }

        public List<Materia> Materias 
        {
            get
            {
                return this.materias;
            }
        }
        public Alumno Alumno
        {
            get
            {
                return this.alumno;
            }
        }
    }
}
