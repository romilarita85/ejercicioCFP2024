//using PrimerEvaluacionAuto;
//using System.Drawing;
//namespace TesteoPrimerEvaluacion
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Auto miAuto = new Auto("Ford", 1000, Color.Coral);
         
//            Console.WriteLine(miAuto.AutoToString());

//            int repeticiones = 0; //Contador

//            while (miAuto.Avanzar(50))
//            {
//                repeticiones++;
//            }
//            Console.WriteLine("El auto agoto su combustible.");
//            Console.WriteLine($"En total logro realizar {repeticionesRealizadas} repeticiones.");
//        }
//    }
//}
//***********************Otra forma de resolverlo**********************
using PrimerEvaluacionAuto;
using System.Drawing;
namespace TesteoPrimerEvaluacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto miAuto = new Auto("Toyota", 65, Color.Coral);
            int repeticiones = 0; //Contador
            int kmDeseado = 8;
            int cantKmRecorridos = 0; 

            miAuto.SetColor(Color.DarkGreen);
            Console.WriteLine(miAuto.GetCantCombustible());

            Console.WriteLine(miAuto.AutoToString());

            while (miAuto.Avanzar(kmDeseado))
            {
                cantKmRecorridos += kmDeseado;//cantKmRecorridos = cantKmRecorridos + kmDeseado;
                repeticiones++;
            }
           
            Console.WriteLine($"El auto agoto su combustible y logro realizar {repeticiones} repeticiones, recorriendo {cantKmRecorridos} km.");
        }
    }
}

