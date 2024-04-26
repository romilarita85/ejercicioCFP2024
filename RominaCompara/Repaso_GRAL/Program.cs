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
//-----------------------
namespace Repaso_GRAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i < 0; i++/* i =i+1, i +=1 */)
            {
                Console.WriteLine($"Vuelta n°{i} del for");
            }
            Console.WriteLine($"Valor de i: {i}");
            Console.WriteLine("-------------------------------------------");
            //captura 762
        }
    }
}
