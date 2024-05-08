using Biblioteca_Colectivo;//le digo q utilice todo lo que esta en mi biblioteca
namespace Testeo_Colectivo
{
    internal class Program//crear todo lo que sea de nuestra clase
    {
        static void Main(string[] args)
        {
            //**********************************
            //Colectivo colectivo1;//Declaracion de la variable tipo de colectivo
            //colectivo1 = new Colectivo("AD123BC", 85, "MONSA", 50, "Lanus", "Retiro");
            //// por medio de la palabra reservada new y el constructor creo una nueva instancia de mi clase
            //string info;
            //info = colectivo1.ColectivoToString();
            //Console.WriteLine(info);
            //**************************************
            Colectivo colectivo1 = new Colectivo("AD123BC", 85, "MONSA", 50, "Lanus", "Retiro");
            Colectivo colectivo2 = new Colectivo("AD123BC", 07, "MONSA", 50, "Lanus", "Retiro");
            Colectivo colectivo3 = new Colectivo("AD123BC", 22, "MONSA", 50, "Lanus", "Retiro");
            Colectivo colectivo4 = new Colectivo("AD123BC", 85, "MONSA", 50, "Lanus", "Retiro");
            Colectivo colectivo5 = new Colectivo("AD123BC", 85, "MONSA", 50, "Lanus", "Retiro");
            do
            {
                Console.WriteLine("Ingrese la cantidad de pasajeros: ");

                if (colectivo1.SubirPasajeros(int.Parse(Console.ReadLine())))
                {
                    Console.WriteLine("puede subir");

                }
                else
                {
                    Console.WriteLine("no hay mas espacio");
                }

            } while (true);
        }
    }
}
   

