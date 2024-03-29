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

using System.ComponentModel.Design;

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
            decimal promedioNegativo;//Definir promedioNegativo Como Real;
            decimal promedioPositivo;//Definir promedioPositivo Como Real;
            int diferenciaEntreNumeros;//Definir diferenciaEntreNumeros Como Entero;
            int numeroMaximo;//Definir numeroMaximo Como Entero;
            int numeroMinNegativo;//Definir numeroMinimoNegativo Como Entero;
            String banderaPrimerNegativo = "falso";//Definir banderaPrimerNegativo Como caracter;

            for (i = 1; i > repeticiones; i++) 
            {
                Console.WriteLine($"Ingrese el numero {i} de  {repeticiones}");
                numeroIngresado = int.Parse(Console.ReadLine());
                if (numeroIngresado > 0)//todos los positivos
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
                    else //va el cero
                    {
                        cantidadNegativo = cantidadNegativo + 1;
                    }

                }
                if(numeroIngresado % 2 == 0 && numeroIngresado<> 0)//f.Cantidad de numeros pares /queremos que sean distintos de cero
                {
                    cantidadPares = cantidadPares + 1; 
                }

                //j.El número máximo
                //numero maximo, en este caso "i" (variable de control me indica cual es el primer numero ingresado)
                if (i == 1 O numeroIngresado > numeroMaximo)
                {
                    numeroMaximo = numeroIngresado;
                }

                if(numeroIngresado < 0 && banderaPrimerNegativo == Falso)||(numeroIngresado < 0 && numeroIngresado < numeroMinNegativo)
                {
                //aca ingresa el primer numero negativo
                //declare arriba que bandera estaba vacia (falso)- 
                //se cambia el valor de vacio a lleno (verdadero)-adentro se declara por el valor contrario y pasa a "lleno" 
                    numeroMinNegativo = numeroIngresado;
                    banderaPrimerNegativo = Verdadero; //invierto la bandera por que ya se cumplio ya ingreso el primer numero- cambio el estado de la bandera
                                                   //la bandera en el proximo caso estaria llena.
                }
            }   
        }
    }
}
	
	if (cantidadPositivo<>0)
    {
        promedioPositivo = sumaPositivo / cantidadPositivo;// en el promedio = el dividendo nunca puede ser cero
    }
    else
    {
        promedioPositivo = 0;

    }

//h.Promedio de negativos.
if(cantidadNegativo <> 0)
{ 
     promedioNegativo = sumaNegativo / cantidadNegativo;
}
else 
{ 
     medioNegativo = 0;
}

//i.Diferencia entre positivos y negativos, (positivos-negativos)
diferenciaNumero = sumaPositivo + sumaNegativo; // le descuento los positivos
