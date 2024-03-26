//namespace Repaso_Condicionales
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int edad = 15;
//            if (edad < 18) 
//            {
//                Console.WriteLine("Es menos de edad");
//            }
//            else 
//            {
//                Console.WriteLine("Es mayor de edad");
//            }

//        }
//    }
//}
//namespace Repaso_Condicionales
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //Genero sea hombre
//            //Edad sea mayor o igual a 18
//            int edad = 20;
//            String genero = "mujer";

//            if (edad < 18 && genero == "mujer")
//            {
//                Console.WriteLine("Es una mujer mayor de edad");
//            }
//            else
//            {
//                Console.WriteLine("Es mayor y no es mujer");
//            }


//        }
//    }
//}

//---------------ANIDAMIENTO--------------------
//namespace Repaso_Condicionales
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //Genero sea hombre
//            //Edad sea mayor o igual a 18
//            int edad = 20;
//            String genero = "mujer";

//            if (genero == "mujer")
//            {
//                if (edad > 18) 
//                {
//                    Console.WriteLine("Es una mujer mayor de edad");
//                }
//                else 
//                {
//                    Console.WriteLine("Es una niña");
//                }
//            }
//            else
//            {
//                Console.WriteLine("No es mujer");
//            }

//            if (edad < 18 && genero == "mujer") 
//            {
//                Console.WriteLine("es niña");
//            }
//            else 
//            {
//                if (genero == "mujer" && edad >= 18) 
//                {
//                    Console.WriteLine("Es una mujer mayor de edad");
//                }
//                else 
//                {
//                    Console.WriteLine("No es mujer");
//                }
//            }
//        }
//    }
//}
//---------------------
using System.ComponentModel.Design;

namespace Ejercicios_c_3
//Al ingresar una edad menor a 18 años y un estado civil distinto a soltero,
//mostrar el mensaje: “Es muy pequeño para NO ser soltero”
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            String estadoCivil;
            String edadTexto;

            Console.WriteLine("Ingrese su edad: ");
            edadTexto = Console.ReadLine();
            edad = int.Parse(edadTexto);
            Console.WriteLine("Ingrese su estado civil: ");
            estadoCivil = Console.ReadLine();

            if (edad>18 && estadoCivil == "casado") ;
            {
                Console.WriteLine("Es muy pequeño para no ser soltero");
            }
            
            
            
        }
    }
}
//CONDICIONAL:-----------------------------
//if (true);
//{
//    //codigo que cumpla la condicion
//}
//else(false)
//{
//    //descarte del ig
//}
//-------------------------------------------

