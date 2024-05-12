//En el método Main, simular depósitos y extracciones de dinero de la cuenta,
//e ir mostrando cómo va variando el saldo.
using Biblioteca_PracticaRepaso;
namespace PracticaRepaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Dalma Perez", 400000);
            Console.WriteLine("Saldo inicial de la cuenta:");
            Console.WriteLine(cuenta1.CuentaToString());
            //En el método Main, simular depósitos y extracciones de dinero de la cuenta,
            //e ir mostrando cómo va variando el saldo.
            cuenta1.IngresarDinero(500000);
            Console.WriteLine("Saldo después de ingresar $500.000:");
            Console.WriteLine(cuenta1.CuentaToString());

            cuenta1.RetirarDinero(150000);
            Console.WriteLine("Saldo después de retirar $150.000:");
            Console.WriteLine(cuenta1.CuentaToString());

            cuenta1.RetirarDinero(10000);
            Console.WriteLine("Saldo despues de retirar $10.000:");
            Console.WriteLine(cuenta1.CuentaToString());

            Console.ReadLine();

        }

    }
}
