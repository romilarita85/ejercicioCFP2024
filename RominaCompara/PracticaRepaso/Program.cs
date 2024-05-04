/////Ejercicio_Vectores_2:
//Cargar un vector de enteros de 5 elementos, sumar los valores y mostrarlo.
//namespace PracticaRepaso
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] vector = new int[5]; // Declaración de un vector de enteros con 5 elementos

//            // Ciclo para cargar los valores en el vector
//            for (int i = 0; i < 5; i++)
//            {
//                Console.Write($"Ingrese el valor del elemento {i + 1}: ");
//                string input = Console.ReadLine(); // Leer la entrada del usuario como cadena
//                while (!int.TryParse(input, out vector[i])) // Intentar convertir la entrada en un entero
//                {
//                    Console.Write("Entrada inválida. Por favor, ingrese un número entero: ");
//                    input = Console.ReadLine(); // Leer la entrada nuevamente si la conversión falla
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

//            Console.ReadLine(); // Esperar a que el usuario presione Enter antes de cerrar la consola
//        }
//    }
//}
namespace PracticaRepaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[5]; // Declaración de un vector de enteros con 5 elementos

            // Ciclo para cargar los valores en el vector
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingrese el valor del elemento {i + 1}: ");
                string input = Console.ReadLine(); // Leer la entrada del usuario como cadena
                while (!int.TryParse(input, out vector[i])) // Intentar convertir la entrada en un entero
                {
                    Console.Write("Entrada inválida. Por favor, ingrese un número entero: ");
                    input = Console.ReadLine(); // Leer la entrada nuevamente si la conversión falla
                }
            }

            // Calcular la suma de los valores del vector
            int suma = 0;
            foreach (int num in vector)
            {
                suma += num;
            }

            // Mostrar la suma
            Console.WriteLine($"La suma de los valores del vector es: {suma}");

            Console.ReadLine(); // Esperar a que el usuario presione Enter antes de cerrar la consola
        }
    }
}