//Genero sea hombre
//Edad sea mayor o igual a 18
using Biblioteca_PracticaRepaso;
namespace PracticaRepaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            string genero = "mujer";
            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine());   

            if (edad < 18 && genero == "mujer")
            {
                Console.WriteLine("Es una mujer menor de edad");    
            }
            else 
            {
                Console.WriteLine("Es mayor de edad y no es mujer(es hombre)");

            }


        }

    }
}
