namespace Ejercicio_4
//4.Ingresar 5 números enteros, calcular y mostrar el promedio.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int numero3;
            int numero4;
            int numero5;
            float promedio;

            Console.WriteLine("Ingresar 1° numero entero : ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar 2° numero entero : ");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar 3° numero entero : ");
            numero3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar 4° numero entero : ");
            numero4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar 5° numero entero : ");
            numero5 = int.Parse(Console.ReadLine());

            promedio = (numero1 + numero2 + numero3 + numero4 + numero5) / 5;

            Console.WriteLine("El promedio de los numeros es: " + promedio);
        }
    }
}
