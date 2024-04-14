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
    }
}

