//2.	Crear una aplicación de consola y una biblioteca de clases 
//que contenga la clase del siguiente diagrama:
//Diagrama de clases
//La clase Estudiante:
//●	Tendrá un constructor estático que inicializará el atributo estático random.
//●	Tendrá un constructor de instancia que inicializará los atributos
//nombre, apellido y legajo.
//●	El método setter SetNotaPrimerParcial permitirá cambiar
//el valor del atributo notaPrimerParcial.
//●	El método setter SetNotaSegundoParcial permitirá cambiar
//el valor del atributo notaSegundoParcial.
//●	El método privado CalcularPromedio retornará el promedio de las dos notas.
//●	El método CalcularNotaFinal deberá retornar la nota del final con un número aleatorio entre 6 y 10 incluidos siempre y cuando las notas del primer y segundo parcial sean mayores o iguales a 4, caso contrario la inicializará con el valor -1.
//●	El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
//Nombre, apellido y legajo.
//Nota del primer y segundo parcial.
//Promedio.
//Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario
//se mostrará la leyenda "Alumno desaprobado".

//●	Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
//●	Cargar las notas del primer y segundo parcial a todos los alumnos.
//Dos deberán estar aprobados y uno desaprobado.
//●	Mostrar los datos de todos los alumnos.
using BibliotecaDeEstudiantes;
namespace Ejercicio_Objetos_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //●	Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
            Estudiante estudianteUno = new Estudiante("Roxana", "Sanchez", 00001);
            Estudiante estudianteDos = new Estudiante("Jorge", "Birman", 0002);
            Estudiante estudianteTres = new Estudiante("Carolina", "Perez", 0003);
            
            //●	Cargar las notas del primer y segundo parcial a todos los alumnos.
            //Dos deberán estar aprobados y uno desaprobado.
            estudianteUno.SetNotaPrimerParcial(7);
            estudianteUno.SetNotaSegundoParcial(7);

            estudianteDos.SetNotaPrimerParcial(8);
            estudianteDos.SetNotaSegundoParcial(9);

            estudianteTres.SetNotaPrimerParcial(1);
            estudianteTres.SetNotaSegundoParcial(4);

            //●	Mostrar los datos de todos los alumnos.
            Console.WriteLine("Datos del estudiante 1:");
            Console.WriteLine(estudianteUno.Mostrar());

            Console.WriteLine("**************************");
            Console.WriteLine("Datos del estudiante 2:");
            Console.WriteLine(estudianteDos.Mostrar());

            Console.WriteLine("**************************");
            Console.WriteLine("Datos del estudiante 3:");
            Console.WriteLine(estudianteTres.Mostrar());

            Console.ReadLine(); 
        }
    }
}
