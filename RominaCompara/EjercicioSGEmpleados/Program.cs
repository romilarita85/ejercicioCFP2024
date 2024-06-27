using LibreriaDeEmpleados;
namespace EjercicioSGEmpleados
{
    internal class Program
    {
        static void Main(string[] args)
        {//o Crear instancias de Gerente, Desarrollador y Analista.
            Gerente gerente1 = new Gerente("Daniel", 200000, "Ventas", 10, 7);
            Gerente gerente2 = new Gerente("Sofia", 350000, "Contable", 15, 6);
            Desarrollador desarrollador1 = new Desarrollador("Julio",400000,"Desarrollo",5,"C++","8 años" );
            Desarrollador desarrollador2 = new Desarrollador("Carlos", 450000, "Desarrollo", 8, "JavaScript", "10 años");
            Analista analista1 = new Analista("Maria", 350000, "Sistemas", 15, "Data Entry", 4);
            Analista analista2 = new Analista("Nestor",400000, "Finanzas", 15, "Data Entry", 4);

            List<Empleado> empleados = new List<Empleado>()
            {
                gerente1,gerente2,desarrollador1,desarrollador2,analista1,analista2
            };

            foreach (Empleado empleado in empleados)
            {//o Llamar a los métodos Trabajar(), MostrarInfo() y CalcularBonificacion() para cada instancia.
                
                Console.WriteLine($"Tipo de empleado: {empleado.GetType().Name}");
                Console.WriteLine($"Trabajar: {empleado.Trabajar()}");
                Console.WriteLine($"Informacion del empleado: {empleado.MostrarInfo()}");
                Console.WriteLine($"Calculo de bonificación:{empleado.CalcularBonificacion()}");
                Console.WriteLine("**********************************************************************************");
            }
           
            //o Utilizar el casting para llamar a los métodos específicos de las clases derivadas(Planificar(),
            //DepurarCodigo() y PrepararInforme()).
            foreach (Empleado empleado in empleados)
            {
                if (empleado.GetType() == typeof(Gerente))
                {
                    Console.WriteLine(((Gerente)empleado).Planificar());
                }
                else if (empleado.GetType() == typeof(Desarrollador))
                {
                    Console.WriteLine(((Desarrollador)empleado).DepurarCodigo());
                }
                else
                {
                    Console.WriteLine(((Analista)empleado).PrepararInforme());
                }
            }

        }
    }
}
