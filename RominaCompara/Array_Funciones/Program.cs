//ARRAY REVERSE:
//namespace Array_Funciones
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] numeros = { 1, 2, 3, 4, 5 };
//            Array.Reverse(numeros);
//            foreach (var item in numeros) 
//            {
//                Console.WriteLine(item);


//            }
//        }
//    }
//}
//------------------------------------------------------------
//
//namespace Array_Funciones
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//        }
//        //Funcion que no recibe nada y que no retorna nada:
//        static void Saludar()
//        {
//            Console.Write("Ingrese su nombre: ");
//            Console.WriteLine($"Bienvenido: {Console.ReadLine()}");

//        }
//    }
//}
//-----------------------------------------------------------------------------
//Funciones que retornen algo:
//Crear una funcion que pida o retorne el ingreso de un numero entero con un rango
//maximo y un rango minimo.

//namespace Array_Funciones
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int numero = PedirEnteroConRango("Ingrese un numero entre 10 y 50: ", "El numero ingresado esta fuera de rango", 50, 10);
//            Console.WriteLine($"El numero ingresado es: {numero}");
//        }

//        static int PedirEnteroConRango(string mensaje, string mensajeError, int maximo, int minimo) 
//        {
//            int numeroValido = 0;
//            Console.Write(mensaje);
//            numeroValido= int.Parse(Console.ReadLine());
            
//            while (numeroValido < minimo || numeroValido > maximo) 
//            {
//                Console.Write(mensajeError);
//                Console.Write(mensaje);
//                numeroValido = int.Parse(Console.ReadLine());
//            }
//            return numeroValido;
//        }
//    }
//}
//--------------------------------------------------------------
//Usando funcion BOOLEANO
namespace Array_Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int numero = PedirEnteroConRango("Ingrese un numero entre 10 y 50: ", "El numero ingresado esta fuera de rango", 50, 10);
            //Console.WriteLine($"El numero ingresado es: {numero}");
            
            //Captura 255
            //Console
            //if()
            //{ 
            
            
            //}
        
        }

        static int PedirEnteroConRango(string mensaje, string mensajeError, int maximo, int minimo)
        {
            int numeroValido = 0;
            Console.Write(mensaje);
            numeroValido = int.Parse(Console.ReadLine());

            while (numeroValido < minimo || numeroValido > maximo)
            {
                Console.Write(mensajeError);
                Console.Write(mensaje);
                numeroValido = int.Parse(Console.ReadLine());
            }
            return numeroValido;
        }
        static bool EsNumerico(string dato)
        {
            bool esNumerico = true;
            foreach (char digito in dato)
            {
                if (!char.IsDigit(digito))
                {
                    esNumerico = false;
                    break;
                }
            }
            return esNumerico;

        }

    }
}
