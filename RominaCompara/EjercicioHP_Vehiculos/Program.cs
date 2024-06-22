using LibreriaDeVehiculos;
namespace EjercicioHP_Vehiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear instancias de Coche y Moto.
            Coche coche1 = new Coche("Ford","RD2017",5,4);
            Moto moto1 = new Moto("Honda","PCX150","Cross",149);

            List<Vehiculo>vehiculos = new List<Vehiculo>() 
            {
                new Coche("Ford","RD2017",5,4),
                new Moto("Honda","PCX150","Cross",149)
            };

            foreach (Vehiculo vehiculo in vehiculos)
            {//Llamar a los métodos Conducir() y MostrarInfo() para cada instancia.
                Console.WriteLine($"Tipo de vehiculo: {vehiculo.GetType().Name}|Accion: {vehiculo.Conducir()}|Informacion: {vehiculo.MostrarInfo()}");

            }
            //Utilizar GetType() y el casteo para llamar a los métodos específicos de
            //las clases derivadas(AbrirMaletero() y HacerCaballito()).
            // Llamar a métodos específicos usando GetType() y casteo
            if (coche1.GetType() == typeof(Coche))
            {
                Coche cocheCasteo = (Coche)coche1;
                Console.WriteLine($"{cocheCasteo.AbrirMaletero()}");
            }

            if (moto1.GetType() == typeof(Moto))
            {
                Moto motoCasteo = (Moto)moto1;
                Console.WriteLine($"{motoCasteo.HacerCaballito()}");
            }

        }
    }
}
//typeof se usa para obtener el tipo de un objeto conocido en tiempo de compilación
//o para obtener el tipo de un tipo de datos primitivo.

//GetType() es un método que se llama en una instancia de un objeto en tiempo de ejecución
//para obtener el tipo real del objeto en ese momento específico.
//typeof es útil para obtener el tipo de un objeto o tipo en tiempo de compilación,
//lo que lo hace ideal para comparaciones y operaciones que dependen del tipo en tiempo de ejecución,
//especialmente en escenarios donde la reflexión o la metaprogramación son necesarias.



