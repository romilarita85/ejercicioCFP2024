//Ejercicio_Vectores_7:
//Crear 3 vectores. En los primeros dos pedirle al usuario que cargue valores.
//El tercer vector deberá guardar el valor más grande como resultado de la comparación de los otros dos.
//Por ej: 
//Vector a	Vector b	Vector c
//5	          9	            9
//4	          3	            4
//2	          10	       10
//9	          9	            9
//3	          1	            3
namespace Ejercicio_Vectores_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definir la longitud de los vectores
            int longitud = 5;

            // Crear los tres vectores
            int[] vectorA = new int[longitud];
            int[] vectorB = new int[longitud];
            int[] vectorC = new int[longitud];
            // Pedir al usuario que ingrese los valores para los vectores A y B
            Console.WriteLine("Ingrese los valores numericos para el vector A:");
            LeerVector(vectorA);

            Console.WriteLine("Ingrese los valores numericos para el vector B:");
            LeerVector(vectorB);

            // Comparar los valores de los vectores A y B y
            // guardar el valor más grande en el vector C
            for (int i = 0; i < longitud; i++)
            {//[i]= indica la posicion
                if (vectorA[i] >= vectorB[i]) // vectorA es mayor o igual a vectorB
                {
                    vectorC[i] = vectorA[i]; // VectorC toma el valor de VectorA
                }
                else //vectorA es menor a VectorB
                {
                    vectorC[i] = vectorB[i]; // VectorC toma el valor de VectorB
                }
            }
            // Mostrar los valores de los tres vectores
            Console.WriteLine("************Valores de los vectores:************");
            MostrarVector("***Vector A:***", vectorA);
            MostrarVector("***Vector B:***", vectorB);
            MostrarVector("***Vector C:***", vectorC);
        }
        // Método para leer valores y cargar un vector
        static void LeerVector(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($"Valor {i + 1}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }
        }
        static void MostrarVector(string mensaje, int[] vector)
        {
            Console.WriteLine(mensaje);
            
            foreach (var valor in vector)
            {
                Console.WriteLine($" {valor}");
            }
            Console.WriteLine();
        }
    }
}
