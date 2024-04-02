//Ejercicio 1: Pedir el ingreso de una palabra, verificar que por lo menos tenga 5 caracteres
//de no ser así informar, luego mostrar los primeros 3 caracteres.
//ej: zapallo->zap
using System.ComponentModel.Design;

namespace Ejercicio_Strings_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabras;
            int largo;
            string[] arrayPalabras = new string[5];

            largo = arrayPalabras.Length;

            Console.WriteLine("Ingrese una palabra");
            palabras = Console.ReadLine();

            for (int i = 0; i < arrayPalabras.Length; i++) 
            {
                Console.WriteLine(arrayPalabras[i]);

            }

        }
    }
}
