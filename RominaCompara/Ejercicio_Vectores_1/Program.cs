//Ejercicio_Vectores_1:
///Cargar un vector de enteros de 5 elementos y mostrarlo.
namespace ejercicio_vectores_1
{
    internal class program
    {
        static void main(string[] args)
        {
            int[] misnumeros = CargarArrayDeEnteros(5);
            foreach (int numero in misnumeros)
            {
                Console.WriteLine(numero);
            }
        }
        static int[] CargarArrayDeEnteros(int cantidad)//lo que recibe-parametros
        {
            int[] numeros = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = PedirEntero($"ingrese el nunero {i + 1} de {cantidad}: ", "el dato ingresado no es un numero");
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
    }
}