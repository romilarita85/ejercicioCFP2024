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
            Console.WriteLine(palabra.Trim('0')); // me saca tods los ceros
            //Console.WriteLine(palabra.TrimStart('0')); // me saca los primeros ceros
            //Console.WriteLine(palabra.TrimEnd('0')); // me saca los ultimos ceros
        }
    }
}
