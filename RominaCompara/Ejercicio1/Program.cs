namespace Ejercicio_1.C_
//1.Ingresar el nombre y apellido por consola.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            String apellido;

            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido: ");
            apellido = Console.ReadLine();

            Console.WriteLine("Bienvenido/a " + nombre + " " + apellido);
        }
    }
}

