//Ejercicio_Strins 2:
//Pedir el ingreso de una palabra y mostrarla con todos sus caracteres
//separados por un guión. ej: Montaña->M - o - n - t - a - ñ - a.
//---------------------------------------------------------------
//namespace Ejercicio_Strings_2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string palabras;
//            Console.WriteLine("Escriba una palabra: ");
//            palabras = Console.ReadLine();
            
//            for (int i = 0; i < palabras.Length; i++)
//            {
//                Console.Write($"{palabras[i]} -");
//            }
//        }
//    }
//}
namespace Ejercicio_Strings_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabras;
            Console.WriteLine("Escriba una palabra: ");
            palabras = Console.ReadLine();

            for (int i = 0; i < palabras.Length; i++)
            {
                Console.Write(palabras[i]);
                Console.Write("-");
            }
        }
    }
}
