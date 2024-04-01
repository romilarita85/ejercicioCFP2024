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
//-uso largo--
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
namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largo;
            string[] miCadena = new string[5];
            char[] otraCadena = new char[5];
            int[] arrayNumerico = new int[5];

            miCadena[0] = "20/12/2022";
            miCadena[1] = "pedro";
            miCadena[2] = "15641561";
            miCadena[3] = "es un dia soleado";
            miCadena[4] = "23/#$/#$";
            largo = miCadena.Length;

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
            for (int i = 0; i < largo; i++)//Todos los impares
            {
                if (i % 2 != 0)
                {
                    miCadena[i] = "Es una posicion par";
                }
            }

        }
    }
}
