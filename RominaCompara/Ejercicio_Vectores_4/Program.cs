//Ejercicio_Vectores_4:
//Crear un menú de opciones que permita:
//a.Cargar un array de caracteres. Recomendación: utilizar el método toCharArray().
//b.Ordenar vector.
//c.Contar vocales dentro del vector. (Cuantas a, e, i, o y u)
//d.Reemplazar consonantes por el carácter ‘*’ y mostrar
using System.Numerics;
namespace Ejercicio_Vectores_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("Menú de opciones:");
                Console.WriteLine("a. Cargar un array de caracteres.");
                Console.WriteLine("b. Ordenar vector.");
                Console.WriteLine("c. Contar vocales dentro del vector.");
                Console.WriteLine("d. Reemplazar consonantes por '*'.");
                Console.WriteLine("e. Salir.");

                Console.Write("Seleccione una opción: ");
                char opcion = Console.ReadLine().ToLower()[0];

                
            }

        }
        
    }
}
