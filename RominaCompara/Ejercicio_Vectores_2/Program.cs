//Ejercicio_Vectores_2:
//Cargar un vector de enteros de 5 elementos, sumar los valores y mostrarlo.
namespace Ejercicio_Vectores_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] misNumeros = CargarArrayDeEnteros(5);
            int valorSuma = SumaValoresArrayEnteros(misNumeros);
            ImprimirArray("Los numeros ingresados son: ", misNumeros);
            Console.WriteLine($"El valor de la suma es: {valorSuma}");
        }
        //En el método CargarArrayDeEnteros, se solicita al usuario
        //que ingrese números enteros y se almacenan en un array.
        static int[] CargarArrayDeEnteros(int cantidad)
        {
            int[] numeros = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = PedirEntero($"Ingrese el nunero {i + 1} de {cantidad}: ", "El dato ingresado no es un numero");
            }
            return numeros;
        }
        //El método PedirEntero se utiliza para solicitar al usuario
        //un número entero y validar la entrada.
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
        //PedirCadena se utiliza para solicitar al usuario una cadena y devolverla.
        static string PedirCadena(string mensaje)
        {
            Console.Write(mensaje);
            return Console.ReadLine();
        }
        //ImprimirArray se utiliza para imprimir el contenido del array.
        static void ImprimirArray(string titulo, int[] misNumeros)
        {
            Console.WriteLine(titulo);
            foreach (int numero in misNumeros)
            {
                Console.WriteLine(numero);
            }
        }
        //SumaValoresArrayEnteros calcula la suma de los valores en el array.
        static int SumaValoresArrayEnteros(int[] misNumeros)
        {
            int suma = 0;
            foreach (int numero in misNumeros)
            {
                suma += numero;
            }
            return suma;
        }
    }
}
////Otra forma***************
//namespace Ejercicio_Vectores_2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] vector = new int[5]; // Declaración de un vector de enteros con 5 elementos

//            //Bucle for para cargar los valores en el vector
//            for (int i = 0; i < 5; i++)
//            {
//                Console.Write($"Ingrese el valor del elemento {i + 1}: ");
//                string input = Console.ReadLine(); //Leer la entrada del usuario como cadena
//                while (!int.TryParse(input, out vector[i]))//Intentar convertir la entrada en un entero
//                {
//                    Console.Write("El dato ingresado no es un numero. Ingrese un número entero: ");
//                    input = Console.ReadLine(); //Leer la entrada nuevamente si la conversión falla
//                }
//            }

//            // Calcular la suma de los valores del vector
//            int suma = 0;
//            foreach (int num in vector)
//            {
//                suma += num;
//            }

//            // Mostrar la suma
//            Console.WriteLine($"La suma de los valores del vector es: {suma}");

//            Console.ReadLine(); 
//        }
//    }
//}