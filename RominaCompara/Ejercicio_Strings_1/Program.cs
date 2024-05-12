//Ejercicio_String_1:
//Pedir el ingreso de una palabra, verificar que por lo menos tenga 5 caracteres
//de no ser así informar, luego mostrar los primeros 3 caracteres.
//ej: zapallo->zap
//
namespace Ejercicio_Strings_1//Inicio del programa: El método Main es el punto de entrada del programa.
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
//1-Inicio del programa:
//El programa comienza solicitando al usuario que ingrese una palabra con más de 5 caracteres.

//2-Entrada de usuario:
//El usuario ingresa una palabra mediante la consola.
//La palabra ingresada se guarda en la variable palabra.

//3-Validación de la longitud de la palabra:
//Se comprueba si la longitud de la palabra ingresada es menor que 5 caracteres.
//Si la longitud es menor que 5, se muestra un mensaje de advertencia indicando que la palabra es demasiado corta.

//4-Repetición hasta que se ingrese una palabra válida:
//El bucle do-while se ejecuta mientras la longitud de la palabra ingresada sea menor que 5 caracteres.
//Si la palabra ingresada tiene menos de 5 caracteres, se solicita nuevamente al usuario que ingrese una palabra.

//5-Finalización del bucle:
//Una vez que el usuario ingresa una palabra con al menos 5 caracteres, el bucle do-while finaliza.
//6-Mostrar los primeros tres caracteres de la palabra:

//Se inicia un bucle for para iterar sobre los primeros tres caracteres de la palabra ingresada.
//En cada iteración, se muestra un carácter de la palabra en la consola.

//7-Fin del programa:
//El programa termina después de mostrar los primeros tres caracteres de la palabra ingresada.
//Este enfoque garantiza que el programa solicite al usuario que ingrese una palabra con al
//menos 5 caracteres y solo proceda a mostrar los primeros tres caracteres de esa palabra
//una vez que se haya ingresado una palabra válida.
