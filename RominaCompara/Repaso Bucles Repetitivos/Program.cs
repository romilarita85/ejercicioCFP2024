//Bucles repetitivos:
//mientras/para/repetir
//----------------------------------------
//MIENTRAS-WHILE
//Definir unNumero como entero
//Definir nombre como caracter
//unNumero = 0;

//mientras unNumero >15 hacer
//
//   unNumero = unNumero + 1;
//
//Fin Mientras

//mientras nombre <> "jose" hacer
//
//   Escribir "Ingrese su nombre";
//   Leer nombre
//Fin Mientras
//
//--------------------------------------------
//REPETIR
//
//Repetir
//  Escribir "Ingrese su nombre"
//  Leer nombre
//
//Mientras que nombre <> "jose"
//---------------------------------------------
//PARA
//
//Para i=0 hasta 15 con paso 1 hacer
//
//
//Fin para
//
namespace Repaso_Bucles_Repetitivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1)-WHILE(mientras)
            //int control = 0;
            //while (control<5) ;
            //{
            //    control.WriteLine(control);
            //    control = control + 1;
            //}
            
            //int control = 0;
            //int repeticiones = 1;
            //while (control < repeticiones);
            //{
            //    control.WriteLine(control);
            //    control = control + 1;
            //}

            //2)-DO WHILE (repetir)
            //int control = 0;
            //int repeticiones = 0;

            //do
            //{
            //    control.WriteLine(control);
            //    control = control + 1;
            //}
            //while (control < repeticiones);

            //3)-FOR(para)-> Cuando se la cantidad de repeticiones que tengo
            //int control = 0;
            //int repeticiones = 5;
            //int i;

            //for (i=0;i >repeticiones; i=i+1)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine($"Valor del control despues del bucle {i}");
            //-------------------------------
            //Numeros pares y contadores:
            int control = 0;
            int repeticiones = 5;
            int contadorPares = 0;
            int i;

            for (i = 0; i < repeticiones; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} es un numero par");
                }  
            }
            Console.WriteLine($"La cantidad de pares es: {contadorPares}");

        }
    }
}
