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
using BibliotecaDeAlumnos;
namespace Ejercicio_Objetos_2
{
    internal class Program
    {
        static void Main(string[] args)
        {//En el método Main, se crea una instancia de la clase Random para generar números aleatorios.

            Alumno alumno1 = new Alumno("1006", "Roxana", "Gomez");
           
            //Materia matematicas = new Materia("matematica", 3);
           
            //EstadoAcademico eva1= new EstadoAcademico(alumno1);

            //eva1.SetMateria = matematicas;

            //Console.WriteLine($"alumno:{eva1.Alumno}");

            //Console.WriteLine("Esta cursando:");

            //foreach (Materia item in eva1.Materias)
            //{
            //    Console.WriteLine(item.Nombre);
            //}
            //EstadoAcademico otra = new EstadoAcademico (new Alumno("1006","Carlos","Rodriguez"), new List<Materia>(),"abogacia");

            //EstadoAcademico otra2 = new EstadoAcademico(new Alumno(), new List<Materia>());
            
            //alumno1.NotaPrimerParcial = 8; //Acceso a la PROPIEDAD
            //alumno1.SetNotaPrimerParcial(8);//Uso el METODO   
            ////alumno1.Legajo = "1007"; // voy a poder consultar ese valor

            //Console.WriteLine(alumno1.Legajo);

            //Random rand = new Random();

            //List<Alumno> alumnos = new List<Alumno>()
            //{//En la declaracion de la lista me guardo todos los alumnos
            //    new Alumno("1001","Roxana","Gomez"),
            //    new Alumno("1002","Carlos","Ramos"),
            //    new Alumno("1003","Cesar","Vivas"),
            //    new Alumno("1004","Clara","Sanchez"),
            //    new Alumno("1005", "Andrea", "Alvares")
            //};
            ////Se crea una lista de alumnos(List<Alumno> alumnos) que almacenará instancias de la clase Alumno.
            ////Dentro de la lista de alumnos, se crean instancias de Alumno con diferentes
            ////nombres, apellidos y números de identificación.
            //foreach (Alumno a in alumnos)
            //{
            //    a.SetNotaPrimerParcial(rand.Next(1, 10));
            //    a.SetNotaSegundoParcial(rand.Next(1, 10));
            //    //Se itera sobre cada instancia de Alumno en la lista y se asignan notas aleatorias
            //    //para el primer y segundo parcial utilizando
            //    //el método SetNotaPrimerParcial y SetNotaSegundoParcial de la clase Alumno.
            //}
            //foreach (Alumno item in alumnos)
            //{
            //    Console.WriteLine(item.Mostrar());
            //    //Se itera nuevamente sobre cada instancia de Alumno en la lista
            //    //y se muestra la información de cada alumno utilizando el método Mostrar de la clase Alumno.
            //}
        }
    }
}
//***********************************MULTIPLES INSTANCIAS**************************************************
//using BibliotecaDeEstudiantes;
//namespace Ejercicio_Objetos_2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {//En el método Main, se crea una instancia de la clase Random para generar números aleatorios.
//            Random rand = new Random();
//            //MULTIPLES INSTANCIAS-Se crea instancias dentro de la lista
//            List<Alumno> alumnos = new List<Alumno>()
//            {//En la declaracion de la lista me guardo todos los alumnos
//                new Alumno("10001","Roxana","Gomez"),
//                new Alumno("10002","Carlos","Ramos"),
//                new Alumno("10003","Cesar","Vivas"),
//                new Alumno("10004","Clara","Sanchez"),
//                new Alumno("10005", "Andrea", "Alvares")
//            };
//            //Se crea una lista de alumnos (List<Alumno> alumnos) que almacenará instancias de la clase Alumno.
//            //Dentro de la lista de alumnos, se crean instancias de Alumno con diferentes
//            //nombres, apellidos y números de identificación.
//            foreach (Alumno a in alumnos)
//            {
//                a.SetNotaPrimerParcial(rand.Next(1, 10));
//                a.SetNotaSegundoParcial(rand.Next(1, 10));
//                //Se itera sobre cada instancia de Alumno en la lista y se asignan notas aleatorias
//                //para el primer y segundo parcial utilizando
//                //el método SetNotaPrimerParcial y SetNotaSegundoParcial de la clase Alumno.
//            }
//            foreach (Alumno item in alumnos)
//            {
//                Console.WriteLine(item.Mostrar());
//                //Se itera nuevamente sobre cada instancia de Alumno en la lista
//                //y se muestra la información de cada alumno utilizando el método Mostrar de la clase Alumno.
//            }
//        }
//    }
//}
////el código simula el proceso de carga de notas para un grupo de alumnos y luego muestra sus datos,
////incluyendo sus nombres, apellidos, números de identificación, notas del primer y segundo parcial,
////promedio y, en caso de aprobar, la nota final.

///**********+**************************DECLARAR E INSTANCIAR**********************************************************
//using BibliotecaDeEstudiantes;
//namespace Ejercicio_Objetos_2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {//En el método Main, se crea una instancia de la clase Random para generar números aleatorios.
//            Random rand = new Random();
//            //DECLARAR-INSTANCIAR
//            Alumno alumno1 = new Alumno("10001", "Roxana", "Gomez");
//            Alumno alumno2 = new Alumno("10002", "Carlos", "Ramos");
//            Alumno alumno3 = new Alumno("10003", "Cesar", "Vivas");
//            Alumno alumno4 = new Alumno("10004", "Clara", "Sanchez");
//            Alumno alumno5 = new Alumno("10005", "Andrea", "Alvares");

//            List<Alumno> alumnos = new List<Alumno>();
//            alumnos.Add(alumno1);
//            alumnos.Add(alumno2);
//            alumnos.Add(alumno3);
//            alumnos.Add(alumno4);
//            alumnos.Add(alumno5);

//            foreach (Alumno a in alumnos)
//            {
//                a.SetNotaPrimerParcial(rand.Next(1, 10));
//                a.SetNotaSegundoParcial(rand.Next(1, 10));
//            }
//            foreach (Alumno item in alumnos)
//            {
//                Console.WriteLine(item.Mostrar());
//            }
//        }
//    }
//}
//***************************************************************************************************
//using BibliotecaDeEstudiantes;
//namespace Ejercicio_Objetos_2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //●	Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
//            Alumno estudianteUno = new Alumno("Roxana", "Sanchez", "00001");
//            Alumno estudianteDos = new Alumno("Jorge", "Birman", "0002");
//            Alumno estudianteTres = new Alumno("Carolina", "Perez", "0003");

//            //●	Cargar las notas del primer y segundo parcial a todos los alumnos.
//            //Dos deberán estar aprobados y uno desaprobado.
//            estudianteUno.SetNotaPrimerParcial(7);
//            estudianteUno.SetNotaSegundoParcial(7);

//            estudianteDos.SetNotaPrimerParcial(8);
//            estudianteDos.SetNotaSegundoParcial(9);

//            estudianteTres.SetNotaPrimerParcial(1);
//            estudianteTres.SetNotaSegundoParcial(4);

//            //●	Mostrar los datos de todos los alumnos.
//            Console.WriteLine("Datos del estudiante 1:");
//            Console.WriteLine(estudianteUno.Mostrar());
//            Console.WriteLine("**************************");
//            Console.WriteLine("Datos del estudiante 2:");
//            Console.WriteLine(estudianteDos.Mostrar());
//            Console.WriteLine("**************************");
//            Console.WriteLine("Datos del estudiante 3:");
//            Console.WriteLine(estudianteTres.Mostrar());

//            Console.ReadLine();
//        }
//    }
//}