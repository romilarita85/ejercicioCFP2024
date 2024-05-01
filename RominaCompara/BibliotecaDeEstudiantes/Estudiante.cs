using BibliotecaDeEstudiantes;
using System.Text;
using System;

namespace BibliotecaDeEstudiantes
{
    public class Estudiante
    {
        //●	Tendrá un constructor estático que inicializará el atributo estático random.
        private static Random random = new Random();
        
        private string apellido;
        private string nombre;
        private string legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        
        
        //●	Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
        public Estudiante(string apellido, string nombre, string legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }
        //●	El método setter SetNotaPrimerParcial permitirá cambiar
        //el valor del atributo notaPrimerParcial.
        public void SetNotaPrimerParcial(int nota)
        {
            notaPrimerParcial = nota;
        }
        //●	El método setter SetNotaSegundoParcial permitirá cambiar
        //el valor del atributo notaSegundoParcial.
        public void SetNotaSegundoParcial(int nota)
        {
            notaSegundoParcial = nota;
        }

         //●El método privado CalcularPromedio retornará el promedio de las dos notas.
        private double CalcularPromedio()
        {
            return (notaPrimerParcial + notaSegundoParcial) / 2.0;
        }

        //●	El método CalcularNotaFinal deberá retornar la nota del final
        //con un número aleatorio entre 6 y 10 incluidos siempre y
        //cuando las notas del primer y segundo parcial sean mayores o iguales a 4,
        //caso contrario la inicializará con el valor -1.
        public int CalcularNotaFinal()
        {
            if ((notaPrimerParcial >= 4) && (notaSegundoParcial >= 4))
            {
                return random.Next(6, 11);
            }
            else
            {
                return -1;
            }
        }

        //●	El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
        //Nombre, apellido y legajo.
        //Nota del primer y segundo parcial.
        //Promedio.

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"Legajo: {legajo}");
            sb.AppendLine($"Nota del primer parcial: {notaPrimerParcial}");
            sb.AppendLine($"Nota del segundo parcial: {notaSegundoParcial}");
            double promedio = CalcularPromedio();
            sb.AppendLine($"Promedio: {promedio}");
            int notaFinal = CalcularNotaFinal();
            if (notaFinal != -1)
            {
                sb.AppendLine($"Nota final: {notaFinal}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }
            return sb.ToString();
            //Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario
            //se mostrará la leyenda "Alumno desaprobado".
        }
    }
}
