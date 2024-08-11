using BibliotecaDeComputadoras;
namespace Testeo_Computadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string programas = "office - winrar - spotify";
            Computadora pc = new Computadora(240, 16,"I5", "Windows");
            
             
            Console.WriteLine($"Valores antes de usar el metodo - cantidad de elementos de la lista {pc.GetProgramas().Count}");
            
            pc.CargarProgramasDesdeUnString(programas);

            Console.WriteLine($"Valores despues de usar el metodo - cantidad de elementos de la lista {pc.GetProgramas().Count}");
            //foreach (string item in pc.GetProgramas())
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
//
//using BibliotecaDeComputadoras;
//namespace Testeo_Computadora
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string programas = "office - winrar - spotify";
//            Computadora pc = new Computadora(240, 16, "I5", "Windows");

//            pc.CargarProgramasDesdeUnString(programas);

//            foreach (string item in pc.GetProgramas())
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}