using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeAlumnos
{
    public class Ingresante
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string genero;
        private string pais;
        private List<string> cursos;

        public Ingresante(string nombre, string apellido, int edad, string genero, string pais, List<string> cursos)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
        }

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public int Edad { get => edad;}
        public string Genero { get => genero;}
        public string Pais { get => pais; }
        
        //lista de string genera problemas al usar DataGrew
        //Solucion ->usar StringBuilder
        public string Cursos 
        {
            get 
            {
                StringBuilder sb = new StringBuilder();//crea un nuevo objeto StringBuilder.
              //Se utiliza StringBuilder porque es más eficiente que concatenar cadenas directamente
              //dentro de un bucle.

                for (int i = 0; i < cursos.Count; i++)
                {//Este bucle itera a través de cada elemento en la colección cursos.
                    sb.Append(cursos[i]);//agrega el nombre del curso en el índice i de la colección
                    //cursos al StringBuilder.

                    if (i< cursos.Count - 1)
                    {//Verifica si el curso actual no es el último(basado en el índice comenzando desde cero).
                     //Si no es el último curso, agrega " - " para separar los cursos.
                        sb.Append(" - ");
                    }
                }
                return sb.ToString();//return sb.ToString(); convierte el objeto StringBuilder a una
                                     //cadena de texto y retorna el resultado concatenado.   
            } 
        }




    }
}
