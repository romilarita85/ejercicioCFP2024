using LibreriaDePersonas;
namespace TesteoDeEmpleados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Empleado primerEmpleado;
            //primerEmpleado = new Empleado(1, "Juan", "Perez");
            Empleado primerEmpleado = new Empleado(1, "Juan", "Perez");
            Empleado segundoEmpleado = new Empleado(2, "Analia", "Sanchez", 230000, "Gerencia");
            
            string datosEmpleado1 = primerEmpleado.InformarDatos(); //ver valores de cada empleado
            //captura 496
        }
    }
}
