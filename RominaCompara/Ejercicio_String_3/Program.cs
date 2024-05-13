//Ejercicio_String_3
//Pedir el ingreso de una palabra y reemplazar todas las letras A
//por un carácter especial (* , & , etc). ej: Manzana->M * nz * n *.

namespace Ejercicio_String_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            Console.WriteLine("Escriba una palabra: ");
            palabra = Console.ReadLine();

            char[] letras = palabra.ToCharArray();

            for (int i = 0; i < letras.Length; i++)
            {
                if (letras[i] == 'a')
                {
                    letras[i] = '#';
                }
                foreach (char unaLetra in letras)
                {
                    Console.Write(unaLetra);
                }


            }
        }
    }
}
//-----------------------------------------------------------------------------------
//Otras formas: Inicializando el String con comillas dobles ("").
////////////////////////////////////////
//namespace Ejercicio_String_3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string palabra;
//            Console.WriteLine("Escriba una palabra: ");
//            palabra = Console.ReadLine();

//            char[] letras = palabra.ToCharArray();

//            for (int i = 0; i < letras.Length; i++)
//            {
//                if (letras[i] == 'a')
//                {
//                    letras[i] = '#';
//                }

//            }
//            string otraPalabra = "";

//            foreach (char unaletra in letras)
//            {
//                otraPalabra += unaletra;
//            }
//            Console.WriteLine(otraPalabra);

//        }
//    }
//}
//------------------------------------
//Otra forma (usando EMPTY): Inicializando String usando "String.empty"
//namespace Ejercicio_String_3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string palabra;
//            Console.WriteLine("Escriba una palabra: ");
//            palabra = Console.ReadLine();

//            char[] letras = palabra.ToCharArray();

//            for (int i = 0; i < letras.Length; i++)
//            {
//                if (letras[i] == 'a')
//                {
//                    letras[i] = '#';
//                }

//            }
//            String otraPalabra = String.Empty;

//            foreach (char unaletra in letras)
//            {
//                otraPalabra += unaletra;
//            }
//            Console.WriteLine(otraPalabra);

//        }
//    }
//}
//-----------------------------------------------------------------------------------
//Otra forma:Usando FOREACH
//namespace Ejercicio_String_3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string palabra;
//            string palabraModificada = string.Empty;
//            Console.WriteLine("Escriba una palabra: ");
//            palabra = Console.ReadLine();

//            foreach (char unaletra in palabra)
//            {
//                if (unaletra =='a')
//                {
//                    palabraModificada += '#';
//                }
//                else 
//                {
//                    palabraModificada += unaletra;
//                }

//            }
//            Console.Write(palabraModificada);

//        }
//    }
//}
//-------------------------------------------------------------------------
//Otra forma: Usando ToUpper--> donde siempre la primer letra va a quedar en mayuscula
//namespace Ejercicio_String_3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string palabra;
//            int contador = 0;
//            string palabraModificada = string.Empty;
//            Console.WriteLine("Escriba una palabra: ");
//            palabra = Console.ReadLine();

//            foreach (char unaletra in palabra)
//            {
//                if (contador == 0) 
//                {
//                    palabraModificada += char.ToUpper(unaletra);

//                }
//                else 
//                {
//                    if (unaletra == 'a')
//                    {
//                        palabraModificada += '#';
//                    }
//                    else
//                    {
//                        palabraModificada += unaletra;

//                    }

//                }

//                contador++;
//            }
//            Console.Write(palabraModificada);

//        }

//    }
//}
//------------------------------
//Otra forma:
//namespace Ejercicio_String_3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string palabra;
//            int contador = 0;
//            string palabraModificada = string.Empty;
//            Console.WriteLine("Escriba una palabra: ");
//            palabra = Console.ReadLine();

//            foreach (char unaletra in palabra)
//            {
//                if (contador == 0 && unaletra != 'a')
//                {
//                    palabraModificada += char.ToUpper(unaletra);
//                }
//                else
//                {
//                    if (unaletra == 'a')
//                    {
//                        palabraModificada += '#';
//                    }
//                    else
//                    {
//                        palabraModificada += unaletra;

//                    }
//                }
//                contador++;
//            }
//            Console.Write(palabraModificada);
//        }
//    }
//}

