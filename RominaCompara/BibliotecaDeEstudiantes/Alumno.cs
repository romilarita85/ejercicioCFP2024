using BibliotecaDeEstudiantes;
using System.Text;
using System;
namespace BibliotecaDeEstudiantes
{
    public class Alumno
    {
        private string apellido;
        private string nombre;
        private int legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;
        //static Random random = new Random();

        //CONSTRUCTOR*************************************************************
        //●	Tendrá un constructor estático que inicializará el atributo estático random.
        static Alumno() //CONSTRUCTOR ESTATICO
        { 
            Alumno.random = new Random();
        }

        //●	Tendrá un constructor de instancia que inicializará los atributos
        //nombre, apellido y legajo.
        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            
        }
        //METODO SET**************************************************************
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
        //COMPORTAMIENTOS************************************************************
         //●El método privado CalcularPromedio retornará el promedio de las dos notas.
        private double CalcularPromedio()
        {
            double promedio = ((double)notaPrimerParcial + notaSegundoParcial) / 2;
            return promedio;
        }

        //●	El método CalcularNotaFinal deberá retornar la nota del final
        //con un número aleatorio entre 6 y 10 incluidos siempre y
        //cuando las notas del primer y segundo parcial sean mayores o iguales a 4,
        //caso contrario la inicializará con el valor -1.
        public double CalcularNotaFinal()
        {
            double resultado = -1;
            if ((notaPrimerParcial >= 4) && (notaSegundoParcial >= 4))
            {
                double notaFinal = random.Next(6, 11);//numero aleatorio entre 6 y 10
                resultado = notaFinal;
            }
            return resultado;
         
        } 
        //●	El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
//Nombre, apellido y legajo.
//Nota del primer y segundo parcial.
//Promedio.
//Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario
//se mostrará la leyenda "Alumno desaprobado".
        



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

    }
}
