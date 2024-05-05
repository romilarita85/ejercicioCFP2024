//Ejercicio 1:
//Pedir el ingreso de una palabra, verificar que por lo menos tenga 5 caracteres
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
            } while (palabras.Length < 5);


            for (int i = 0; i < 3; i++) 
            {
                Console.Write(palabras[i]);
            }

        }
    }
}
//Inicio del programa: El método Main es el punto de entrada del programa.
//Bucle do-while para ingresar una palabra válida: El programa utiliza un bucle do-while para solicitar continuamente al usuario que ingrese una palabra hasta que la palabra ingresada tenga más de 5 caracteres. Dentro del bucle, se muestra un mensaje pidiendo al usuario que ingrese una palabra y se lee la entrada del usuario utilizando Console.ReadLine(). Si la longitud de la palabra es menor que 5, se muestra un mensaje de error.
//Impresión de los primeros 3 caracteres: Después de que se ha ingresado una palabra válida, el programa utiliza un bucle for para imprimir los primeros 3 caracteres de la palabra ingresada. El bucle se ejecuta tres veces (i < 3) e imprime el carácter en la posición i de la palabra.
//Este código asegura que el usuario ingrese una palabra con más de 5 caracteres y luego imprime los primeros 3 caracteres de esa palabra.