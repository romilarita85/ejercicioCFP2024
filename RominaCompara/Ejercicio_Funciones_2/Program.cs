//Ejercicio_Funciones_2:	
//Crear una función que determine si el número recibido por parámetro es primo o no.

namespace Ejercicio_Funciones_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese un número:");
            int numero = int.Parse(Console.ReadLine());

           
            //Luego Llamar a la función para determinar si el número es primo o no

            if (NumEsPrimo(numero))
            {
                Console.WriteLine("El número ingresado es primo.");
            }
            else
            {
                Console.WriteLine("El número ingresado no es primo.");
            }
            //Primero debo crear la funcion abajo del main
            //Creo función para determinar si un número es primo

            static bool NumEsPrimo(int numero) //primo= divisible por 2
            {
                // Verificar si el número es menor o igual a 1
                if (numero <= 1)
                {
                    return false;
                }

                // Verificar si el número es divisible por algún número entre 2 y la mitad de su valor
                for (int i = 2; i <= numero / 2; i++)
                {
                    if (numero % i == 0)
                    {
                        return false;
                    }
                }

                // Si no se encontró ningún divisor, el número es primo
                return true;
            }
        }
        
    }
}



    

