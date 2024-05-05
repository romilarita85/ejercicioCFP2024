using Libreria_De_Farmacias;
namespace TesteoDeFarmacias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Farmacia farmacia1;
            farmacia1 = new Farmacia("Santa Isabel", "BAGO", "Av.Corrientes 234", "IBU 400",2000, 20);

            string lectura;
            lectura = farmacia1.FarmaciaToString();
            Console.WriteLine(lectura);

            Farmacia farmacia2 = new Farmacia("FarmaPlus", "ROCHE", "Viel 1122", "Tafirol 600",1500, 50);
            Console.WriteLine(farmacia2.FarmaciaToString());

            Farmacia farmacia3 = new Farmacia("FarmaCenter", "Axtraseneca", "Curapaligue 2301", "Hepatalgina", 3500, 70);
            Console.WriteLine(farmacia3.FarmaciaToString());

            Farmacia.MostrarProveedor();
            //Comportamiento: quiero que farmacia1 compre medicamentos de proveedor

        }
    }
}
