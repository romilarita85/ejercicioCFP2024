//Ejercicio_Strings_5:
//Pedir el ingreso de nombre y apellido separado por un espacio,
//guardar cada dato en una variable diferente y asegurarse de que respete
//el formato de la primera letra en mayúscula y el resto en minúsculas,
//mostrar el apellido y el nombre por separado.
//ej: juAN ROBles(primero nombre luego apelido)
//imprimir:
//Apellido: Robles.
//Nombre: Juan.
namespace Ejercicio_Strings_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lectura = "Romina Compara";
            string[] palabras = lectura.Split(' ');
            //1-Tomar una variable de tipo string llamada lectura.
            //2-Utiliza el método Split para dividir esa cadena en subcadenas
            //más pequeñas.
            //3-Usa el espacio en blanco como delimitador para dividir la cadena
            //en palabras individuales.
            //4-Almacena estas palabras individuales en un arreglo de strings
            //llamado palabras.

            char[] vectorNombre = palabras[0].ToLower().ToCharArray();
            char[] vectorApellido = palabras[1].ToLower().ToCharArray();
        
             //Toma la primera palabra del arreglo palabras,
             //la convierte a minúsculas y luego la convierte
             //en un arreglo de caracteres,
             //que se almacena en la variable vectorNombre.

            vectorNombre[0] = char.ToUpper(vectorNombre[0]);
            vectorApellido[0] = char.ToUpper(vectorApellido[0]);
            //tomar el primer carácter del arreglo vectorNombre,
            //convertirlo a mayúsculas(si es una letra),
            //y luego asignar esta versión en mayúsculas de ese carácter
            //de vuelta al primer elemento del arreglo vectorNombre.
 
            string nombre = ""; //inicializan variables de tipo string con valores vacíos
            string apellido = string.Empty; //inicializan variables de tipo string con valores vacíos,

            foreach (char letra in vectorNombre)
            {
                nombre += letra;
            } 
            
            foreach (char letra in vectorApellido)
            {
                apellido += letra;
            }
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Apellido: {apellido}");
        }
    }
}
