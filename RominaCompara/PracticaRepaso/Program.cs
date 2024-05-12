namespace PracticaRepaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            string edadEnTexto;

            Console.Write("Ingrese su edad: ");

            edad = int.Parse(Console.ReadLine());
            Console.WriteLine($"Edad parseada de string a int {edad} edad es de tipo: {edad.GetType()} ");

            edadEnTexto = edad.ToString();
            Console.WriteLine($"Edad parseada de int a string {edadEnTexto} edad es de tipo: {edadEnTexto.GetType()}");

        }
    }
}
