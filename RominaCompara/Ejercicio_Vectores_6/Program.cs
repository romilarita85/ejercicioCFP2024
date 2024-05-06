//Ejercicio_Vectores_6
//Ingresar números en un vector, pueden ser positivos o negativos.
//Mostrar los negativos de forma creciente y los positivos de forma decreciente.
//Ejemplo:
//Vector ingresado: { 5, 1, -9, -1, 9, 3, -2, 2}
//Vector ordenado: { -9, -2, -1, 9, 5, 3, 2, 1}
//namespace Ejercicio_Vectores_6
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] misNumeros = CargarArrayDeEnteros(8);

//            OrdenarPorCriterio(misNumeros, true);
//            MostrarPorCriterio("Positivos en forma creciente", misNumeros, true);

//            OrdenarPorCriterio(misNumeros, false);
//            MostrarPorCriterio("Negativos en forma decreciente", misNumeros, false);
//        }
//        public static int[] CargarArrayDeEnteros(int cantidad)
//        {
//            int[] numeros = new int[cantidad];
//            for (int i = 0; i < cantidad; i++)
//            {
//                numeros[i] = PedirEntero($"Ingrese el nunero {i + 1} de {cantidad}: ", "El dato ingresado no es un numero");
//            }
//            return numeros;
//        }
//        public static int PedirEntero(string mensaje, string mensajeError)
//        {
//            int numeroValido;
//            string numeroLeido;
//            numeroLeido = PedirCadena(mensaje);

//            while (!int.TryParse(numeroLeido, out numeroValido))
//            {
//                Console.WriteLine(mensajeError);
//                numeroLeido = PedirCadena(mensaje);
//            }
//            return numeroValido;
//        }
//        public static string PedirCadena(string mensaje)
//        {
//            Console.Write(mensaje);
//            return Console.ReadLine();
//        }
//        public static int[] MostrarPorCriterio(string mensaje, int[] vector, bool mostrarPositivo)
//        {//Forma simplificada
//            Console.WriteLine(mensaje);
//            foreach (int numero in vector)
//            {
//                if ((mostrarPositivo == true && numero > 0) || (mostrarPositivo == false && numero < 0))
//                {
//                    Console.WriteLine(numero); //muestra el numero
//                }
//            }
//            return vector;
//        }
//        public static int[] OrdenarPorCriterio(int[] datos, bool ordenarMenor)
//        {//Forma mas simple
//            //arrays ordenados de menor a mayor
//            int aux;
//            for (int i = 0; i < datos.Length; i++)
//            {
//                for (int j = i + 1; j < datos.Length; j++)
//                {
//                    if((ordenarMenor == true && datos[i] > datos[j]) || (ordenarMenor == false && datos[i] < datos[j]))
//                    {
//                        aux = datos[i];
//                        datos[i] = datos[j];
//                        datos[j] = aux;   
//                    }
//                }
//            }
//            return datos;
//        }
//        public static int[] OrdenarMayor(int[] datos)
//        {
//            //arrays ordenados de mayor a menor
//            int aux;
//            for (int i = 0; i < datos.Length; i++)
//            {
//                for (int j = i + 1; j < datos.Length; j++)
//                {
//                    if (datos[i] < datos[j])
//                    {
//                        aux = datos[i];
//                        datos[i] = datos[j];
//                        datos[j] = aux;
//                    }
//                }
//            }
//            return datos;
//        }
//    }
//}
//*****************************
//namespace Ejercicio_Vectores_6
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] misNumeros = CargarArrayDeEnteros(8);

//            OrdenarNegativosCreciente(misNumeros);
//            OrdenarPositivosDecreciente(misNumeros);
//            MostrarVector("Vector ordenado:", misNumeros);

//        }
//        public static int[] CargarArrayDeEnteros(int cantidad)
//        {
//            int[] numeros = new int[cantidad];
//            for (int i = 0; i < cantidad; i++)
//            {
//                numeros[i] = PedirEntero($"Ingrese el número {i + 1} de {cantidad}: ", "El dato ingresado no es un número");
//            }
//            return numeros;
//        }
//        public static int PedirEntero(string mensaje, string mensajeError)
//        {
//            int numeroValido;
//            string numeroLeido;
//            do
//            {
//                Console.Write(mensaje);
//                numeroLeido = Console.ReadLine();
//            } while (!int.TryParse(numeroLeido, out numeroValido));

