//FUNCIONES CON VECTORES:------------------------------------
//
//Ejercicio_Vectores_1:
//Cargar un vector de enteros de 5 elementos y mostrarlo.
//-----------------------------------------------------------
//namespace Ejercicio_Vectores_1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] misNumeros = new int[5];
//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine($"Ingrese el numero {i + 1} de 5: ");
//                misNumeros[i] = int.Parse(Console.ReadLine());
//            }

//            foreach (int numero in misNumeros)
//            {
//                Console.WriteLine(numero);
//            }
//        }
//        static int[] CargarArrayDeEnteros()
//        {
//            int[] numeros = new int[5];
//            for(int i = 0; i<5; i++)
//            {
//                Console.WriteLine($"Ingrese el nunero {i + 1} de 5: ");
//                numeros[i] = int.Parse(Console.ReadLine());

//            }
//            return numeros;

//        }
//    }
//}
//---------------//--------------------//--------------------------//---------------------------//
///Cargar un vector de enteros de 5 elementos y mostrarlo.
//namespace Ejercicio_Vectores_1
//{
//    internal class program
//    {
//        static void main(string[] args)
//        {
//            int[] misnumeros = CargarArrayDeEnteros(5);
//            foreach (int numero in misnumeros)
//            {
//                Console.WriteLine(numero);
//            }
//        }
//        static int[] CargarArrayDeEnteros(int cantidad)//lo que recibe-parametros
//        {
//            int[] numeros = new int[cantidad];
//            for (int i = 0; i < cantidad; i++)
//            {
//                numeros[i] = PedirEntero($"ingrese el nunero {i + 1} de {cantidad}: ", "el dato ingresado no es un numero");
//            }
//            return numeros;
//        }
//        static int PedirEntero(string mensaje, string mensajeError)
//        {
//            int numeroValido;
//            string numeroLeido;
//            numeroLeido = PedirCadena(mensaje);

//            while (!int.TryParse(numeroLeido, out numeroValido))
//            {
//                Console.WriteLine(mensajeError);
//                numeroLeido = PedirCadena(mensaje);
//            }
//            return numeroValido;
//        }
//        static string PedirCadena(string mensaje)
//        {
//            Console.Write(mensaje);
//            return Console.ReadLine();
//        }
//    }
//}
//-------------//--------/--------//--------/----------//-------/--------//----------//---------------//
//namespace Ejercicio_Vectores_1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] misNumeros = CargarArrayDeEnteros(7);
//        }
//        static int[] CargarArrayDeEnteros(int cantidad)//lo que recibe-parametros
//        {
//            int[] numeros = new int[cantidad];
//            for (int i = 0; i < cantidad; i++)
//            {
//                numeros[i] = PedirEntero($"Ingrese el nunero {i + 1} de {cantidad}: ", "El dato ingresado no es un numero");
//            }
//            return numeros;
//        }
//        static int PedirEntero(string mensaje, string mensajeError)
//        {
//            int numeroValido;
//            string numeroLeido;
//            numeroLeido = PedirCadena(mensaje);

//            while (!int.TryParse(numeroLeido, out numeroValido))
//            {
//                Console.WriteLine(mensajeError);
//                numeroLeido = PedirCadena(mensaje);
//            }
//            return numeroValido;
//        }
//        static string PedirCadena(string mensaje)
//        {
//            Console.Write(mensaje);
//            return Console.ReadLine();
//        }
//    }
//}
//-----//----------------//--------------//-----------------//------------------//
//namespace Ejercicio_Vectores_1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] misNumeros = CargarArrayDeEnteros(7);
//            int[] otrosNumeros = CargarArrayDeEnteros(5);
//            Console.WriteLine("****elementos del array misNumeros****");
//            ImprimirArray(misNumeros);
//            Console.WriteLine("****elementos del array otrosNumeros***");
//            ImprimirArray(otrosNumeros);
//        }
//        //--Mientras estemos dentro del main nuestras funciones van a ser static
//        static int[] CargarArrayDeEnteros(int cantidad)//lo que recibe-parametros
//        {
//            int[] numeros = new int[cantidad];
//            for (int i = 0; i < cantidad; i++)
//            {
//                numeros[i] = PedirEntero($"Ingrese el nunero {i + 1} de {cantidad}: ", "El dato ingresado no es un numero");
//            }
//            return numeros;
//        }
//        static int PedirEntero(string mensaje, string mensajeError)
//        {
//            int numeroValido;
//            string numeroLeido;
//            numeroLeido = PedirCadena(mensaje);

