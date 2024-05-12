//Ejercicio_String_4:
//Del string 0000001234500000000 conseguir quedarse con el string 12345 
// y mostrarlo por pantalla.
namespace Ejercicio_Strings_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra = "0000001234500000000";
            Console.WriteLine(palabra.Trim('0'));
        }
    }
}
