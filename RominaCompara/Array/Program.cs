//ARRAY: Cadena o conjunto de  datos del mismo tipo
//Se reserva espacios consecutivos del tamaño de ese mensaje
//[] -> para identificar el tipo de dato
//[5] -> la cantidad de datos que voy a guardar en la cadena  es de 5 posiciones
//-----------------------------------------------
//Formas de inicialializar el Array: 
//1-Usando "new"
//2-Desde un conjunto de valores
//------------------------------------------------
//Existen Array:
//-de enteros
//-de string 
//-de objetos
//-de double

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] miCadena = new string[5];
            char[] otraCadena = new char[5];
            int[] arrayNumerico = new int[5];

            miCadena[0]= "20/12/2022";
            miCadena[1] = "pedro";
            miCadena[2] = "15641561";
            miCadena[3] = "es un dia soleado";
            miCadena[4] = "23/#$/#$";

            //Console.WriteLine(miCadena[0]);
            //Console.WriteLine(miCadena[1]);
            //Console.WriteLine(miCadena[2]);
            //Console.WriteLine(miCadena[3]);
            //Console.WriteLine(miCadena[4]);

            //o usar interpolado:
            Console.WriteLine($"{miCadena[0]},{miCadena[1]},{miCadena[2]},{miCadena[3]},{miCadena[4]}");
            
        }
    }
}
