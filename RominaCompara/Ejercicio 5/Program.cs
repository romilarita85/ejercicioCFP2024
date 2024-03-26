namespace Ejercicio_5
//5.	(E/S) 
//En un hospital existen tres áreas: Cardiología, Pediatría y Traumatología.El presupuesto anual del hospital se reparte conforme a la siguiente tabla:
//Área Porcentaje del presupuesto
//Cardiología	    40%
//Pediatría			45%  
//Traumatología		15%

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int presupuestoAnual;
            int porcentajeC;
            int porcentajeP;
            int porcentajeT;
            int valorPorcentajeCardio;
            int valorPorcentajePediat;
            int valorPorcentajeTrauma;
            valorPorcentajeCardio = 40;
            valorPorcentajePediat = 45;
            valorPorcentajeTrauma = 15;
            //Entradas
            Console.WriteLine("Ingrese presupuesto anual");
            presupuestoAnual = Console.Read();

            //Proceso
            porcentajeC = presupuestoAnual * valorPorcentajeCardio / 100;
            porcentajeP = presupuestoAnual * valorPorcentajePediat / 100;
            porcentajeT = presupuestoAnual * valorPorcentajeTrauma / 100;

            Console.WriteLine("A Cardiologia le corresponde:" + porcentajeC + "%.");
            Console.WriteLine("A Pediatria le corresponde:" + porcentajeP + "%.");
            Console.WriteLine("A Traumatologia le corresponde:" + porcentajeT + "%.");

        }
    }
}