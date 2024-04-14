//Ejercicio_Funciones_2:	
//Crear una función que determine si el número recibido por parámetro es primo o no.

namespace Ejercicio_Funciones_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número para determinar si es primo o compuesto");
            Console.ReadLine(NumeroIngresado);
            int i;
            int num = Convert.ToInt32(Console.ReadLine());

            
        }
        static int[] NumeroIngresado(int num) 
        { 
            for (i = 2; i < num; i++)
            { 
                if (num % i != 0)
                {
                Console.WriteLine("Es primo");
                }
                else
                {
                Console.WriteLine("No es primo");
                }

            }
        }
    }
}