//            while (!int.TryParse(numeroLeido, out numeroValido))
//            {
//                Console.WriteLine(mensajeError);
//                numeroLeido = PedirCadena(mensaje);
//            }
//            return numeroValido;
//        }
//        static string PedirCadena(string mensaje)
//        {
//            Console.Write(mensaje);
//            return Console.ReadLine();
//        }
//        static void ImprimirArray(int[] misNumeros) 
//        {
//            foreach (int numero in misNumeros) 
//            {
//                Console.WriteLine(numero);
//            }
//        }
//    }
//}
//-------//----------//-------//--------//----------//----------//------------//------------
///ARRAY REVERSE-------------------------------------------
//namespace Ejercicio_Vectores_1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] misNumeros = CargarArrayDeEnteros(5);

//            ImprimirArray("****elementos del array misNumeros****", misNumeros);
//            Array.Reverse(misNumeros);
//            ImprimirArray("****elementos del array misNumeros dados vuelta****", misNumeros);
//            Array.Reverse(misNumeros);
//            ImprimirArray("****elementos del array misNumeros dados vuelta por 2° vez****", misNumeros);
//        }
//        static int[] CargarArrayDeEnteros(int cantidad)//lo que recibe-parametros
//        {
//            int[] numeros = new int[cantidad];
//            for (int i = 0; i < cantidad; i++)
//            {
//                numeros[i] = PedirEntero($"Ingrese el nunero {i + 1} de {cantidad}: ", "El dato ingresado no es un numero");
//            }
//            return numeros;
//        }
//        static int PedirEntero(string mensaje, string mensajeError)
//        {
//            int numeroValido;
//            string numeroLeido;
//            numeroLeido = PedirCadena(mensaje);

//            while (!int.TryParse(numeroLeido, out numeroValido))
//            {
//                Console.WriteLine(mensajeError);
//                numeroLeido = PedirCadena(mensaje);
//            }
//            return numeroValido;
//        }
//        static string PedirCadena(string mensaje)
//        {
//            Console.Write(mensaje);
//            return Console.ReadLine();
//        }
//        static void ImprimirArray(string titulo, int[] misNumeros)
//        {
//            Console.WriteLine(titulo);
//            foreach (int numero in misNumeros)
//            {
//                Console.WriteLine(numero);
//            }
//        }
//    }
//}
//---------------------------------------------------------
///Usando Suma de valores: valorSuma ----------------------
//namespace Ejercicio_Vectores_1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] misNumeros = CargarArrayDeEnteros(5);
//            int valorSuma = SumaValoresArrayEnteros(misNumeros);

//            ImprimirArray("Los numeros ingresados son: ", misNumeros);
//            Console.WriteLine($"El valor de la suma es: {valorSuma}");
//        }
//        static int[] CargarArrayDeEnteros(int cantidad)//lo que recibe-parametros
//        {
//            int[] numeros = new int[cantidad];
//            for (int i = 0; i < cantidad; i++)
//            {
//                numeros[i] = PedirEntero($"Ingrese el nunero {i + 1} de {cantidad}: ", "El dato ingresado no es un numero");
//            }
//            return numeros;
//        }
//        static int PedirEntero(string mensaje, string mensajeError)
//        {
//            int numeroValido;
//            string numeroLeido;
//            numeroLeido = PedirCadena(mensaje);

//            while (!int.TryParse(numeroLeido, out numeroValido))
//            {
//                Console.WriteLine(mensajeError);
//                numeroLeido = PedirCadena(mensaje);
//            }
//            return numeroValido;
//        }
//        static string PedirCadena(string mensaje)
//        {
//            Console.Write(mensaje);
//            return Console.ReadLine();
//        }
//        static void ImprimirArray(string titulo, int[] misNumeros)
//        {
//            Console.WriteLine(titulo);
//            foreach (int numero in misNumeros)
//            {
//                Console.WriteLine(numero);
//            }
//        }
//        static int SumaValoresArrayEnteros(int[] misNumeros) 
//        {
//            int suma = 0;
//            foreach (int numero in misNumeros) 
//            {
//                suma += numero;
//            }
//            return suma;
//        }
//    }
//}
//--------------//---------------//---------------//-------------//-----------------//
///Usando Suma de valores y Promedio:-----------------------
//namespace Ejercicio_Vectores_1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] misNumeros = CargarArrayDeEnteros(5);
//            int valorSuma = SumaValoresArrayEnteros(misNumeros);
//            double promedio = CalcularPromedioArrayEnteros(misNumeros);
//            ImprimirArray("Los numeros ingresados son: ", misNumeros);
//            Console.WriteLine($"El valor de la suma es: {valorSuma}");
//            Console.WriteLine($"El valor del promedio es: {promedio}");
//        }
//        static int[] CargarArrayDeEnteros(int cantidad)//lo que recibe-parametros
//        {
//            int[] numeros = new int[cantidad];
//            for (int i = 0; i < cantidad; i++)
//            {
//                numeros[i] = PedirEntero($"Ingrese el nunero {i + 1} de {cantidad}: ", "El dato ingresado no es un numero");
//            }
//            return numeros;
//        }
//        static int PedirEntero(string mensaje, string mensajeError)
//        {
//            int numeroValido;
//            string numeroLeido;
//            numeroLeido = PedirCadena(mensaje);

