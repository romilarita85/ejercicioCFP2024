//---------------*************FUNCIONES***********------------------:
//
//Es un pequeño bloque de codigo que se encarga de hacer una unica tarea.
//Puedo hacer varias actividades el mensaje final es un numero entero.

//TIPOS DE FIRMA EN UNA FUNCION:
//1-Funciones que devuelven algo y que reciben parametros:
//La mas recomendada.
//namespace Funciones
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //* Una funcion para pedir que ingrese una cadena y retornarla *//
//            string palabra;
//            palabra = PedirCadena();
//            Console.WriteLine(palabra);
//        }
//        static string PedirCadena()
//        {
//            string lectura;
//            Console.WriteLine("Ingrese una cadena: ");
//            lectura = Console.ReadLine();

//            return lectura;
//        }
//    }
//}
//-------------------------------------------------------------------------------------------
//-/////////////////////////////////////////////////////////////////////////////-------------
//2-Funciones que devuelven algo y que no reciben parametros
//
//namespace Funciones
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //* Una funcion para pedir que ingrese una cadena y retornarla *//
//            string palabra;
//            palabra = PedirNombre();
//            Console.WriteLine(palabra);
//        }
//        static string PedirNombre()
//        {
//            string lectura;
//            Console.WriteLine("Ingrese su nombre: ");
//            lectura = Console.ReadLine();
//            return lectura;
//        }
//    }
//}
//-------------------------------------------------------------------------------------
//namespace Funciones
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //* Una funcion para pedir que ingrese una cadena y retornarla *//
//            string nombre;
//            string apellido;
//            string direccion;

//            nombre = PedirNombre("Ingrese su nombre: ");
//            apellido = PedirApellido("Ingrese su apellido: ");
//            direccion = PedirDireccion("Ingrese su direccion: ");

//            Console.WriteLine($"ud es: {nombre}{apellido} y vive en: {direccion}");
//        }
//        static string PedirCadena(string mensaje)
//        {
  //        string lectura;
    //      Console.Write(mensaje);
    //      lectura = Console.ReadLine();
    //      return lectura;
//        }
//
//        static string PedirNombre()
//        {
//            string lectura;
//            Console.WriteLine("Ingrese su nombre: ");
//            lectura = Console.ReadLine();
//            return lectura;
//        }

//        static string PedirApellido()
//        {
//            string lectura;
//            Console.WriteLine("Ingrese su apellido: ");
//            lectura = Console.ReadLine();
//            return lectura;
//        }
//        static string PedirDireccion()
//        {
//            string lectura;
//            Console.WriteLine("Ingrese su direccion: ");
//            lectura = Console.ReadLine();
//            return lectura;
//        }
//    }
//}
///----------------------------------------------------------------------------
//namespace Funciones
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //* Una funcion para pedir que ingrese una cadena y retornarla *//
//            string nombre;
//            string apellido;
//            string direccion;

//            nombre = PedirCadena("Ingrese su nombre: ");
//            apellido = PedirCadena("Ingrese su apellido: ");
//            direccion = PedirDireccion("Ingrese su direccion: ");

//            Console.WriteLine($"ud es: {nombre} {apellido} y vive en: {direccion}");
//            int unNumero = 8;
//            int otroNumero = 12;
//            int resultado;

//            resultado = SumarEnteros(unNumero,otroNumero);
//            Console.WriteLine(resultado);
//            //resultado = SumaEnteros(48,7);
//        }
//        //Que devuelven algo y que reciben parametros:--------
//        static string PedirCadena(string mensaje)
//        {
//            string lectura;
//            Console.Write(mensaje);
//            lectura = Console.ReadLine();
//            return lectura;
//        }

//        //Que devuelven algo y que no reciben parametros----------
//        static string PedirNombre()
//        {
//            string lectura;
//            Console.WriteLine("Ingrese su nombre: ");
//            lectura = Console.ReadLine();
//            return lectura;
//        }

//        static string PedirApellido()
//        {
//            string lectura;
//            Console.WriteLine("Ingrese su apellido: ");
//            lectura = Console.ReadLine();
//            return lectura;
//        }
//        static string PedirDireccion()
//        {
//            string lectura;
//            Console.WriteLine("Ingrese su direccion: ");
//            lectura = Console.ReadLine();
//            return lectura;
//        }
//        //Que devuelven algo y que reciben parametros-----------
//        static int SumarEnteros(int numeroUno, int numeroDos)
//        {
//            int resultado;
//            resultado = numeroUno + numeroDos;
//            return resultado;
//        }
//    }
//}
//------------------------------------------------------------------
//namespace Funciones
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
        
//            //int unNumero ;
//            //int otroNumero;
//            int resultado;

//            //resultado = SumarEnteros(unNumero, otroNumero);
//            resultado = SumarEnteros(48,7);
//            Console.WriteLine(resultado);
           
//        }
//        static string PedirCadena(string mensaje)
//        {
//            string lectura;
//            Console.Write(mensaje);
//            lectura = Console.ReadLine();
//            return lectura;
//        }
//        //Que devuelven algo y que reciben parametros
//        static int SumarEnteros(int numeroUno, int numeroDos)
//        {
//            return numeroUno + numeroDos; 
//        }


//    }
//}
//-----------------------------------------------------------------------------
//Crear una calculadora:
namespace Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado;         
            //resultado = Calculadora(48, 7, '+');
            //resultado = Calculadora(48, 7, '-');
            //resultado = Calculadora(35, 7, '/');
            resultado = Calculadora(4, 5, '*');
            Console.WriteLine(resultado);
        }
        static string PedirCadena(string mensaje)
        {
            string lectura;
            Console.Write(mensaje);
            lectura = Console.ReadLine();
            return lectura;
        }
        //Que devuelven algo y que reciben parametros
        static int Calculadora(int numeroUno, int numeroDos,char operador)
        {
            int resultado = 0;
            switch (operador) 
            {
                case '+':
                    resultado = numeroUno + numeroDos;
                    break;
                case '-':
                    resultado = numeroUno - numeroDos;
                    break;
                case '*':
                    resultado = numeroUno * numeroDos;
                    break;
                case '/':
                    resultado = numeroUno / numeroDos;
                    break;
            }
            return resultado;
        }
    }
}

