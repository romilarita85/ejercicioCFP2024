//SWITCH = (segun) Condicional multiple
//Sabe de entrada que valores voy a asumir. 
//toma multiples valores de una variable
namespace Repaso_Segun_SWITCH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String color;
            color = "verde";
            // o String color = "verde";
            switch (color) //no puede evaluar mas de una opcion
            {
                case "rojo":
                    Console.WriteLine("no puede avanzar"); //siempre arriba del break
                    break;
                case "amarillo":
                    Console.WriteLine("precaucion");
                    break;
                case "verde":
                    Console.WriteLine("puede avanzar");
                    break;
                default:
                    Console.WriteLine("no es un color valido del semaforo");
                    break;












            }


        }
    }
}
