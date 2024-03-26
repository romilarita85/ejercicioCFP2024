namespace Ejercicio_2
//2.	Ingresar el nombre, apellido y edad por consola.

{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            String apellido;
            int edad;
            String edadTexto;

            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido: ");
            apellido = Console.ReadLine();

            Console.WriteLine("Ingrese su edad: ");
            edadTexto = Console.ReadLine();
            edad = int.Parse(edadTexto);

            Console.WriteLine("Bienvenido/a " + nombre + " " + apellido + " Usted tiene " + edad + " años .");

        }
    }
}
