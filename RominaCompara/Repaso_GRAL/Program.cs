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
//
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
//----------------------------------------------------------------------------
namespace Repaso_GRAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            string lectura;

            Console.Write("Ingrese su edad: ");
            lectura = Console.ReadLine();
           
            int.TryParse(lectura,out edad);

            if ()
            {
                Console.WriteLine($"Edad ingresada es: {edad}");
            }
            else 
            {
                Console.WriteLine("El dato ingresado es incorrecto");
            }

        }//captua 704
    }
}
