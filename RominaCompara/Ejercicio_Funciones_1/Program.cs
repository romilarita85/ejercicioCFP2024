//Ejercicio_Funciones_1:	
//Crear una función que evalúe si una palabra es corta o larga.
//Se considera larga si tiene más de 8 caracteres.
//La función debe recibir un parámetro de tipo cadena (string)
//y su retorno debe ser booleano.

using System;

namespace Ejercicio_Funciones_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            string palabraLarga;
            string palabraCorta;
            Console.WriteLine("Escriba una palabra: ");
            palabra = Console.ReadLine();

            char[] letras = palabra.ToCharArray();

        }
        static string MostrarPalabra(string mensaje) 
        {
            string palabra;
            do
            {
                Console.WriteLine("Ingrese una palabra con mas de 8 caracteres: ");
                palabra = Console.ReadLine();

                if (palabra.Length < 8)
                {
                    Console.WriteLine("La palabra ingresada es corta tiene menos de 8 caracteres");
                }
            } while (palabra.Length < 8);
            return palabra;
            static bool EsLarga(string palabra)
            {
                return palabra.Length > 8;
            }
        }

    }
}

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Ejemplos de uso
//        Console.WriteLine(EsLarga("corta"));        // False
//        Console.WriteLine(EsLarga("larguísima"));   // True
//        Console.WriteLine(EsLarga("mediana"));     // False
//    }

//    static bool EsLarga(string palabra)
//    {
//        return palabra.Length > 8;
//    }
//}