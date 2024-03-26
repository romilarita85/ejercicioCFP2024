namespace Ejercicio_3
//3.Ingresar 2 números y mostrar la suma de los mismos.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroUno;
            int numeroDos;
            int resultado;

            Console.WriteLine("Ingrese un numero: ");
            numeroUno = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero: ");
            numeroDos = int.Parse(Console.ReadLine());

            resultado = numeroUno + numeroDos;


            Console.WriteLine("La suma de los numeros es: " + resultado);


        }
    }
}
