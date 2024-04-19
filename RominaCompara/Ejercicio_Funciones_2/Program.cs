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

//-----------------------------
//using System;

//class Program
//{
//    static bool EsPrimo(int numero)
//    {
//        if (numero <= 1)
//            return false;

//        for (int i = 2; i <= Math.Sqrt(numero); i++)
//        {
//            if (numero % i == 0)
//                return false;
//        }

//        return true;
//    }

//    static void Main(string[] args)
//    {
//        int numero = 17; // Puedes cambiar el número aquí para probar
//        if (EsPrimo(numero))
//            Console.WriteLine(numero + " es primo.");
//        else
//            Console.WriteLine(numero + " no es primo.");
//    }
//}
