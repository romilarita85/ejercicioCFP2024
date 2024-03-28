//Ejercicio 7.
//Ingresar 15 números y determinar: 
//a.    Suma de los negativos.
//b.	Suma de los positivos.
//c.	Cantidad de positivos.
//d.	Cantidad de negativos.
//e.	Cantidad de ceros.
//f.	Cantidad de números pares.
//g.	Promedio de positivos.
//h.	Promedio de negativos.
//i.	Diferencia entre positivos y negativos, (positivos - negativos). 
//j.	El número máximo
//k.	De los negativos el mínimo

namespace Ejericicio_7
    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int control = 0;
            int repeticiones = 15;//Definir limite Como Entero;
            int i; //Definir i Como Entero;
            int numeroIngresado;//Definir numeroIngresados Como Entero;
            int sumaNegativo = 0;//Definir sumaNegativo Como Entero; //acumulador
            int sumaPositivo = 0;//Definir sumaPositivo Como Entero;
            int cantidadNegativo = 0;//Definir cantidadNegativo Como Entero; // contador
            int cantidadPositivo = 0;//Definir cantidadPositivo Como Entero;
            int cantidadCeros = 0;//Definir cantidadCeros Como Entero;
            int cantidadPares = 0;//Definir cantidadPares Como Entero;
            int promedioNegativo;//Definir promedioNegativo Como Real;
            int promedioPositivo;//Definir promedioPositivo Como Real;
            int diferenciaEntreNumeros;//Definir diferenciaEntreNumeros Como Entero;
            int numeroMaximo;//Definir numeroMaximo Como Entero;
            int numeroMiminoNegativo;//Definir numeroMinimoNegativo Como Entero;
            String banderaPrimerNegativo = "vacio";//Definir banderaPrimerNegativo Como caracter;
       
            for (i=0;i >repeticiones; i++)
            {
                Console.WriteLine($"Ingrese el numero {i} de  {repeticiones}");
                //Console.int.Parse(numeroIngresado);
            }
            if (numeroIngresado > 0) //todos los positivos
            {
                sumaPositivo = sumaPositivo + numeroIngresado; // acumulador
                cantidadPositivo = cantidadPositivo + 1; // contador siempre suma un numero fijo y constante
            }
            else 
            {
                if (numeroIngresado < 0) //todos los negativos
                {
                    sumaNegativo = sumaNegativo + numeroIngresado;
                }
                cantidadNegativo = cantidadNegativo + 1;
                ////Para hacer el punto ->(k-De los negativos el mínimo)
                //si cantidadNegativo == 1 O numeroIngresados < numeroMinimoNegativo Entonces //cantidadNegativo (contador) actua como variable de control
                //					numeroMinimoNegativo = numeroIngresados;

                 //FinSi

            }
            Console.WriteLine($"Valor del control despues del bucle {i}");

        }
    }
}

	



//		si numeroIngresados % 2 == 0 Y numeroIngresados <> 0 Entonces //numeros pares
//			cantidadPares = cantidadPares + 1;
//FinSi

//// El numero maximo , en este caso i (variable de control me indica cual es el primer numero ingresado)

//si i == 1 O numeroIngresados > numeroMaximo Entonces
//			numeroMaximo = numeroIngresados;

//FinSi

////De los negativos el mínimo

////si (numeroIngresados < 0 Y banderaPrimerNegativo =="vacio") O (numeroIngresados < 0 Y numeroIngresados<numeroMinimoNegativo) Entonces 
////aca ingresa el primer numero negativo para eso declaro una bancera, se utiliza siempre para comparar

////numeroMinimoNegativo = numeroIngresados;
////banderaPrimerNegativo ="lleno"; 


////FinSi

//Fin Para
	
//	//PROMEDIOS: se calculan por fuera del bucle repetitivo salvo excepciones
	
//	si cantidadPositivo <> 0 Entonces //el promedio es importante que no se divida por cero
//		promedioPositivo = sumaPositivo /cantidadPositivo;
//Imprimir "El promedio de los numeros positivos es : ", promedioPositivo;
//SiNo
//    promedioPositivo = 0;
//Imprimir "El promedio de los numeros positivos no se puede mostrar dado que no se ingresaron positivos ";
//FinSi

//si cantidadNegativo <> 0 Entonces //el promedio es importante que no se divida por cero
//		promedioNegativo = sumaNegativo / cantidadNegativo;
//Imprimir "El minimo de los numeros negativos es : ", numeroMinimoNegativo; //k-De los minimos el negativo
//Imprimir "El promedio de los numeros negativos es : ", promedioNegativo;
//SiNo
//    promedioNegativo = 0;
//Imprimir "El promedio y el minimo de los numeros negativos no se puede mostrar dado que no se ingresaron negativos ";
//FinSi

////Diferencia entre positivos y negativos, (positivos-negativos). 
//diferenciaEntreNumeros = sumaPositivo + sumaNegativo; //le descuento los negativos

//Imprimir "El valor de la suma de los negativos es : ", sumaNegativo;
//Imprimir "El valor de la suma de los positivos es : ", sumaPositivo;
//Imprimir "La cantidad de los numeros positivos son : ", cantidadPositivo;
//Imprimir "La cantidad de los numeros negativos son : ", cantidadNegativo;
//Imprimir "La diferencia entre numeros positivos y negativos es de : ", diferenciaEntreNumeros;
//Imprimir "El numero maximo ingresado es : ", numeroMaximo;
//Imprimir "La cantidad de numeros pares es : ", cantidadPares;
//Imprimir "La cantidad de ceros es : ", cantidadCeros;


//FinAlgoritmo
