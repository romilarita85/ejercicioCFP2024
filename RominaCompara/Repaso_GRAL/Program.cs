//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            ejemplo_de_otra_clase.PedirCadena("Ingrese su nombre: ");
//            ejemplo_de_otra_clase miObjeto = new ejemplo_de_otra_clase();
//            Console.WriteLine(miObjeto.nombre);
//        }
//    }
//}
//-----------PARSEO----------------------------------------------
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int edad;
//            string edadEnTexto;

//            Console.Write("Ingrese su edad: ");

//            edad = int.Parse(Console.ReadLine());
//            Console.WriteLine($"Edad parseada de string a int {edad}");

//            edadEnTexto = edad.ToString();
//            Console.WriteLine($"Edad parseada de int a string {edadEnTexto}");
//        }
//    }
//}
//---------------GetTipe---------------------------------------------
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int edad;
//            string edadEnTexto;

//            Console.Write("Ingrese su edad: ");

//            edad = int.Parse(Console.ReadLine());
//            Console.WriteLine($"Edad parseada de string a int {edad} edad es de tipo: {edad.GetType()} ");

//            edadEnTexto = edad.ToString();
//            Console.WriteLine($"Edad parseada de int a string {edadEnTexto} edad es de tipo: {edadEnTexto.GetType()}");
//        }
//    }
//}
//---------------------Try parse--------------------------------------------------
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int edad;
//            string lectura;

//            Console.Write("Ingrese su edad: ");
//            lectura = Console.ReadLine();

//            if (int.TryParse(lectura,out edad))
//            {
//                Console.WriteLine($"Edad ingresada es: {edad}");
//            }
//            else 
//            {
//                Console.WriteLine("El dato ingresado no es valido");
//            }
//        }
//    }
//}
//-----------------------------Bucles Repetitivos----------------------------------
//-For ->Para cuando conocemos la cantidad de repeticiones
//-While ->Para cuando desconozca la cantidad de repeticiones y
//solo se va a ejecutar si la condicion es verdadera
//-Do While ->Para cuando desconozca la cantidad de repeticiones y
//preciso que se ejecute el codigo por lo menos 1 vez
//Variable de control
//condicion de corte
//cantidad de repeticiones
//------------------
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            bool bandera = false;
//            int contador = 0;

//            while (bandera == false) 
//            {
//                //contador++;-> puede ir aca o abajo del if funciona igual
//                Console.WriteLine($"Vuelta n°{contador}");
//                if (contador > 10) 
//                {
//                    bandera = true;
//                }
//                contador++;
//            }
//        }
//    }
//}
//-------------------
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            bool bandera = false;
//            int contador = 0;

//            bool resultado = bandera == false;

//            while (resultado)
//            {
//                contador++;//puede ir aca o abajo del if funciona igual
//                Console.WriteLine($"Vuelta n°{contador} valor de la evaluacion: {resultado}");
//                if (contador > 10)
//                {
//                    resultado = false;
//                }
//            }
//        }
//    }
//}
//------------------------------------------------------------------------------
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int i;
//            for (i = 0; i < 0; i++/* i =i+1, i +=1 */)
//            {
//                Console.WriteLine($"Vuelta n°{i} del for");
//            }
//            Console.WriteLine($"Valor de i: {i}");
//            Console.WriteLine("-------------------------------------------");
//
//            int contador = 0;
//            while (contador < 0)
//            { 
//                Console.WriteLine($"Vuelta n°{contador} del while");

//                contador++;
//            }
//            Console.WriteLine($"Valor de contador: {contador}");
//            Console.WriteLine("-------------------------------------------");
//
//            int contadorDo = 0;
//            do
//            {
//                Console.WriteLine($"Vuelta n°{contadorDo} del Do while");
//                contadorDo++;
//            } while (contadorDo<0);
//            Console.WriteLine($"Valor de contadorDo: {contadorDo}");
//        }   
//    }
//}
//-----------------------------STRINGS-CADENAS-------------------------------------
//String-tipo de dato. Es un conjunto de caracteres. Puedo recorrerlo con un for
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string frase = "frase que escribi";

//            Console.WriteLine($"La frase: \"{frase}\" tiene {frase.Length} caracteres");

//            for (int i = 0; i < frase.Length; i++/* i =i+1, i +=1 */)
//            {
//                Console.WriteLine(frase[i]);
//            }
//        }
//    }
//}
////Propiedad Length: Valor numerico. Representa la cantidad de caracteres que tiene
////mi cadena. Los espacios representan un caracter (los van a contar).
//------Foreach------
////Es util para recorrer una coleccion. Siempre y cuando queramos recorrer una coleccion
////de datos string-> cadena de caracteres->char
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string frase = "frase que escribi";

//            foreach (char letra in frase)
//            {
//                Console.WriteLine(letra);
//                if (letra == 'q') 
//                {
//                    break;
//                }
//            }


//        }
//    }
//}
//----------------------------METODO TRIM--------------------------------
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string frase = ".....     ******frase que escribi******      .....";

//            //frase = frase.Trim(); //borra espacios en blanco
//            //frase = frase.Trim('*');//especifica que espacios quiero borrar
//            frase = frase.Trim(['*',' ','.']); //no importa el orden de los parametros 
//                                               //los borra igual
//            frase = frase.ToUpper();
//            for (int i = 0; i < frase.Length; i++)
//            {
//                Console.WriteLine(frase[i]);

//            }

//        }
//    }
//}
////Toupper:es un método que se utiliza para convertir
////una cadena de caracteres a su equivalente en mayúsculas.
//--------------------------ARRAY DE NUMEROS----------------------------
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //Dos formas de inicializar el array:
//            int[] numeros= new int[5];
//            int[] numeros2 = { 1, 2, 85, 100, -98 };

//            for (int i = 0; i < numeros.Length;i++) 
//            {
//                numeros[i] = i + 1;
//            }
//            numeros[3] = 15; //puedo dar un nuevo valor de forma arbitraria

//            foreach (int numero in numeros)
//            {
//                Console.WriteLine(numero);
//            }
//        }
//    }
//}
//-----------------------
namespace Repaso_GRAL
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int[] numeros = new int[5];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = i + 1;
            }
            numeros[3] = 15; //puedo dar un nuevo valor de forma arbitraria

            Array.Reverse(numeros); // doy vuelta los valores
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}