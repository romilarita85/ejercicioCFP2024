//ARRAY: Cadena o conjunto de  datos del mismo tipo
//Se reserva espacios consecutivos del tamaño de ese mensaje
//[] -> para identificar el tipo de dato
//[5] -> la cantidad de datos que voy a guardar en la cadena  es de 5 posiciones
//-----------------------------------------------
//1)-Formas de inicialializar el Array: 
//1-Usando "new"
//2-Desde un conjunto de valores
//------------------------------------------------
//2)-Existen Array:
//-de enteros
//-de string 
//-de objetos
//-de double
///------------------------------------------------------------------------------------
//namespace Array
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] miCadena = new string[5]; //coleccion de palabras: "20/12/24"-"pedro"-"1564561"-"es un dia soleados"-"20-#$-#$"
//            char[] otraCadena = new char[5];// "4" - "A" - "%" - " " - "+" - "1"
//            int[] arrayNumerico = new int[5];//"1" - "2545" - "354545" - "4" -"8"

//            miCadena[0]= "20/12/2022";
//            miCadena[1] = "pedro";
//            miCadena[2] = "15641561";
//            miCadena[3] = "es un dia soleado";
//            miCadena[4] = "23/#$/#$";

//            //Console.WriteLine(miCadena[0]);
//            //Console.WriteLine(miCadena[1]);
//            //Console.WriteLine(miCadena[2]);
//            //Console.WriteLine(miCadena[3]);
//            //Console.WriteLine(miCadena[4]);

//            //o usar interpolado:
//            Console.WriteLine($"{miCadena[0]},{miCadena[1]},{miCadena[2]},{miCadena[3]},{miCadena[4]}");

//        }
//    }
//}
//*--------------------------------------------
//3)LENGTH-
//-Metodo para saber cuantas posiciones tiene mi array (cuantas posiciones puedo guardar)
//-uso largo--Uso length para saber cuantos caracteres tiene la palabra
//namespace Array
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int largo;
//            string[] miCadena = new string[5];
//            char[] otraCadena = new char[5];
//            int[] arrayNumerico = new int[5];

//            miCadena[0] = "20/12/2022";
//            miCadena[1] = "pedro";
//            miCadena[2] = "15641561";
//            miCadena[3] = "es un dia soleado";
//            miCadena[4] = "23/#$/#$";
//            largo = miCadena.Length;

//            for (int i = 0; i < largo; i++) 
//            {
//                Console.WriteLine(miCadena[i]); 
//            }
//        }
//    }
//}
//------------------------------------------------------------------
//Mostrar todos los que son par o impar.
//
//namespace Array
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int largo;
//            string[] miCadena = new string[5];
//            char[] otraCadena = new char[5];
//            int[] arrayNumerico = new int[5];

//            miCadena[0] = "20/12/2022";
//            miCadena[1] = "pedro";
//            miCadena[2] = "15641561";
//            miCadena[3] = "es un dia soleado";
//            miCadena[4] = "23/#$/#$";
//            largo = miCadena.Length;

//for (int i = 0; i < largo; i++) //Todos los pares
//{
//    if (i % 2 == 0) 
//    {
//        Console.WriteLine(miCadena[i]); 
//    } 
//}
//for (int i = 0; i < largo; i++)//Todos los impares
//{
//    if (!(i % 2 == 0))
//    {
//        Console.WriteLine(miCadena[i]);
//    }
//}
//for (int i = 0; i < largo; i++)//Todos los impares
//{
//    if (i % 2 == 0)
//    {
//        miCadena[i] = "Es una posicion par";
//    }
//}

//        }
//    }
//}
//-------------------------------------------------------------------------------
////Se puede reemplazar posiciones ej: "ud. no es pedro"
//namespace Array
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int largo;
//            string[] miCadena = new string[5];
//            char[] otraCadena = new char[5];
//            int[] arrayNumerico = new int[5];

//            miCadena[0] = "20/12/2022";
//            miCadena[1] = "pedro";
//            miCadena[2] = "15641561";
//            miCadena[3] = "es un dia soleado";
//            miCadena[4] = "23/#$/#$";
//            largo = miCadena.Length;
//            //----------------- ejemplo: "ud no son pedro"
//            //for (int i = 0; i < largo; i++)
//            //{
//            //    if (miCadena[i] == "pedro") 
//            //    {
//            //        miCadena[i] = "uds no son pedro";
//            //    }
//            //}
//            //for (int i = 0; i < largo; i++)
//            //{
//            //    Console.WriteLine(miCadena[i]);
//            //}
//            //-----------------

