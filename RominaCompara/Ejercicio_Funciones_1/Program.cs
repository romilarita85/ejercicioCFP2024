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
            Console.WriteLine("Ingrese una palabra:");
            string palabra = Console.ReadLine();

            // Llamar a la función para determinar si la palabra es corta o larga
            if (PalabraLarga(palabra))
            {
                Console.WriteLine("La palabra ingresada es larga.");
            }
            else
            {
                Console.WriteLine("La palabra ingresada es corta.");
            }

        }
        //Función para determinar si una palabra es larga (más de 8 caracteres)
        //La función debe:
        //-recibir un parámetro de tipo cadena (string)
        //-y su retorno debe ser booleano.
        static bool PalabraLarga(string palabra)
        {
            return palabra.Length > 8;
        }

    }
}
