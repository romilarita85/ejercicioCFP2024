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
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        { 
//            int[] numeros = new int[5];

//            for (int i = 0; i < numeros.Length; i++)
//            {
//                numeros[i] = i + 1;
//            }
//            numeros[3] = 15; //puedo dar un nuevo valor de forma arbitraria

//            Array.Reverse(numeros); // doy vuelta los valores
//            foreach (int numero in numeros)
//            {
//                Console.WriteLine(numero);
//            }
//        }
//    }
//}
//---------------------------****-FUNCIONES-****---------------------------------
//1-Visibilidad: podra ser public o privada (private)
//2-Comportamiento: Estatic o de instancia
//3-Retorno: Sin retorno (VOID) o cualquier tipo de dato (int, string)
//4-Nombre: Debe empezar con mayuscula PascalCase, tiene que ser representativo
//a lo que hace y por lo general es un verbo (por que hace una accion)
//5-Prametros: Puedo no tenerlos, en caso de tenerlos pueden ser de cualquier 
//tipo o cantidad.

//Existen 4 tipos de firmas:
//1-Las que retornan algo y reciben parametros-> las ideales
//2-Las que retornan algo y no reciben paramentros
//3-Las que no retornan nada y reciben parametros
//4-Las que no retornan nada y no reciben parametros

//Etapas que componen una funcion:
//1° etapa -La firma
//2° etapa -El desarrollo
//3° etapa -El llamado o invocacion
//
//!true -> false
//!false -> true
//*****************************************************************************
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        { //3° etapa -El llamado o invocacion
//            ///paso valor a la funcion-harcodeados:
//            //int suma;
//            //suma = SumarEnteros (45,16);
//            //Console.WriteLine($"El valor de la suma es: {suma}");

//            ///O podria hacer datos que vengan de una variable:
//            int suma;
//            int numero1 = 45;
//            int numero2 = 16;
//            suma = SumarEnteros(numero1,numero2);
//            Console.WriteLine($"El valor de la suma entre {numero1} y {numero2} es: {suma}");

//        }
//        //ejemplo: Recibir dos numeros y sumarlos
//        public static int SumarEnteros(int numero1, int numero2) //1° etapa -La firma
//        {//2° etapa -El desarrollo
//            int resultado;
//            resultado = numero1 + numero2;
//            return resultado;
//        }
//    }
//}
//---------------**************************************------------------
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        { //3° etapa -El llamado o invocacion
//            ///paso valor a la funcion-harcodeados:
//            //int suma;
//            //suma = SumarEnteros (45,16);
//            //Console.WriteLine($"El valor de la suma es: {suma}");

//            ///O podria hacer datos que vengan de una variable:
//            //int suma;
//            //int numero1 = 45;
//            //int numero2 = 16;
//            //suma = SumarEnteros(numero1, numero2);
//            //Console.WriteLine($"El valor de la suma entre {numero1} y {numero2} es: {suma}");
//            //****************
//            int numero;
//            Console.WriteLine("Ingrese un numero: ");

//            if (int.TryParse(Console.ReadLine(), out numero))
//            {
//                if (EsPar(numero))
//                {
//                    Console.WriteLine($"El numero {numero} es par");
//                }
//                else 
//                {
//                    Console.WriteLine($"El numero {numero} es impar");
//                }
//            }
//            else 
//            {
//                Console.WriteLine("El dato ingresado es incorrecto");
//            }
//        }
//        //ejemplo: Recibir dos numeros y sumarlos
//        public static int SumarEnteros(int numero1, int numero2) //1° etapa -La firma
//        {//2° etapa -El desarrollo
//            int resultado;
//            resultado = numero1 + numero2;
//            return resultado;
//        }
//        //**************************
//        //Ejemplo: Quiero saber si el numero es par
//        public static bool EsPar(int numero) 
//        {
//            bool esPar = false; //variable booleana que me diga que es par

//            if (numero % 2 == 0) 
//            {
//                esPar = true;
//            }
//            return esPar;

//        }
//        //*******************+
//        public static int PedirNumero() 
//        {
//            //int numero;
//            //Console.Write("Ingrese un numero: ");
//            //while (!int.TryParse(Console.ReadLine(), out numero))
//            //{
//            //    Console.WriteLine("El dato ingresado no es un numero");
//            //    Console.Write("Ingrese un numero: ");
//            //}
//            //return numero;

//            int numero;
//            string lectura;
//            Console.Write("Ingrese un numero: ");
//            lectura = Console.ReadLine();

//            while (!int.TryParse(lectura, out numero))
//            {
//                Console.WriteLine("El dato ingresado no es un numero");
//                Console.Write("Ingrese un numero: ");
//                lectura = Console.ReadLine();
//            }
//            return numero;
//        }
//    }
//}
//***************************************************************************
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        { //3° etapa -El llamado o invocacion
//            ///paso valor a la funcion-harcodeados:
//            //int suma;
//            //suma = SumarEnteros (45,16);
//            //Console.WriteLine($"El valor de la suma es: {suma}");

//            ///O podria hacer datos que vengan de una variable:
//            //int suma;
//            //int numero1 = 45;
//            //int numero2 = 16;
//            //suma = SumarEnteros(numero1, numero2);
//            //Console.WriteLine($"El valor de la suma entre {numero1} y {numero2} es: {suma}");
//            //****************
//            int numero;
//            numero = PedirNumero("Ingrese un numero: ");

//            if (EsPar(numero))
//            {
//                Console.WriteLine($"El numero {numero} es par");
//            }
//            else
//            {
//                Console.WriteLine($"El numero {numero} es impar");
//            }
//        }
//        //ejemplo: Recibir dos numeros y sumarlos
//        public static int SumarEnteros(int numero1, int numero2) 
//        {
//            //return numero1 + numero2;
//            int resultado;
//            resultado = numero1 + numero2;
//            return resultado;
//        }
//        //**************************
//        //Ejemplo: Quiero saber si el numero es par
//        public static bool EsPar(int numero)
//        {
//            //1-Paso a paso:
//            //bool esPar = false; //variable booleana que me diga que es par

//            //if (numero % 2 == 0)
//            //{
//            //    esPar = true;
//            //}
//            //return esPar;

//            //2-Modo ninja:
//            //return numero % 2 == 0;

//            //3-
//            if (numero % 2 == 0)
//            {
//                return true;
//            }
//            return false;
//        }
//        //*******************+
//        public static int PedirNumero(string mensaje)
//        {
//            int numero;
//            string lectura;
//            Console.Write(mensaje);
//            lectura = Console.ReadLine();

//            while (!int.TryParse(lectura, out numero))
//            {
//                Console.WriteLine("El dato ingresado no es un numero");
//                Console.Write(mensaje);
//                lectura = Console.ReadLine();
//            }
//            return numero;
//        }
//    }
//}
//**********************************************************
////Referencia de Repaso General a Libreria_de_funciones_2
////copio las funciones en Libreria_de_funciones_2
//using Libreria_de_funciones_2;
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int numero;
//            string pedido = "Ingrese su altura(cm): " ;
//            int suma;

//            numero = MisFunciones.PedirNumero(pedido);

//            if (MisFunciones.EsPar(numero))
//            {
//                Console.WriteLine($"El numero {numero} es par");
//            }
//            else
//            {
//                Console.WriteLine($"El numero {numero} es impar");
//            }
//            suma = MisFunciones.SumarEnteros(78,102);
//            Console.WriteLine(suma);
//        }
//    }
//}
//*********************VECTORES O ARRAYS*****************************
////Es una coleccion de varias variables del mismo tipo, con un mismo nombre
//using Libreria_de_funciones_2;
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //Ingrese 5 variables del mismo tipo
            
//            int[] numeros = new int [5];//INSTANCIAR

//            for (int i = 0; i < 5; i++) 
//            {
//                Console.WriteLine("Ingrese un numero: ");
//                numeros[i] = int.Parse(Console.ReadLine());

//            }
            
//            int[] otrosNumeros = {12,-58,89,75,0};//INICIALIZAR

//        }
//    }
//}
//****************************************
////Dos formas de recorrer el array: Usando for o Foreach
//using Libreria_de_funciones_2;
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] otrosNumeros = { 12, -58, 89, 75, 0 };//INICIALIZAR
            
//            //foreach (int numero in otrosNumeros)
//            //{
//            //    Console.WriteLine(numero);
//            //}
            
//            for (int i = 0; i < otrosNumeros.Length; i++)
//            {
//                Console.WriteLine(otrosNumeros[i]);
//            }
//            Array.Reverse(otrosNumeros);
            
//            for (int i = 0; i < otrosNumeros.Length; i++)
//            {
//                Console.WriteLine(otrosNumeros[i]);
//            }
            
//        }
//    }
//}
//**********************METODO DE ORDENAMIENTO-VARIABLE AUX********************
////
//using Libreria_de_funciones_2;
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] otrosNumeros = { 12, -58, 89, 75, 0 };//INICIALIZAR
//            int auxiliar;
//            Console.WriteLine("Array sin ordenar");

//            foreach (int numero in otrosNumeros)
//            {
//                Console.WriteLine(numero);
//            }

//            for (int i = 0; i < otrosNumeros.Length; i++)
//            {
//                for (int j= i + 1; j < otrosNumeros.Length; j++) 
//                {
//                    if(otrosNumeros[i] < otrosNumeros[j]) //Evaluar quien es mas chico
//                    {
//                        //Cambiar las posiciones
//                        auxiliar = otrosNumeros[i];
//                        otrosNumeros[i] = otrosNumeros[j];
//                        otrosNumeros[j] = auxiliar;
//                    }
//                }
//            }
//            Console.WriteLine("Array ordenado");
//            foreach (int numero in otrosNumeros)
//            {
//                Console.WriteLine(numero);
//            }
//        }
//    }
//}
//*********************ARRAY DE CHAR**************************
//using Libreria_de_funciones_2;
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            char[] palabra = {'m','a','n','z','a','n','a'};

//            foreach (char letra in palabra)
//            {
//                Console.WriteLine(letra);
//            }



//        }
//    }
//}
//****************CAMBIAR LETRA POR CARACTER**************************
////Quiero cambiar letra por un caracter distinto
//using Libreria_de_funciones_2;
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            char[] palabra = { 'm', 'a', 'n', 'z', 'a', 'n', 'a' };

//            for (int i = 0; i < palabra.Length; i++)
//            {
//                if (palabra[i] == 'a')
//                {
//                    palabra[i] = '#';
//                }
            
//            }

//            foreach (char item in palabra)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}
//***************************
////Quiero que la primer letra se transforme en mayuscula
//using Libreria_de_funciones_2;
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            char[] palabra = { 'm', 'a', 'n', 'z', 'a', 'n', 'a' };

//            for (int i = 0; i < palabra.Length; i++)
//            {
//                if (i == 0)
//                {
//                    palabra[i] = char.ToUpper(palabra[i]);
//                }

//                if (palabra[i] == 'a')
//                {
//                    palabra[i] = '#';
//                }

//            }

//            foreach (char item in palabra)
//            {
//                Console.Write(item);
//            }
//        }
//    }
//}
//***********************
//Si queremos que se convierta en mayuscula
//using Libreria_de_funciones_2;
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            char[] palabra = { 'm', 'a', 'n', 'z', 'a', 'n', 'a' };

//            for (int i = 0; i < palabra.Length; i++)
//            {
//                if (palabra[i] == 'a')
//                {
//                    palabra[i] = char.ToUpper(palabra[i]);
//                }
//            }

//            foreach (char item in palabra)
//            {
//                Console.Write(item);
//            }
//        }
//    }
//}
//*************************ARRAY DE STRING************************
//using Libreria_de_funciones_2;
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] palabra = { "mercado", "sandia", "casa" };

//            foreach (string item in palabra)
//            {
//                Console.WriteLine(item);
//            }

//        }
//    }
//}
//********************************************************************
//Queremos partirlas siempre que encuentre un guion.
using Libreria_de_funciones_2;
namespace Repaso_GRAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = "mercado-sandia-casa-coche";
            string[] palabras = frase.Split(['-', ' ']);
            //string[] palabras = frase.Split('-');

            foreach (string item in palabras)
            {
                Console.WriteLine(item);
            }
        }
    }
}