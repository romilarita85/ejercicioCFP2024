//Ejercicio_Vectores_6.	Ingresar números en un vector, pueden ser positivos o negativos.
//Mostrar los negativos de forma creciente y los positivos de forma decreciente.
//Ejemplo:
//Vector ingresado: { 5, 1, -9, -1, 9, 3, -2, 2}
//Vector ordenado: { -9, -2, -1, 9, 5, 3, 2, 1}
using LibreriaDeFunciones;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace OtrasFuncionesConArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] misNumeros = MisFunciones.CargarArrayDeEnteros(5);
            //MisFunciones.ImprimirArray("Elementos de mis Array", misNumeros);
            //misNumeros = MisFunciones.OrdenarMayor(misNumeros);
            //MisFunciones.ImprimirArray("Elementos de mis Array ordenados de menor a mayor", misNumeros);
            //misNumeros = MisFunciones.OrdenarMenor(misNumeros);
            //MisFunciones.ImprimirArray("Elementos de mis Array ordenados de mayor a menor", misNumeros);
            
            int[] misNumeros = MisFunciones.CargarArrayDeEnteros(8);
            //MisFunciones.OrdenarMenor(misNumeros);
            MisFunciones.OrdenarPorCriterio(misNumeros,true);
            MisFunciones.MostrarPorCriterio("Positivos en forma creciente", misNumeros,true);
            //MisFunciones.OrdenarMayor(misNumeros);
            MisFunciones.OrdenarPorCriterio(misNumeros, false);
            MisFunciones.MostrarPorCriterio("Negativos en forma decreciente", misNumeros,false);
        }

    }
}
//-----------------------------------------------------------------------------
//﻿using LibreriaDeFunciones;

//namespace OtrasFuncionesConArrays
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            /*
//             Ingresar números en un vector, pueden ser positivos o negativos. 
//             Mostrar los negativos de forma creciente y los positivos de forma decreciente.
//             Ejemplo: 
//             Vector ingresado: {5, 1, -9, -1, 9, 3, -2, 2}
//             Vector ordenado: {-9, -2, -1, 9, 5, 3, 2, 1}
//             */

//            int[] misNumeros = MisFunciones.CargarArrayDeEnteros(8);

//            MisFunciones.OrdenarPorCriterio(misNumeros, true);
//            MisFunciones.MostrarPorCriterio("Positivos en forma creciente", misNumeros, true);
//            MisFunciones.OrdenarPorCriterio(misNumeros, false);
//            MisFunciones.MostrarPorCriterio("Negativos en forma decreciente", misNumeros, false);
//        }
//    }
//}
