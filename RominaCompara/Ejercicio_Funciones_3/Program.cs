//Ejercicio_Funciones_3:
//Se requiere la creación de una función que cumpla con los siguientes requisitos:
//La función debe recibir tres parámetros: 'valor'(numérico), 'porcentaje'(numérico) y
//'esAumento' (booleano).
//-Si el parámetro 'esAumento' es verdadero, la función
//debe aumentar el 'valor' original aplicando el 'porcentaje' dado. 
//-Si el parámetro 'esAumento' es falso, la función debe disminuir
//el 'valor' original aplicando el 'porcentaje' dado. 
//-El resultado obtenido después de aplicar el porcentaje al 'valor' original
//debe ser retornado por la función.
namespace Ejercicio_Funciones_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double valorOriginal = 100;
            double porcentaje = 10; // 10% de aumento o disminución
            bool esAumento = true; // Indica si es un aumento o una disminución

            double nuevoValor = CalcularPorcentajeNum(valorOriginal, porcentaje, esAumento);
            Console.WriteLine("El nuevo valor es: " + nuevoValor);
        }

        public static double CalcularPocentajeNum(double valor, double porcentaje, bool esAumento)
        {
            if (esAumento)
            {
             //-Si el parámetro 'esAumento' es verdadero, la función
             //debe aumentar el 'valor' original aplicando el 'porcentaje' dado.
                return valor * (1 + (porcentaje / 100));
            }
            else
            {
             //-Si el parámetro 'esAumento' es falso, la función debe disminuir
             //el 'valor' original aplicando el 'porcentaje' dado. 
                return valor * (1 - (porcentaje / 100));
            }
        }
    }
}
