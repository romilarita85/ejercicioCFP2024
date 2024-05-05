//Ejercicio_Vectores_5:
//Ingresar datos en un vector y mostrarlos al revés.
namespace Ejercicio_Vectores_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] misNumeros = CargarArrayDeEnteros(5);

            ImprimirArray("****elementos del array misNumeros****", misNumeros);
            Array.Reverse(misNumeros);
            ImprimirArray("****elementos del array misNumeros al reves****", misNumeros);
            //Crea un array de enteros llamado misNumeros
            //usando el método CargarArrayDeEnteros,
            //imprime el array, lo invierte utilizando Array.Reverse
            //y luego lo imprime nuevamente.
        }
        //-CargarArrayDeEnteros: Este método toma un parámetro cantidad que indica
        //cuántos elementos debe tener el array.
        //Luego, solicita al usuario que ingrese números cantidad veces,
        //utilizando el método PedirEntero, y los almacena en el array numeros.
        static int[] CargarArrayDeEnteros(int cantidad)//lo que recibe-parametros
        {
            int[] numeros = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = PedirEntero($"Ingrese el nunero {i + 1} de {cantidad}: ", "El dato ingresado no es un numero");
            }
            return numeros;
        }
        //-PedirEntero: Este método toma un mensaje para mostrar al usuario
        //y otro mensaje para mostrar en caso de que la entrada no sea un número válido.
        //Utiliza un bucle while para continuar solicitando la entrada
        //hasta que el usuario ingrese un número válido.
        //Utiliza PedirCadena para obtener la entrada del usuario y
        //luego intenta analizarla como un entero.
        //Si tiene éxito, devuelve el entero; de lo contrario,
        //muestra un mensaje de error y solicita nuevamente la entrada.
        static int PedirEntero(string mensaje, string mensajeError)
        {
            int numeroValido;
            string numeroLeido;
            numeroLeido = PedirCadena(mensaje);

            while (!int.TryParse(numeroLeido, out numeroValido))
            {
                Console.WriteLine(mensajeError);
                numeroLeido = PedirCadena(mensaje);
            }
            return numeroValido;
        }
        //-PedirCadena: Este método simplemente muestra un mensaje y luego devuelve
        //la cadena ingresada por el usuario utilizando Console.ReadLine().
        static string PedirCadena(string mensaje)
        {
            Console.Write(mensaje);
            return Console.ReadLine();
        }
        //ImprimirArray: Este método imprime los elementos de un array de enteros
        //junto con un título. Itera a través del array misNumeros y
        //muestra cada elemento en una nueva línea.
        static void ImprimirArray(string titulo, int[] misNumeros)
        {
            Console.WriteLine(titulo);
            foreach (int numero in misNumeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
//*******************************************************
//namespace Ejercicio_Vectores_5
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //Inicio del programa: El programa comienza ejecutando el método Main.
//            //-Solicitud de la cantidad de elementos: El programa muestra un mensaje
//            //pidiendo al usuario que ingrese la cantidad de elementos
//            //que desea ingresar en el array.
//            //-Entrada de la cantidad de elementos: El usuario ingresa un número entero
//            //representando la cantidad de elementos que desea ingresar en el array.
//            int cantidadElementos = PedirEntero("Ingrese la cantidad de elementos: ");
//            int[] numeros = CargarArrayDeEnteros(cantidadElementos);

//            Console.WriteLine("Elementos del array ingresados:");
//            ImprimirArray(numeros);

//            Console.WriteLine("Elementos del array al revés:");
//            Array.Reverse(numeros);
//            ImprimirArray(numeros);
//        }
//        //-Creación del array: Se crea un array de enteros llamado numeros con
//        //la longitud especificada por el usuario.
//        //-Solicitud de los números: El programa ingresa a un bucle for donde
//        //solicita al usuario que ingrese un número para cada posición del array.
//        static int[] CargarArrayDeEnteros(int cantidad)
//        {
//            int[] numeros = new int[cantidad];
//            for (int i = 0; i < cantidad; i++)
//            {
//                numeros[i] = PedirEntero($"Ingrese el número {i + 1} de {cantidad}: ");
//            }
//            return numeros;
//        }
//        //-Validación de la entrada: Para cada entrada del usuario, el programa
//        //verifica si es un número válido. Si no lo es, muestra un mensaje de error y
//        //solicita nuevamente la entrada para esa posición.
//        static int PedirEntero(string mensaje)
//        {
//            int numeroValido;
//            Console.Write(mensaje);
//            while (!int.TryParse(Console.ReadLine(), out numeroValido))
//            {
//                Console.WriteLine("El dato ingresado no es un número válido. Inténtelo de nuevo.");
//                Console.Write(mensaje);
//            }
//            return numeroValido;
//        }
//        //-Almacenamiento de los números: Cada número ingresado por el usuario se
//        //almacena en la posición correspondiente del array.
//        //-Impresión del array original: Después de que el usuario ha ingresado todos
//        //los números, el programa imprime los elementos del array en el orden en
//        //que se ingresaron.
//        //-Inversión del array: El programa utiliza el método Array.Reverse
//        //para invertir el orden de los elementos en el array.
//        //-Impresión del array invertido: Después de invertir el array,
//        //el programa imprime nuevamente los elementos del array, esta vez en orden inverso.
//        //-Fin del programa: Una vez que se ha completado la impresión
//        //del array invertido, el programa termina.
//        static void ImprimirArray(int[] array)
//        {
//            foreach (int numero in array)
//            {
//                Console.WriteLine(numero);
//            }
//        }

//    }
//}
