//Ejercicio 1: Pedir el ingreso de una palabra, verificar que por lo menos tenga 5 caracteres
//de no ser así informar, luego mostrar los primeros 3 caracteres.
//ej: zapallo->zap
namespace Ejercicio_Strings_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabras;
  
            do
            {
                Console.WriteLine("Ingrese una palabra con mas de 5 caracteres: ");
                palabras = Console.ReadLine();

                if (palabras.Length < 5)
                {
                    Console.WriteLine("La palabra ingresada tiene menos de 5 caracteres");

                }
            } while (palabras.Length<5);


            for (int i = 0; i < 3; i++) 
            {
                Console.Write(palabras[i]);
            }

        }
    }
}
