using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeAlumnos
{
    public class EstadoAcademico
    {
        private Alumno alumno;
        private string carrera;
        private List<Materia> materias;

        //SOBRECARGA DE CONSTRUCTORES:
        private EstadoAcademico()
        {
            this.materias = new List<Materia>();
        }
        public EstadoAcademico(Alumno alumno,string carrera):this()
        {
            this.alumno = alumno;
            this.carrera = carrera;
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
        public string Carrera { get => carrera; set => carrera = value; }
    }
}
//****************************************************************************************
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BibliotecaDeAlumnos
//{
//    public class EstadoAcademico
//    {
//        private Alumno alumno;
//        private List<Materia> materias;
//        private string carrera;

//        //SOBRECARGA DE CONSTRUCTORES:
//        public EstadoAcademico()
//        {
//            this.materias = new List<Materia>();
//        }
//        public EstadoAcademico(Alumno alumno) : this()
//        {
//            this.alumno = alumno;
//        }
//        public EstadoAcademico(Alumno alumno, List<Materia> materias) : this(alumno)
//        {
//            this.materias = materias;
//        }

//        public EstadoAcademico(Alumno alumno, List<Materia> materias, string carrera) : this(alumno, materias)
//        {
//            this.carrera = carrera;
//        }

//        public Materia SetMateria
//        {
//            set
//            {
//                this.materias.Add(value);
//            }
//        }

//        public List<Materia> Materias
//        {
//            get
//            {
//                return this.materias;
//            }
//        }
//        public Alumno Alumno
//        {
//            get
//            {
//                return this.alumno;
//            }
//        }
//    }
//}
//**************************************************************+++
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BibliotecaDeAlumnos
//{
//    public class EstadoAcademico
//    {
//        private Alumno alumno;
//        private string carrera;
//        private List<Materia> materias;

//        //SOBRECARGA DE CONSTRUCTORES:
//        private EstadoAcademico()
//        {
//            this.materias = new List<Materia>();
//        }
//        public EstadoAcademico(Alumno alumno) : this()
//        {
//            this.alumno = alumno;
//        }
//        public EstadoAcademico(Alumno alumno, string carrera) : this(alumno)
//        {
//            this.carrera = carrera;
//        }
//        public EstadoAcademico(Alumno alumno, string carrera, List<Materia> materias) : this(alumno, carrera)
//        {
//            this.materias = materias;
//        }
//        public Materia SetMateria
//        {
//            set
//            {
//                this.materias.Add(value);
//            }
//        }

//        public List<Materia> Materias
//        {
//            get
//            {
//                return this.materias;
//            }
//        }
//        public Alumno Alumno
//        {
//            get
//            {
//                return this.alumno;
//            }
//        }

//        public string Carrera { get => carrera; set => carrera = value; }
//    }
//}
