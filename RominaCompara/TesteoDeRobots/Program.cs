//using LibreriaDeRobots;
//using System.Drawing;
//namespace TesteoDeRobots
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //Creo mis robots
//            Robot r1 = new Robot("robotito", 50, 30);
//            Robot r2 = new Robot("chat", 20, 15);
//            Robot r3 = new Robot("bestia", 100, 90);
//            Robot r4 = new Robot("robotito2", 5, 3);
//            Robot r5 = new Robot("mazinger", 500, 150);

//            //uso console para mostrar todos los valores
//            //metodo->robottostring
//            Console.WriteLine(r1.RobotToString());
//            Console.WriteLine(r2.RobotToString());
//            Console.WriteLine(r3.RobotToString());
//            Console.WriteLine(r4.RobotToString());
//            Console.WriteLine(r5.RobotToString());


//            r3.RecibirDanio(r1.Atacar());
//            Console.WriteLine(r3.GetVida());

//            //Robot.MostrarNombreFabrica();}
//            //Cambio de Colores
//            //if (r3.SetColor(Color.Blue))
//            //{
//            //    Console.WriteLine("Color cambiado con exito");
//            //}
//            //else
//            //{
//            //    Console.WriteLine("No es un color permitido ");
//            //}
//            //Console.WriteLine(r3.RobotToString());

//        }
//    }
//}
using LibreriaDeRobots;
using System.Drawing;
namespace TesteoDeRobots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot r1 = new Robot("robotito", 50, 30);
            Robot r3 = new Robot("bestia", 100, 90);

            int dañoEmitido;
            int round = 1;

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"**********   ROUND {round}°   ************");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{r3.GetNombre()} tiene {r3.GetVida()} puntos de vida");
                Console.WriteLine($"La resistencia de {r3.GetNombre()} es de {r3.Getresistencia()} puntos");
                dañoEmitido = r1.Atacar();
                Console.WriteLine($"{r1.GetNombre()} lanzo un golpe de: {dañoEmitido}");
                r3.RecibirDanio(dañoEmitido);
                Console.WriteLine($"{r3.GetNombre()} quedo con {r3.GetVida()} puntos de vida");


                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{r1.GetNombre()} tiene {r1.GetVida()} puntos de vida");
                Console.WriteLine($"La resistencia de {r1.GetNombre()} es de {r1.Getresistencia()} puntos");
                dañoEmitido = r3.Atacar();
                Console.WriteLine($"{r3.GetNombre()} lanzo un golpe de: {dañoEmitido}");
                r1.RecibirDanio(dañoEmitido);
                Console.WriteLine($"{r1.GetNombre()} quedo con {r1.GetVida()} puntos de vida");


                round++;
            } while ((r3.GetVida() > 0 && r1.energia > 0) && (r1.GetVida() > 0 && r3.energia > 0));


            Console.ForegroundColor = ConsoleColor.White;
            if (r3.GetVida() > r1.GetVida())
            {
                Console.WriteLine($"El ganador es {r3.GetNombre()}");
            }
            else
            {
                Console.WriteLine($"El ganador es {r1.GetNombre()}");
            }
        }
    }
}