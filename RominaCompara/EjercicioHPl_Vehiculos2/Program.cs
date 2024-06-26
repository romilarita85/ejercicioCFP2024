using LibreriaDeVehiculos;
namespace EjercicioHPl_Vehiculos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear instancias de Coche y Moto.
            Coche coche1 = new Coche("Ford", "RD2017", 5, 4);
            Vehiculo coche2 = new Coche("Fiat", "2023", 3, 100);
            //Vehiculo vehiculo = new Vehiculo("Fiat","1998");
            Moto moto1 = new Moto("Honda", "PCX150", "Cross", 149);
            Vehiculo moto2 = new Moto("Yamaha", "2022", "Paseo", 150);


            List<Vehiculo> vehiculos = new List<Vehiculo>(){ };
            vehiculos.Add(coche1);
            vehiculos.Add(coche2);
            vehiculos.Add(moto1);
            vehiculos.Add(moto2);

            foreach (Vehiculo vehiculo in vehiculos)
            {//Llamar a los métodos Conducir() y MostrarInfo() para cada instancia.
                Console.WriteLine($"Tipo de vehiculo: {vehiculo.GetType().Name}|Accion: {vehiculo.Conducir()}|Informacion: {vehiculo.MostrarInfo()}");

            }
            //Utilizar GetType() y el casteo para llamar a los métodos específicos de
            //las clases derivadas(AbrirMaletero() y HacerCaballito()).
            // Llamar a métodos específicos usando GetType() y casteo

            foreach (Vehiculo vehiculo in vehiculos)
            {
                if (vehiculo.GetType() == typeof(Moto))
                {
                    Console.WriteLine(((Moto)vehiculo).MostrarInfo());
                }
                else if (vehiculo.GetType() == typeof(Coche))
                {
                    Console.WriteLine(((Coche)vehiculo).MostrarInfo());
                }
                else 
                {
                    Console.WriteLine(vehiculo.MostrarInfo());
                }
            }
        }
    }
}
