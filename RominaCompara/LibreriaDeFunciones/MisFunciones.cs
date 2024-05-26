//Clase 10-04-24************************************************************************
using System;
using System.Runtime.Intrinsics.X86;

namespace LibreriaDeFunciones
{
    public class MisFunciones
    {
        public static int[] CargarArrayDeEnteros(int cantidad)
        {
            int[] numeros = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = PedirEntero($"Ingrese el nunero {i + 1} de {cantidad}: ", "El dato ingresado no es un numero");
            }
            return numeros;
        }
        //-----------
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
        //---------------
        public static void ImprimirArray(string titulo, int[] misNumeros)
        {
            Console.WriteLine(titulo);
            foreach (int numero in misNumeros)
            {
                Console.WriteLine(numero);
            }
        }
        public static int SumaValoresArrayEnteros(int[] misNumeros)
        {
            int suma = 0;
            foreach (int numero in misNumeros)
            {
                suma += numero;
            }
            return suma;
        }
        public static double CalcularPromedioArrayEnteros(int[] misNumeros)
        {
            int suma = 0;
            double resultado;
            foreach (int numero in misNumeros)
            {
                suma += numero;
            }
            resultado = (double)suma / misNumeros.Length;
            return resultado;
        }
        public static void ImprimirArrayAlreves(string titulo, int[] misNumeros) 
        {
            Array.Reverse(misNumeros);
            Console.WriteLine(titulo);
            foreach (int numero in misNumeros)
            {
                Console.WriteLine(numero);
            }
        }
        //-------------------------
        //public static int[] OrdenarMenor(int[] datos)
        //{
        //    //arrays ordenados de menor a mayor
        //    int aux;
        //    for (int i = 0; i < datos.Length; i++)
        //    {
        //        for (int j = i + 1; j < datos.Length; j++)
        //        {
        //            if (datos[i] > datos[j])
        //            {
        //                aux = datos[i];
        //                datos[i] = datos[j];
        //                datos[j] = aux;
        //            }
        //        }
        //    }
        //    return datos;
        //}
        //public static int[] OrdenarMayor(int[] datos)
        //{
        //    //arrays ordenados de mayor a menor
        //    int aux;
        //    for (int i = 0; i < datos.Length; i++)
        //    {
        //        for (int j = i + 1; j < datos.Length; j++)
        //        {
        //            if (datos[i] < datos[j])
        //            {
        //                aux = datos[i];
        //                datos[i] = datos[j];
        //                datos[j] = aux;
        //            }
        //        }
        //    }
        //    return datos;
        //}
        public static int[] OrdenarPorCriterio(int[] datos, bool ordenarMenor)
        {//Forma mas simple
            //arrays ordenados de menor a mayor
            int aux;
            for (int i = 0; i < datos.Length; i++)
            {
                for (int j = i + 1; j < datos.Length; j++)
                {
                    if((ordenarMenor == true && datos[i] > datos[j]) || (ordenarMenor == false && datos[i] < datos[j]))
                    {
                        aux = datos[i];
                        datos[i] = datos[j];
                        datos[j] = aux;   
                    }
                }
            }
            return datos;
        }
        public static int[] OrdenarMayor(int[] datos)
        {
            //arrays ordenados de mayor a menor
            int aux;
            for (int i = 0; i < datos.Length; i++)
            {
                for (int j = i + 1; j < datos.Length; j++)
                {
                    if (datos[i] < datos[j])
                    {
                        aux = datos[i];
                        datos[i] = datos[j];
                        datos[j] = aux;
                    }
                }
            }
            return datos;
        }
//--------------------------------
        //public static int[] MostrarPorCriterio(string mensaje, int[] vector, bool mostrarPositivo)
        //{
        //    Console.WriteLine(mensaje);
        //    foreach (int numero in vector)
        //    {
        //        if (mostrarPositivo == true) 
        //        {
        //            if (numero > 0) 
        //            {
        //                Console.WriteLine(numero); //muestra el numero
        //            }
        //        }
        //    }
        //    foreach (int numero in vector)
        //    {
        //        if (mostrarPositivo == false)
        //        {
        //            if (numero < 0) 
        //            {
        //                Console.WriteLine(numero);
        //            }
        //        }
        //    }
        //    return vector;
        //}
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
        public static int PedirEnteroConRango(string mensaje, string mensajeError, int maximo, int minimo)
        {
            int numeroValido = 0;
            string numeroLeido;
            Console.Write(mensaje);
            numeroLeido = Console.ReadLine();

            while (!EsNumerico(numeroLeido) || (int.Parse(numeroLeido) > maximo) || (int.Parse(numeroLeido) < minimo))
            {
                Console.WriteLine(mensajeError);
                Console.Write(mensaje);
                numeroLeido = Console.ReadLine();
            }
            numeroValido = int.Parse(numeroLeido);
            return numeroValido;
        }
        //Uso funcion en formulario/primeraEvaluacion*********************************************************
        //Usando funcion booleano: responde a lo que tenia por parametro. Si es un numero o no
        public static bool EsNumerico(string dato) //Ingreso una cadena de caracteres                                 
        {//evalua si los datos son un digito
            bool esNumerico = true;
            foreach (char digito in dato)
            {
                if (!char.IsDigit(digito))
                {
                    esNumerico = false;
                    break;
                }
            }
            return esNumerico;
        }
        //******************************************************************+
        //Funcion creada para formulario/PrimeraEvaluacion
        public static bool EsSoloLetras(string dato) 
        {
            bool esLetra = true;
            foreach (char letra in dato)
            {
                if (!char.IsLetter(letra))
                {
                    esLetra = false;
                    break;
                }
            }
            return esLetra;
        }
        //***************************************************************************************************************
        public static bool EsPar(int numero)
        {
            bool esPar = false; //variable booleana que me diga que es par

            if (numero % 2 == 0)
            {
                esPar = true;
            }
            return esPar;
        }
    }
}

