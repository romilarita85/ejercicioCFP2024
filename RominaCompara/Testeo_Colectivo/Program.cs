using Biblioteca_Colectivo;//le digo q utilice todo lo que esta en mi biblioteca
namespace Testeo_Colectivo
{
    internal class Program//crear todo lo que sea de nuestra clase
    {
        static void Main(string[] args)
        {
            Colectivo colectivoUno;//Declaracion de la variable tipo de colectivo

            colectivoUno = new Colectivo("AD123BC", 45, "TAC", 50, "R.Escalada", "Retiro",20);
            // por medio de la palabra reservada new y el constructor creo una nueva instancia de mi clase
            string info;
            info = colectivoUno.ColectivoToString();

            Console.WriteLine(info);
            do
            {
                Console.WriteLine("Ingrese la cantidad de pasajeros: ");

                if (colectivoUno.SubirPasajeros(int.Parse(Console.ReadLine())))
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
   

