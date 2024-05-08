using Libreria_De_Farmacias;
namespace TesteoDeFarmacias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Farmacia farmacia1;
            farmacia1 = new Farmacia("Santa Isabel","Av.Corrientes 234", "lu a vi 9 a 20hs",2000, 200000);

            string lectura;
            lectura = farmacia1.FarmaciaToString();
            Console.WriteLine(lectura);

            Farmacia farmacia2 = new Farmacia("FarmaPlus", "Viel 1122","lu a vi 8 a 16hs", 9500, 350000);
            Console.WriteLine(farmacia2.FarmaciaToString());

            Farmacia farmacia3 = new Farmacia("FarmaCenter","Curapaligue 2301", "lu a vi 9 a 19hs", 10000, 250000);
            Console.WriteLine(farmacia3.FarmaciaToString());

            Farmacia.RegistrarVentas(230000.50);
            Console.WriteLine($"Se ha registrado una venta por ${montoDeVenta}.");

            List<Farmacia>listaDeFarmacias = new List<Farmacia>();
            listaDeFarmacias.Add(farmacia1);
            listaDeFarmacias.Add(farmacia2);
            listaDeFarmacias.Add(farmacia3);
            Console.WriteLine("Mostrar mi lista completa");

            foreach (Farmacia item in listaDeFarmacias)
            {
                Console.WriteLine(item.FarmaciaToString());
            }


        }
    }
}
