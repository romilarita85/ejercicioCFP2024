//CLASE 15-04-24
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

            Console.WriteLine(primerEmpleado.InformarDatos());
            Console.WriteLine(segundoEmpleado.InformarDatos());

            Console.WriteLine($"Consulto sueldo empleado 2: {segundoEmpleado.GetSueldo()}");

            Console.WriteLine($"Consulto sueldo empleado 1: {primerEmpleado.GetSueldo()}");

            primerEmpleado.SetSueldo(200000);

            Console.WriteLine($"Consulto sueldo empleado 1 despues de usar SET: {primerEmpleado.GetSueldo()}");

        }
    }
}
//Console -> solo sirve para proyectos de consola
//
//***********************Metodo para ver valores de cada empleado:-----------------------------------------------
//1)-string datosEmpleado1 = primerEmpleado.InformarDatos();//ver valores de cada empleado
//2)-Console.WriteLine (primerEmpleado.InformarDatos());                                                       

//***********************Puedo cambiar valores fuera de mi clase------------------------------------------
//-Consultar y modificar con un campo publico
//(en libreria de empleados hacer public el atributo legajo)

//Console.WriteLine("Datos sin modificar");
//Console.WriteLine(primerEmpleado.InformarDatos());
//primerEmpleado.legajo = 8;

//Console.WriteLine("Datos modificados");
//Console.WriteLine(primerEmpleado.InformarDatos);

//***********************USANDO Get y Set: Puedo agregar validaciones dentro de sueldo----------------
//
//Console.WriteLine($"Consulta sueldo empleado 2: {segundoEmpleado.GetSueldo()}");
//Console.WriteLine($"Consulta sueldo empleado 1: {primerEmpleado.GetSueldo()}");
//primerEmpleado.SetSueldo(200000);
//Console.WriteLine($"Consulta sueldo empleado 1 despues de usar set: {primerEmpleado.GetSueldo()}");