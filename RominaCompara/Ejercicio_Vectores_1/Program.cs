//Ejercicio_Vectores_1:
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;

using System.Drawing;

///Cargar un vector de enteros de 5 elementos y mostrarlo.
namespace ejercicio_vectores_1
{
    internal class program
    {
        static void main(string[] args)
        {
            int[] misNumeros = CargarArrayDeEnteros(5);
            foreach (int numero in misNumeros)
            {
                Console.WriteLine(numero);
            }
        }
        static int[] CargarArrayDeEnteros(int cantidad)//lo que recibe-parametros
        {
            //cantidad es un parámetro de tipo int que indica la cantidad de elementos
            //que se van a cargar en el arreglo.
            int[] numeros = new int[cantidad];//declara un nuevo arreglo de enteros
                                              //llamado numeros con una longitud igual a cantidad.
            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = PedirEntero($"ingrese el nunero {i + 1} de {cantidad}: ", "el dato ingresado no es un numero");
            }//En cada iteración del bucle for, se llama a la función PedirEntero
             //para solicitar al usuario un número.
            return numeros;
        }

        static int PedirEntero(string mensaje, string mensajeError)
        {
            //mensaje es una cadena que se mostrará al usuario para solicitar un número.
            //mensajeError es una cadena que se mostrará al usuario
            //si el valor ingresado no es un número válido.
            int numeroValido;
            string numeroLeido; //Esto declara una variable de tipo string llamada numeroLeido.
            numeroLeido = PedirCadena(mensaje);//llama a la función PedirCadena
                                               //para solicitar al usuario una cadena,
                                               //utilizando el mensaje proporcionado como parámetro.
                                               //El valor devuelto por PedirCadena se asigna a la variable numeroLeido.

            while (!int.TryParse(numeroLeido, out numeroValido))
            {//Este es un bucle while que se ejecuta mientras el intento de convertir
             //numeroLeido en un entero utilizando int.TryParse sea fallido.
                Console.WriteLine(mensajeError);
                //Si la conversión falla, el mensaje de error se muestra al usuario,
                //y luego se solicita una nueva entrada utilizando PedirCadena.
                numeroLeido = PedirCadena(mensaje);
            }
            return numeroValido;
        }
        //Funcion para solicitar al usuario una cadena de texto
        //y que devuelva la cadena ingresada.
        static string PedirCadena(string mensaje)
        {
            Console.Write(mensaje);
            return Console.ReadLine();
        }
    }
}
//-int.TryParse() es un método que intenta analizar una cadena para convertirla
//en un número entero. Retorna true si la conversión fue exitosa y false si no lo fue.
//El parámetro out permite devolver el resultado de la conversión,
//si es exitosa, mediante una variable.

//-while (!int.TryParse(numeroLeido, out numeroValido)) significa
//que el ciclo while se ejecutará mientras la conversión de la cadena numeroLeido
//a un número entero no sea exitosa.
//-El signo ! antes de int.TryParse() indica negación,
//lo que significa que el ciclo continuará mientras int.TryParse() retorne false,
//es decir, mientras la conversión falle. Una vez que la conversión tenga éxito,
//el ciclo while se detendrá.
//*****************************************************************************+
//namespace ejercicio_vectores_1
//{
//    internal class program
//    {
//        static void Main(string[] args)
//        {
//            int[] vector = new int[5]; // Declaración de un vector de enteros con 5 elementos

//            // Ciclo para cargar los valores en el vector
//            for (int i = 0; i < 5; i++)
//            {
//                Console.Write($"Ingrese el valor del elemento {i + 1}: ");
//                string input = Console.ReadLine(); // Leer la entrada del usuario como cadena
//                while (!int.TryParse(input, out vector[i])) // Intentar convertir la entrada en un entero
//                {
//                    Console.Write("Entrada inválida. Por favor, ingrese un número entero: ");
//                    input = Console.ReadLine(); // Leer la entrada nuevamente si la conversión falla
//                }
//            }

//            // Mostrar el vector
//            Console.WriteLine("El vector ingresado es:");
//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine($"Elemento {i + 1}: {vector[i]}");
//            }

//            Console.ReadLine(); // Esperar a que el usuario presione Enter antes de cerrar la consola
//        }
//    }
//}