//            while (!int.TryParse(numeroLeido, out numeroValido))
//            {
//                Console.WriteLine(mensajeError);
//                numeroLeido = PedirCadena(mensaje);
//            }
//            return numeroValido;
//        }
//        static string PedirCadena(string mensaje)
//        {
//            Console.Write(mensaje);
//            return Console.ReadLine();
//        }
//        static void ImprimirArray(string titulo, int[] misNumeros)
//        {
//            Console.WriteLine(titulo);
//            foreach (int numero in misNumeros)
//            {
//                Console.WriteLine(numero);
//            }
//        }
//        static int SumaValoresArrayEnteros(int[] misNumeros)
//        {
//            int suma = 0;
//            foreach (int numero in misNumeros)
//            {
//                suma += numero;
//            }
//            return suma;
//        }
//        static double CalcularPromedioArrayEnteros(int[] misNumeros)
//        {
//            int suma = 0;
//            double resultado;
//            foreach (int numero in misNumeros)
//            {
//                suma += numero;
//            }
//            resultado = suma / misNumeros.Length;
//            return resultado;
//        }
//    }
//}
//----------//------------//------------//----------//------------//-------------------------
///Otro ejemplo usando suma y promedio:----------------
//namespace Ejercicio_Vectores_1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] misNumeros = CargarArrayDeEnteros(5);
//            ImprimirArray("Los numeros ingresados son: ", misNumeros);
//            Console.WriteLine($"El valor de la suma es: {SumaValoresArrayEnteros(misNumeros)}");
//            Console.WriteLine($"El valor del promedio es: {CalcularPromedioArrayEnteros(misNumeros)}");
//        }
//        static int[] CargarArrayDeEnteros(int cantidad)//lo que recibe-parametros
//        {
//            int[] numeros = new int[cantidad];
//            for (int i = 0; i < cantidad; i++)
//            {
//                numeros[i] = PedirEntero($"Ingrese el nunero {i + 1} de {cantidad}: ", "El dato ingresado no es un numero");
//            }
//            return numeros;
//        }
//        static int PedirEntero(string mensaje, string mensajeError)
//        {
//            int numeroValido;
//            string numeroLeido;
//            numeroLeido = PedirCadena(mensaje);

//            while (!int.TryParse(numeroLeido, out numeroValido))
//            {
//                Console.WriteLine(mensajeError);
//                numeroLeido = PedirCadena(mensaje);
//            }
//            return numeroValido;
//        }
//        static string PedirCadena(string mensaje)
//        {
//            Console.Write(mensaje);
//            return Console.ReadLine();
//        }
//        static void ImprimirArray(string titulo, int[] misNumeros)
//        {
//            Console.WriteLine(titulo);
//            foreach (int numero in misNumeros)
//            {
//                Console.WriteLine(numero);
//            }
//        }
//        static int SumaValoresArrayEnteros(int[] misNumeros)
//        {
//            int suma = 0;
//            foreach (int numero in misNumeros)
//            {
//                suma += numero;
//            }
//            return suma;
//        }
//        static double CalcularPromedioArrayEnteros(int[] misNumeros)
//        {
//            int suma = 0;
//            double resultado;
//            foreach (int numero in misNumeros)
//            {
//                suma += numero;
//            }
//            resultado = (double)suma / misNumeros.Length;
//            return resultado;
//        }
//    }
//}
//-----------//---------//---------------//------------------//----------------//----------------
//Creaciones de contenedor "Libreria de funciones":--------------------------------------------
//1)-Crear un contenedor dentro de nuestras funciones-> dentro del proyecto
//Proyecto biblioteca de clases-> class library
//2)-Hacer que el proyecto conozca el contenedor->Hacer una REFERENCIA-> proyect reference 
//dentro del proyecto "funcionesConVectores"
//3)-Quiero que utilicen una referencia "LibreriaDeFunciones"->Using
//Using LibreriaDeFunciones ->dentro del proyecto "FuncionesConVectores"
//4)-Visibilidad de funciones:en libreria de funciones->Todas las referencias van a ser publicas
//5)-Las clases tambien tienen que ser static
//6)-Agregar clase dentro del proyecto "FuncionesConVectores"-> clase - "MisFunciones"
using LibreriaDeFunciones;
namespace FuncionesConVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] misNumeros = MisFunciones.CargarArrayDeEnteros(5);
            int valorSuma = MisFunciones.SumaValoresArrayEnteros(misNumeros);
            double promedio = MisFunciones.CalcularPromedioArrayEnteros(misNumeros);
            MisFunciones.ImprimirArray("Los numeros ingresados son: ", misNumeros);
            Console.WriteLine($"El valor de la suma es: {valorSuma}");
            Console.WriteLine($"El valor del promedio es: {promedio}");
            MisFunciones.ImprimirArrayAlreves("Imprimiendo Array alreves", misNumeros);
        }
    }
}
