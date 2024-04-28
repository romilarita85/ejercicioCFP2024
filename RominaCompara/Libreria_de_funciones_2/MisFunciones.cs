namespace Libreria_de_funciones_2
{
    public class MisFunciones
    {
        public static int PedirNumero(string mensaje)
        {
            int numero;
            string lectura;
            Console.Write(mensaje);
            lectura = Console.ReadLine();

            while (!int.TryParse(lectura, out numero))
            {
                Console.WriteLine("El dato ingresado no es un numero");
                Console.Write(mensaje);
                lectura = Console.ReadLine();
            }
            return numero;
        }
        public static bool EsPar(int numero)
        {
            bool esPar = false; //variable booleana que me diga que es par

            if (numero % 2 == 0)
            {
                esPar = true;
            }
            return esPar;
        }
        public static int SumarEnteros(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
    }
}
