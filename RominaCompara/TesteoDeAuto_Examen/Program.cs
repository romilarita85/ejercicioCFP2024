//Crear la clase de instancia Auto.
//La misma debe tener:
//A.Los atributos marca, cantCombustible, color.
//B. un constructor que inicialice todos los atributos.
//C. Solo metodos Get() para todos sus atributos.
//D. El metodo AutoToString(), este metodo debe retornar un string con toda su informacion.
//E. El metodo Avanzar(int km) que retornara un booleano para informar si pudo recorrer o no la cantidad de kilometros recibo por parametro, tener en cuenta que para poder avanzar se debe tener conbustible y por cada litro de combustible se pueden 10km.
//F. En un proyecto de consola crear un objeto del tipo Auto,mostrar todos su valores
// y dentro de un bucle repetitivo usar el metodo avanzar(),
//este debera repetirse hasta que el auto agote su combustible y se debera informar
//cuantas repeticiones logra realizar.
using System.Drawing;
using Libreria_Autos;
namespace TesteoDeAuto_Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto autoUno = new Auto("Ford",1000, Color.Green);
            Console.WriteLine("Los valores del auto son: ");
            Console.WriteLine(autoUno.AutoToString());

            int repeticionesRealizadas = 0; //Contador
            
            while (autoUno.Avanzar(50))
            {
                repeticionesRealizadas++;
            }
            Console.WriteLine("El auto agoto su combustible.");
            Console.WriteLine($"En total logro realizar {repeticionesRealizadas} repeticiones.");
        }
    }
}