//            //for (int i = 0; i < largo; i++)
//            //{
//            //    if (miCadena[i] != "pedro")
//            //    {
//            //        miCadena[i] = "uds no son pedro";

//            //    }
//            //}
//            //for (int i = 0; i < largo; i++)
//            //{
//            //    Console.WriteLine(miCadena[i]);
//            //}
//            //-------------------

//        }
//    }
//}
//------------------------------------------
//Cuanto va a  medir el ARRAY.
//namespace Array
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int largo;

//            char[] otraCadena = new char[5];
//            int[] arrayNumerico = new int[5];

//            string[] arrayPalabras = {"milanesa","lechuga","rojo","laura" }; // defini posiciones
//            largo = arrayPalabras.Length;

//            for (int i = 0; i < largo; i++)
//            {
//                Console.WriteLine(arrayPalabras[i]);
//            }

//        }
//    }
//}
//----------------------------------------------------------------------------------------------
//FOREACH: Si tengo que decir el tipo de nombre de una coleccion. 
//me trae en cada posicion el valor y lo guarda en la variable dato. Itera los datos.
//namespace Array
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int largo;

//            char[] otraCadena = new char[5];
//            int[] arrayNumerico = new int[5];

//            string[] arrayPalabras = { "milanesa", "lechuga", "rojo", "laura" }; // defini posiciones
//            largo = arrayPalabras.Length;
//            //------------
//            //foreach (string dato in arrayPalabras) 
//            //{
//            //    Console.WriteLine(dato);

//            //}
//            //-----------------
//            foreach (string dato in arrayPalabras)
//            {
//                if (dato == "laura") 
//                {
//                    Console.WriteLine("laura te encontre"); 

//                }
//            }

//        }
//    }
//}
//-------------FOREACH con contador-------
//namespace Array
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int largo;

//            char[] otraCadena = new char[5];
//            int[] arrayNumerico = new int[5];

//            string[] arrayPalabras = { "milanesa", "lechuga", "rojo", "laura" }; // defini posiciones
//            largo = arrayPalabras.Length;
//            int contador = 0;

//            //foreach (string dato in arrayPalabras)
//            //{
//            //    if (dato == "laura")
//            //    {
//            //        arrayPalabras[contador] = "laura te encontre";

//            //    }
//            //    contador ++;
//            //}

//            //foreach (string dato in arrayPalabras)
//            //{
//            //    if (dato == "laura")
//            //    {
//            //        arrayPalabras[3] = "laura te encontre";

//            //    }
//            //}
//            //foreach (string dato in arrayPalabras)
//            //{
//            //    Console.WriteLine(dato);

//            //}

//            //foreach (string dato in arrayPalabras)
//            //{
//            //    if (dato == "laura")
//            //    {
//            //        break;

//            //    }

//            //}

//        }
//    }
//}
//----------------------------------------------------------------------------------------------------
//ARRAY DE CHAR: Para hacer validaciones de cadena.
//namespace Array
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int largo;
//            char[] cadenaDeLetras = new char[5];
//            ///USAR COMILLAS SIMPLES
//            cadenaDeLetras[0] = 'h';
//            cadenaDeLetras[1] = 'o';
//            cadenaDeLetras[2] = 'l';
//            cadenaDeLetras[4] = 'a';
//            largo = cadenaDeLetras.Length;

//            foreach (char dato in cadenaDeLetras)
//            {
//                Console.WriteLine(dato);
//            }

//        }
//    }
//}
//---------------
//namespace Array
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int largo;
//            char[] cadenaDeLetras = new char[5];
//            char[] otraCadena = { 'd','i','a' };
//            ///USAR COMILLAS SIMPLES
//            cadenaDeLetras[0] = 'h';
//            cadenaDeLetras[1] = 'o';
//            cadenaDeLetras[2] = 'l';
//            cadenaDeLetras[4] = 'a';
//            largo = cadenaDeLetras.Length;
//            largo = otraCadena.Length;
////------------------------------------------
//            //for (int i = 0; i < largo; i++)
//            //{
//            //    Console.WriteLine(otraCadena[i]);
//            //}
////-----------------------------------CHAR vacio-------
//            for (int i = 0; i < largo; i++)
//            {
//                if(cadenaDeLetras[i] != ' ')
//                {
//                    Console.WriteLine(cadenaDeLetras[i]);
//                }              
//            }

