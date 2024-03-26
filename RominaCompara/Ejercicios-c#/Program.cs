//Metodos de: 
//-Entrada: Console.ReadLine (Lectura)
//-Salida: Console.Write.Line(escritura)

//Variables: 
//1-CARACTER: Letras o cadenas = STRING
//2-REAL: Numeros decimales = FLOAT-DOUBLE-DECIMAL
//3-NUMERO: Numeros enteros = NT-INT16-INT32-INT8
//4-LOGICA: Boleanos (true o false) = BOOL = true o false
//----------------------------------------------------------------------------------
//-Un dato "STRING" se puede convertir en numerico solo si esta escrito el caracter 
//de forma numerica (si solo tiene numeros usamos INT)
//----------------------------------------------------------------------------------
//namespace Ejercicios_c_
////Crear String
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            String nombre;
//            Console.WriteLine("Ingrese su nombre: ");
//            nombre = Console.ReadLine();

//            Console.WriteLine("Bienvenido/a "+ nombre);
//            //Uso operador + para concatenacion
//            //Si queremos usar variables tenemos que declararlas !!NO PUEDO USAR 
//            //VARIABLES QUE NO ESTAN DECLARADAS!!
//            //Todas las lineas de codigo deben terminar en ";"
//            //Todos los metodos van a tener parentesis
//        }
//    }
//}
//------------------------------------------------------------------------------
//namespace Ejercicios_c_2
////Ingrese su nombre y apellido
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            String nombre;
//            String apellido;
//            Console.WriteLine("Ingrese su nombre: ");
//            nombre = Console.ReadLine();

//            Console.WriteLine("Ingrese su apellido: ");
//            apellido = Console.ReadLine();

//            Console.WriteLine("Bienvenido/a " + nombre + " " + apellido);
           
//        }
//    }
//}
//---------------------------------------------------------------------------

//Convertir texto a un numero entero
namespace Ejercicios_c_3

{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            String apellido;
            String edadTexto;
            int edadNumerica;

            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su apellido: ");
            apellido = Console.ReadLine();

            Console.WriteLine("Ingrese su edad: ");
            //Uso PARSE para para guardar un dato numerico STRING-leer algo como numero y
            //convertirlo en cadena.
            edadTexto = Console.ReadLine();
            edadNumerica = int.Parse(edadTexto);
            //Formas de concatenar:
            //1-Concatenar Con signos
            //Console.WriteLine("Bienvenido/a " + nombre + " " + apellido + " ud.tiene " + edadNumerica + " años.");

            //2-Concatenar con llaves (la primer posicion siempre es cero)
            //Console.WriteLine("Bienvenido/a {0} {1}, ud.tiene: {2}  años. ", nombre,apellido,edadNumerica);

            //3-Concatenacion interpolada:
            Console.WriteLine($"Bienvenido/a {nombre} {apellido}, ud.tiene: {edadNumerica}  años. ");

        }
    }
}
