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
            int repeticiones = 15;
            int i;
            int numeroIngresado;


            for (i=0;i >repeticiones; i++)
            {
                Console.WriteLine(i);


            }
            Console.WriteLine($"Valor del control despues del bucle {i}");

        }
    }
}
Definir i Como Entero;
Definir limite Como Entero;
Definir numeroIngresados Como Entero;
Definir sumaNegativo Como Entero; //acumulador
Definir sumaPositivo Como Entero;
Definir cantidadNegativo Como Entero; // contador
Definir cantidadPositivo Como Entero;
Definir cantidadCeros Como Entero;
Definir cantidadPares Como Entero;
Definir promedioNegativo Como Real;
Definir promedioPositivo Como Real;
Definir diferenciaEntreNumeros Como Entero;
Definir numeroMaximo Como Entero;
Definir numeroMinimoNegativo Como Entero;
Definir banderaPrimerNegativo Como caracter;


limite = 5;
sumaNegativo = 0;
sumaPositivo = 0;
cantidadNegativo = 0;
cantidadPositivo = 0;
cantidadCeros = 0;
cantidadPares = 0;
banderaPrimerNegativo = "vacio";


Para i = 1 Hasta limite Con Paso 1 Hacer
		Escribir "Ingrese el número ", i, " de ", limite;
Leer numeroIngresados;

Si numeroIngresados > 0 Entonces //todos los positivos
			
			sumaPositivo = sumaPositivo + numeroIngresados; // acumulador
cantidadPositivo = cantidadPositivo + 1; // contador siempre suma un numero fijo y constante 

SiNo
    si	numeroIngresados < 0 Entonces // todos los negativos
				
				sumaNegativo = sumaNegativo + numeroIngresados;
cantidadNegativo = cantidadNegativo + 1;

//Para hacer el punto ->(k-De los negativos el mínimo)
si cantidadNegativo == 1 O numeroIngresados < numeroMinimoNegativo Entonces //cantidadNegativo (contador) actua como variable de control
					numeroMinimoNegativo = numeroIngresados;

FinSi
SiNo 
				cantidadCeros = cantidadCeros + 1; //cantidad de ceros
FinSi
FinSi
		
		si numeroIngresados % 2 == 0 Y numeroIngresados <> 0 Entonces //numeros pares
			cantidadPares = cantidadPares + 1;
FinSi

// El numero maximo , en este caso i (variable de control me indica cual es el primer numero ingresado)

si i == 1 O numeroIngresados > numeroMaximo Entonces
			numeroMaximo = numeroIngresados;

FinSi

//De los negativos el mínimo

//si (numeroIngresados < 0 Y banderaPrimerNegativo =="vacio") O (numeroIngresados < 0 Y numeroIngresados<numeroMinimoNegativo) Entonces 
//aca ingresa el primer numero negativo para eso declaro una bancera, se utiliza siempre para comparar

//numeroMinimoNegativo = numeroIngresados;
//banderaPrimerNegativo ="lleno"; 


//FinSi

Fin Para
	
	//PROMEDIOS: se calculan por fuera del bucle repetitivo salvo excepciones
	
	si cantidadPositivo <> 0 Entonces //el promedio es importante que no se divida por cero
		promedioPositivo = sumaPositivo /cantidadPositivo;
Imprimir "El promedio de los numeros positivos es : ", promedioPositivo;
SiNo
    promedioPositivo = 0;
Imprimir "El promedio de los numeros positivos no se puede mostrar dado que no se ingresaron positivos ";
FinSi

si cantidadNegativo <> 0 Entonces //el promedio es importante que no se divida por cero
		promedioNegativo = sumaNegativo / cantidadNegativo;
Imprimir "El minimo de los numeros negativos es : ", numeroMinimoNegativo; //k-De los minimos el negativo
Imprimir "El promedio de los numeros negativos es : ", promedioNegativo;
SiNo
    promedioNegativo = 0;
Imprimir "El promedio y el minimo de los numeros negativos no se puede mostrar dado que no se ingresaron negativos ";
FinSi

//Diferencia entre positivos y negativos, (positivos-negativos). 
diferenciaEntreNumeros = sumaPositivo + sumaNegativo; //le descuento los negativos

Imprimir "El valor de la suma de los negativos es : ", sumaNegativo;
Imprimir "El valor de la suma de los positivos es : ", sumaPositivo;
Imprimir "La cantidad de los numeros positivos son : ", cantidadPositivo;
Imprimir "La cantidad de los numeros negativos son : ", cantidadNegativo;
Imprimir "La diferencia entre numeros positivos y negativos es de : ", diferenciaEntreNumeros;
Imprimir "El numero maximo ingresado es : ", numeroMaximo;
Imprimir "La cantidad de numeros pares es : ", cantidadPares;
Imprimir "La cantidad de ceros es : ", cantidadCeros;


FinAlgoritmo
