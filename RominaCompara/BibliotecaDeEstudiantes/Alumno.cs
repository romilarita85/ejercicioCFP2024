using BibliotecaDeEstudiantes;
using System.Text;
using System;
namespace BibliotecaDeEstudiantes
{
    public class Alumno
    {   //private int legajo;
        private string legajo;
        private string nombre;
        private string apellido;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;
        //static Random random = new Random();
        public string Legajo
        {
            set
            {
                this.legajo = value;
            }
            get 
            {
                //return; //captura 1394
            }
        }

        //CONSTRUCTOR*************************************************************
        //●	Tendrá un constructor estático que inicializará el atributo estático random.
        static Alumno() //CONSTRUCTOR ESTATICO
        { 
            Alumno.random = new Random();
        }

        //●	Tendrá un constructor de instancia que inicializará los atributos
        //nombre, apellido y legajo.
        public Alumno(string legajo, string nombre, string apellido)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
        }
        //METODO SET**************************************************************
        //●	El método setter SetNotaPrimerParcial permitirá cambiar
        //el valor del atributo notaPrimerParcial.
        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }
        //●	El método setter SetNotaSegundoParcial permitirá cambiar
        //el valor del atributo notaSegundoParcial.
        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }
        //COMPORTAMIENTOS************************************************************
         //●El método privado CalcularPromedio retornará el promedio de las dos notas.
        private double CalcularPromedio()
        {
            return ((double)this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }

        //●	El método CalcularNotaFinal deberá retornar la nota del final
        //con un número aleatorio entre 6 y 10 incluidos siempre y
        //cuando las notas del primer y segundo parcial sean mayores o iguales a 4,
        //caso contrario la inicializará con el valor -1.
        public double CalcularNotaFinal()
        {
            double resultado = -1;
            if ((this.notaPrimerParcial >= 4) && (this.notaSegundoParcial >= 4))
            {
                resultado = Alumno.random.Next(6, 10);//numero aleatorio entre 6 y 10
            }
            return resultado;
         
        }
        //●	El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
        //Nombre, apellido y legajo.
        //Nota del primer y segundo parcial.
        //Promedio.
        //Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario
        //se mostrará la leyenda "Alumno desaprobado".
        public string Mostrar()
        {
            // Implementa la lógica para mostrar los datos del estudiante
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Alumno: {this.nombre},{this.apellido} - Legajo n°: {this.legajo}");
            sb.AppendLine($"Nota 1° parcial: {this.notaPrimerParcial}");
            sb.AppendLine($"Nota 2° parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {this.CalcularPromedio()}");
            double notaFinal = this.CalcularNotaFinal();
            
            if (notaFinal != -1)
            {
                sb.AppendLine($"Nota final: {notaFinal}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }
            return sb.ToString();
        }
    }
}

//public string Mostrar()
//{
//    double notaFinal = CalcularNotaFinal();
//    if (CalcularNotaFinal() == -1)
//    {
//        return $"Nombre: {nombre}\n" +
//           $"Apellido: {apellido}\n" +
//           $"Legajo: {legajo}\n" +
//           $"Nota del primer parcial: {notaPrimerParcial}\n" +
//           $"Nota del segundo parcial: {notaSegundoParcial}\n" +
//           $"Promedio: {CalcularPromedio()}\n" +
//           "Alumno desaprovado";
//    }
//    else 
//    {
//        return $"Nombre: {nombre}\n" +
//           $"Apellido: {apellido}\n" +
//           $"Legajo: {legajo}\n" +
//           $"Nota del primer parcial: {notaPrimerParcial}\n" +
//           $"Nota del segundo parcial: {notaSegundoParcial}\n" +
//           $"Promedio: {CalcularPromedio()}\n" +
//           $"Nota final: {notaFinal}";

//    }
//}