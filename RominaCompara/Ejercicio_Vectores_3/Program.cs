//Ejercicio Vectores 3:	
//Idem punto 2, pero calcular el promedio.
namespace Ejercicio_Vectores_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-Método Main:
            //Comienza declarando un array misNumeros y lo inicializa llamando
            //al método CargarArrayDeEnteros con un argumento de 5,
            //lo que significa que el usuario ingresará 5 números enteros.
            int[] misNumeros = CargarArrayDeEnteros(5);
            //Luego calcula la suma de los números en el array llamando
            //al método SumaValoresArrayEnteros.
            int valorSuma = SumaValoresArrayEnteros(misNumeros);
            //Calcula el promedio de los números en el array llamando
            //al método CalcularPromedioArrayEnteros.
            double promedio = CalcularPromedioArrayEnteros(misNumeros);
            //Finalmente, imprime los números ingresados, la suma y el promedio.
            ImprimirArray("Los numeros ingresados son: ", misNumeros);
            Console.WriteLine($"El valor de la suma es: {valorSuma}");
            Console.WriteLine($"El valor del promedio es: {promedio}");
        }
        //-Método CargarArrayDeEnteros:
        static int[] CargarArrayDeEnteros(int cantidad)//Este método recibe un parámetro
                                                       //cantidadque  indica cuántos
                                                      //números debe ingresar el usuario.
        {
            int[] numeros = new int[cantidad];//Crea un nuevo array numeros
                                              //con la longitud especificada.
           
            //Utiliza un bucle for para pedir al usuario que ingrese cada número
            //utilizando el método PedirEntero.
            //Almacena cada número ingresado en el array.
            //Devuelve el array completo.
            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = PedirEntero($"Ingrese el nunero {i + 1} de {cantidad}: ", "El dato ingresado no es un numero");
            }
            return numeros;
        }
        //-Método PedirEntero:
        //Este método solicita al usuario que ingrese un número a través 
        //de la función PedirCadena.
        //Luego utiliza int.TryParse para intentar convertir la entrada del usuario
        //en un número entero.
        //Si la conversión es exitosa, devuelve el número entero.
        //Si la conversión falla, muestra un mensaje de error y solicita
        //al usuario que ingrese un número nuevamente hasta que proporcione
        //una entrada válida
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
        //-Método PedirCadena:
        //Este método simplemente imprime un mensaje y espera
        //a que el usuario ingrese una cadena.
        static string PedirCadena(string mensaje)
        {
            Console.Write(mensaje);
            return Console.ReadLine();
        }
        //-Método ImprimirArray:
        //Este método recibe un título y un array de enteros como parámetros.
        //Imprime el título.
        //Luego, mediante un bucle foreach, imprime cada elemento del array
        //en una línea separada.
        static void ImprimirArray(string titulo, int[] misNumeros)
        {
            Console.WriteLine(titulo);
            foreach (int numero in misNumeros)
            {
                Console.WriteLine(numero);
            }
        }
        //-Método SumaValoresArrayEnteros:
        //Este método recibe un array de enteros y devuelve
        //la suma de todos los elementos del array.
        static int SumaValoresArrayEnteros(int[] misNumeros)
        {
            int suma = 0;
            foreach (int numero in misNumeros)
            {
                suma += numero;
            }
            return suma;
        }
        //-Método CalcularPromedioArrayEnteros:
        //Este método recibe un array de enteros y devuelve
        //el promedio de todos los elementos del array.
        static double CalcularPromedioArrayEnteros(int[] misNumeros)
        {
            int suma = 0;
            double resultado;
            foreach (int numero in misNumeros)
            {
                suma += numero;//Calcula la suma de los elementos del array.
            }
            resultado = suma / misNumeros.Length;//Divide la suma por la longitud
            return resultado;                    //del array para obtener
                                                 //el promedio y lo devuelve.
        }
    }
}
//********************************************************************+
//namespace Ejercicio_Vectores_3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // Declarar el vector de enteros y variables auxiliares
//            int[] vector = new int[5];
//            int suma = 0;

//            // Pedir al usuario que ingrese los valores del vector
//            Console.WriteLine("Ingrese 5 números enteros:");

//            // Ciclo para llenar el vector con los valores ingresados por el usuario
//            for (int i = 0; i < vector.Length; i++)
//            {
//                // Pedir al usuario que ingrese un número entero
//                Console.Write("Elemento {0}: ", i + 1);
//                string entrada = Console.ReadLine();

//                // Intentar convertir la entrada a un número entero
//                if (int.TryParse(entrada, out vector[i]))
//                {
//                    // Sumar el valor al acumulador de suma
//                    suma += vector[i];
//                }
//                else
//                {
//                    // Mostrar un mensaje de error si la entrada no es un número entero
//                    Console.WriteLine("Error: Debe ingresar un número entero.");
//                    // Decrementar el índice para repetir la iteración con el mismo índice
//                    //i--;
//                }
//            }
//            // Calcular el promedio
//            double promedio = (double)suma / vector.Length;

//            // Mostrar la suma y el promedio
//            Console.WriteLine("La suma de los valores es: " + suma);
//            Console.WriteLine("El promedio de los valores es: " + promedio);

//        }

//    }
//}