//            return numeroValido;
//        }
//        public static void MostrarVector(string mensaje, int[] vector)
//        {
//            Console.WriteLine(mensaje);
//            foreach (int numero in vector)
//            {
//                Console.Write(numero + " ");
//            }
//            Console.WriteLine();
//        }
//        public static void OrdenarNegativosCreciente(int[] vector)
//        {
//            for (int i = 0; i < vector.Length; i++)
//            {
//                if (vector[i] < 0)
//                {
//                    for (int j = i + 1; j < vector.Length; j++)
//                    {
//                        if (vector[j] < 0 && vector[j] < vector[i])
//                        {
//                            int temp = vector[i];
//                            vector[i] = vector[j];
//                            vector[j] = temp;
//                        }
//                    }
//                }
//            }
//        }

//        public static void OrdenarPositivosDecreciente(int[] vector)
//        {
//            for (int i = 0; i < vector.Length; i++)
//            {
//                if (vector[i] >= 0)
//                {
//                    for (int j = i + 1; j < vector.Length; j++)
//                    {
//                        if (vector[j] >= 0 && vector[j] > vector[i])
//                        {
//                            int temp = vector[i];
//                            vector[i] = vector[j];
//                            vector[j] = temp;
//                        }
//                    }
//                }
//            }
//        }
//    }
//}
//************************
namespace Ejercicio_Vectores_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] misNumeros = CargarArrayDeEnteros(8);

            OrdenarPorCriterio(misNumeros, true);
            MostrarPorCriterio("Positivos en forma creciente", misNumeros, true);

            OrdenarPorCriterio(misNumeros, false);
            MostrarPorCriterio("Negativos en forma decreciente", misNumeros, false);
        }
        public static int[] CargarArrayDeEnteros(int cantidad)
        {
            int[] numeros = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = PedirEntero($"Ingrese el nunero {i + 1} de {cantidad}: ", "El dato ingresado no es un numero");
            }
            return numeros;
        }
        public static int PedirEntero(string mensaje, string mensajeError)
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
        public static string PedirCadena(string mensaje)
        {
            Console.Write(mensaje);
            return Console.ReadLine();
        }
        //Método MostrarPorCriterio: Este método recibe un mensaje para
        //mostrar por pantalla, un array de enteros y un booleano
        //que determina si se deben mostrar los números positivos o negativos.
        //Luego, itera sobre cada número en el array y muestra aquellos
        //que cumplen con el criterio especificado.
        public static int[] MostrarPorCriterio(string mensaje, int[] vector, bool mostrarPositivo)
        {//Forma simplificada
            Console.WriteLine(mensaje);
            foreach (int numero in vector)
            {
                if ((mostrarPositivo == true && numero > 0) || (mostrarPositivo == false && numero < 0))
                {
                    Console.WriteLine(numero); //muestra el numero
                }
            }
            return vector;
        }
        //Método OrdenarPorCriterio: Este método recibe un array de enteros
        //y un booleano que indica si se debe ordenar de menor a mayor (true)
        //o de mayor a menor (false). Utiliza un algoritmo de ordenación
        //por burbuja para ordenar el array según el criterio especificado.
        public static int[] OrdenarPorCriterio(int[] datos, bool ordenarMenor)
        {//Forma mas simple
            //arrays ordenados de menor a mayor
            int aux;
            for (int i = 0; i < datos.Length; i++)
            {
                for (int j = i + 1; j < datos.Length; j++)
                {
                    if ((ordenarMenor == true && datos[i] > datos[j]) || (ordenarMenor == false && datos[i] < datos[j]))
                    {
                        aux = datos[i];
                        datos[i] = datos[j];
                        datos[j] = aux;
                    }
                }
            }
            return datos;
        }
    }
}