//        }
//    }
//}
//-----------------------------------------------------------------------------------------------
//ARRAY NUMERICO

//namespace Array
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int cantidad = 5;
//            int[] numeros = new int[cantidad];
//            int suma = 0;

//            for (int i = 0; i < cantidad; i++)
//            {
//                Console.WriteLine($"Ingrese el {i+1}º numero: ");
//                numeros[i] = int.Parse(Console.ReadLine());
//            }
//            foreach(int item in numeros)
//            {
//                Console.WriteLine(item);

//            }
//        }
//    }
//}
//---------------ARRAY SUMA----------------
//namespace Array
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int cantidad = 5;
//            int[] numeros = new int[cantidad];
//            int suma = 0;

//            for (int i = 0; i < cantidad; i++)
//            {
//                Console.WriteLine($"Ingrese el {i+1}º numero: ");
//                numeros[i] = int.Parse(Console.ReadLine());
//            }

//            foreach (int item in numeros)
//            {
//                suma += item;
//            }
//            foreach (int item in numeros)
//            {
//                Console.WriteLine(item);

//            }
//            Console.WriteLine($"La suma de todos los numeros es: {suma}");

//        }
//    }
//}
//------------------------------------------------------------------------------------------------------
//STRING CADENA DE CARACTERES:
//ejemplo: array de nueve caracteres-------
//namespace Array
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string nombre = "florencia";
//            int largo;
//            largo = nombre.Length;

//            Console.WriteLine($"La palabra florencia tiene {largo} letras");

//            foreach (char letra in nombre)
//            {
//                Console.WriteLine(letra);
//            }
//        }
//    }
//}
//---------------------------------------
//Quiero saber si es una letra o no
//namespace Array
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string nombre = "florencia";
//            int largo;
//            largo = nombre.Length;

//            Console.WriteLine($"La palabra florencia tiene {largo} letras");
//            for (int i = 0; i < largo; i++)
//            {
//                if(char.IsLetter(nombre[i]))
//                {
//                    //Console.WriteLine("es una letra");
//                    Console.WriteLine($"{nombre[i]} es una letra");
//                }
//                else
//                {
//                    //Console.WriteLine("no es una letra");
//                    Console.WriteLine($"{nombre[i]} NO es una letra");
//                }
//            }
//        }
//    }
//}
///--------------------------------------------------------
///Para saber que tipo de posiciones: si es letra o numero
//namespace Array
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string nombre = "flo4encia1";
//            int largo;
//            largo = nombre.Length;

//            Console.WriteLine($"La palabra florencia tiene {largo} letras");
//            for (int i = 0; i < largo; i++)
//            {
//                if (char.IsLetter(nombre[i]))
//                {
//                    //Console.WriteLine("es una letra");
//                    Console.WriteLine($"{nombre[i]} es una letra");
//                }
//                else
//                {
//                    if (char.IsDigit(nombre[i]))
//                    {
//                        Console.WriteLine($"{nombre[i]} es un numero");
//                    }
//                    else
//                    {
//                        Console.WriteLine();
//                    }
//                }
//            }
//        }
//    }
//}
//-------------------------------------
//Usando booleanos
//namespace Array
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string nombre;
//            bool esIncorrecto = true;

//            do
//            {
//                esIncorrecto = false;
//                Console.WriteLine("Ingrese su nombre");
//                nombre = Console.ReadLine();

//                for (int i=0; i<nombre.Length; i++)
//                {
//                    if (!char.IsLetter(nombre[i]))
//                    {
//                        Console.WriteLine("el nombre debe tener solo letras");
//                        esIncorrecto = true;
//                        break;
//                    }
//                }
//            }while(esIncorrecto);
//            //Console.WriteLine(nombre);
//            Console.WriteLine($"el nombre valido es: {nombre}");

//        }
//    }
//}
//-------------------------------------------------------------------------
//Si queremos que una letra sea mayuscula
// nombre[0] = char.ToUpper(nombre[0]);
