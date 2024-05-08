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
            Colectivo colectivo2 = new Colectivo("CD456BC", 07, "CAT", 45, "Lanus", "Retiro");
            Colectivo colectivo3 = new Colectivo("SC853BC", 22, "SUR", 30, "Lomas", "Avellaneda");
            Colectivo colectivo4 = new Colectivo("MN201BC", 285, "RAPIDO", 50, "Constitucion", "Recoleta");
            Colectivo colectivo5 = new Colectivo("LO741BC", 458, "NORTE", 65, "Once", "Barracas");
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
   

