//Ejercicio_Vectores_5:
//Ingresar datos en un vector y mostrarlos al revés.
namespace Ejercicio_Vectores_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] misNumeros = CargarArrayDeEnteros(5);

            ImprimirArray("****elementos del array misNumeros****", misNumeros);
            Array.Reverse(misNumeros);
            ImprimirArray("****elementos del array misNumeros al reves****", misNumeros);
        }
        static int[] CargarArrayDeEnteros(int cantidad)//lo que recibe-parametros
        {
            int[] numeros = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = PedirEntero($"Ingrese el nunero {i + 1} de {cantidad}: ", "El dato ingresado no es un numero");
            }
            return numeros;
        }
        static int PedirEntero(string mensaje, string mensajeError)
        {
            int numeroValido;
            string numeroLeido;
            numeroLeido = PedirCadena(mensaje);

            while (!int.TryParse(numeroLeido, out numeroValido))
            {
                Console.WriteLine(mensajeError);
                numeroLeido = PedirCadena(mensaje);
            }
            return numeroValido;
        }
        static string PedirCadena(string mensaje)
        {
            Console.Write(mensaje);
            return Console.ReadLine();
        }
        static void ImprimirArray(string titulo, int[] misNumeros)
        {
            Console.WriteLine(titulo);
            foreach (int numero in misNumeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
