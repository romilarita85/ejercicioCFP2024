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
////Usando funcion BOOLEANO
////Crear una funcion que pida o retorne el ingreso de un numero entero con un rango
////maximo y un rango minimo.
//namespace Array_Funciones
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //int numero = PedirEnteroConRango("Ingrese un numero entre 10 y 50: ", "El numero ingresado esta fuera de rango", 50, 10);
//            //Console.WriteLine($"El numero ingresado es: {numero}");

//            //Captura 255
//            Console.WriteLine("Ingrese un numero: ");
//            string numeroLeido = Console.ReadLine();
//            if (EsNumerico(numeroLeido))
//            {
//                Console.WriteLine("Es un numero");
//            }
//            else 
//            {
//                Console.WriteLine("No es un numero");
//            }
//        }
//        static void Saludar() 
//        {
//            Console.Write("Ingrese su nombre: "); 
//            Console.WriteLine($"Bienvenido: {Console.ReadLine()}");
//        }
//        static int PedirEnteroConRango(string mensaje, string mensajeError, int maximo, int minimo)
//        {
//            int numeroValido = 0;
//            Console.Write(mensaje);
//            numeroValido = int.Parse(Console.ReadLine());

//            while (numeroValido < minimo || numeroValido > maximo)
//            {
//                Console.Write(mensajeError);
//                Console.Write(mensaje);
//                numeroValido = int.Parse(Console.ReadLine());
//            }
//            return numeroValido;
//        }
//        //Usando funcion booleano: responde a lo que tenia por parametro. Si es un numero o no
//        static bool EsNumerico(string dato) //Ingreso una cadena de caracteres
//            //evalua si los datos son un digito
//        {
//            bool esNumerico = true;
//            foreach (char digito in dato)
//            {
//                if (!char.IsDigit(digito))
//                {
//                    esNumerico = false;
//                    break;
//                }
//            }
//            return esNumerico;

//        }

//    }
//}
///---------------------------------------------------------------------------------
//Usando funcion BOOLEANO y cambiando "PedirEnteroConRango" de forma simple (bloque se codigo
//simplificado)
//Crear una funcion que pida o retorne el ingreso de un numero entero con un rango
//maximo y un rango minimo.
//namespace Array_Funciones
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int numero = PedirEnteroConRangoV2("Ingrese un numero entre 10 y 50: ", "El numero ingresado esta fuera de rango", 50, 10);
//            Console.WriteLine($"El numero ingresado es: {numero}");
//            //-------------------
//            //do
//            //{
//            //    string numeroLeido;
//            //    int numeroValido;
//            //    Console.Write("Ingrese un numero: ");
//            //    numeroLeido = Console.ReadLine();
//            //    if (int.TryParse(numeroLeido, out numeroValido))
//            //    {
//            //        Console.WriteLine($"{numeroValido} es numerico ");
//            //    }
//            //    else
//            //    {
//            //        Console.WriteLine($"{numeroValido} No es numerico ");
//            //    }

//            //} while (true);
//            //---------------------
//        }
//        static void Saludar()
//        {
//            Console.Write("Ingrese su nombre: ");
//            Console.WriteLine($"Bienvenido: {Console.ReadLine()}");
//        }
//        static int PedirEnteroConRango(string mensaje, string mensajeError, int maximo, int minimo)
//        {
//            int numeroValido = 0;
//            string numeroLeido;
//            Console.Write(mensaje);
//            numeroLeido = Console.ReadLine();
            
//            while (!EsNumerico(numeroLeido) || (int.Parse(numeroLeido) > maximo) ||(int.Parse(numeroLeido) < minimo)) 
//            {
//                Console.WriteLine(mensajeError);
//                Console.Write(mensaje);
//                numeroLeido = Console.ReadLine();
//            }
//            numeroValido = int.Parse(numeroLeido);
//            return numeroValido;
//        }
//        //Usando funcion booleano: responde a lo que tenia por parametro. Si es un numero o no
//        static bool EsNumerico(string dato) //Ingreso una cadena de caracteres
//                                            //evalua si los datos son un digito
//        {
//            bool esNumerico = true;
//            foreach (char digito in dato)
//            {
//                if (!char.IsDigit(digito))
//                {
//                    esNumerico = false;
//                    break;
//                }
//            }
//            return esNumerico;

//        }
//        //Usando tryparse
//        static int PedirEnteroConRangoV2(string mensaje, string mensajeError, int maximo, int minimo)
//        {
//            int numeroValido = 0;
//            string numeroLeido;
//            Console.Write(mensaje);
//            numeroLeido = Console.ReadLine();

//            while (!int.TryParse(numeroLeido, out numeroValido) || (numeroValido > maximo|| numeroValido<minimo))
//            {
//                Console.WriteLine(mensajeError);
//                Console.Write(mensaje);
//                numeroLeido = Console.ReadLine();
//            }
//            return numeroValido;
//        }

//    }
//}
//------------------------------
//Usando funcion BOOLEANO y usando "PedirEnteroConRangoV2" de forma simple (bloque se codigo
//simplificado)
//Crear una funcion que pida o retorne el ingreso de un numero entero con un rango
//maximo y un rango minimo.
namespace Array_Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = PedirEnteroConRangoV2("Ingrese un numero entre 10 y 50: ", "El numero ingresado esta fuera de rango", 50, 10);
            Console.WriteLine($"El numero ingresado es: {numero}");
        }
        static void Saludar()
        {
            Console.Write("Ingrese su nombre: ");
            Console.WriteLine($"Bienvenido: {Console.ReadLine()}");
        }
        //Usando funcion booleano: responde a lo que tenia por parametro. Si es un numero o no
        static bool EsNumerico(string dato) //Ingreso una cadena de caracteres
                                            //evalua si los datos son un digito
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
        //Usando tryparse
        static int PedirEnteroConRangoV2(string mensaje, string mensajeError, int maximo, int minimo)
        {
            int numeroValido = 0;
            string numeroLeido;
            numeroLeido = Console.ReadLine();

            while (!int.TryParse(numeroLeido, out numeroValido) || (numeroValido > maximo || numeroValido < minimo))
            {
                Console.WriteLine(mensajeError);
                numeroLeido = PedirCadena(mensaje);
            }
            return numeroValido;
        }
        static string PedirCadena(string mensaje) 
        {
            Console.Write(mensaje);
            return Console.ReadLine();
        }

    }
}
