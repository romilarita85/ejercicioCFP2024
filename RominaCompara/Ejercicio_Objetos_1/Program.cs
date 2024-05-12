//1.Crear una aplicación de consola y una biblioteca de clases que contenga
//la clase Cuenta.

//Deberá tener los atributos:

//●	titular: que contendrá la razón social del titular de la cuenta.
//●	cantidad:  que será un número decimal que representa al monto actual de dinero
//en la cuenta.

//Construir los siguientes métodos para la clase:

//●	Un constructor que permita inicializar todos los atributos.
//●	Un método getter para cada atributo.
//●	CuentaToString: retornará una cadena de texto con todos los datos de la cuenta.
//●	IngresarDinero: recibirá un monto para acreditar a la cuenta.
//Si el monto ingresado es negativo, no se hará nada.
//●	RetirarDinero: recibirá un monto para debitar de la cuenta.
//La cuenta puede quedar en negativo.

//En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando cómo va variando el saldo.
using BibliotecaDeCuentas;
namespace Ejercicio_Objetos_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuentaUno;//Declaracion de la variable tipo de cuenta
            cuentaUno = new Cuenta("Roxana Sanchez", 20000);
            // por medio de la palabra reservada new y el constructor creo una nueva instancia de mi clase
            string info;
            info = cuentaUno.CuentaToString();
            Console.WriteLine(info);

            Console.WriteLine("Saldo inicial de la cuenta:");
            Console.WriteLine(cuentaUno.CuentaToString());
            //En el método Main, simular depósitos y extracciones de dinero de la cuenta,
            //e ir mostrando cómo va variando el saldo.
            cuentaUno.IngresarDinero(500000);
            Console.WriteLine("Saldo después de ingresar $500.000:");
            Console.WriteLine(cuentaUno.CuentaToString());

            cuentaUno.RetirarDinero(150000);
            Console.WriteLine("Saldo después de retirar $150.000:");
            Console.WriteLine(cuentaUno.CuentaToString());

            cuentaUno.RetirarDinero(10000);
            Console.WriteLine("Saldo despues de retirar $10.000:");
            Console.WriteLine(cuentaUno.CuentaToString());

            Console.ReadLine(); 
        }
    }
}
