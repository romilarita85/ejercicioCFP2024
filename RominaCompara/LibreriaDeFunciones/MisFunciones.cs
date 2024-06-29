//Clase 10-04-24************************************************************************
using System;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace LibreriaDeFunciones
{
    public class MisFunciones
    {
        private Color color;
        private double cantCombustible;
        private int nivelDeTinta;
        public static int[] CargarArrayDeEnteros(int cantidad)
        {
            int[] numeros = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = PedirEntero($"Ingrese el nunero {i + 1} de {cantidad}: ", "El dato ingresado no es un numero");
            }
            return numeros;
        }
        //-----------
        public static int PedirEntero(string mensaje, string mensajeError)
        {
            int numeroValido;
            string numeroLeido;
            numeroLeido = PedirCadena(mensaje);

            while (!int.TryParse(numeroLeido, out numeroValido))
            {
                Console.WriteLine(mensajeError);
                numeroLeido = PedirCadena(mensaje);
            }
            return numeroValido;
        }
        public static string PedirCadena(string mensaje)
        {
            Console.Write(mensaje);
            return Console.ReadLine();
        }
        //---------------
        public static void ImprimirArray(string titulo, int[] misNumeros)
        {
            Console.WriteLine(titulo);
            foreach (int numero in misNumeros)
            {
                Console.WriteLine(numero);
            }
        }
        public static int SumaValoresArrayEnteros(int[] misNumeros)
        {
            int suma = 0;
            foreach (int numero in misNumeros)
            {
                suma += numero;
            }
            return suma;
        }
        public static double CalcularPromedioArrayEnteros(int[] misNumeros)
        {
            int suma = 0;
            double resultado;
            foreach (int numero in misNumeros)
            {
                suma += numero;
            }
            resultado = (double)suma / misNumeros.Length;
            return resultado;
        }
        public static void ImprimirArrayAlreves(string titulo, int[] misNumeros) 
        {
            Array.Reverse(misNumeros);
            Console.WriteLine(titulo);
            foreach (int numero in misNumeros)
            {
                Console.WriteLine(numero);
            }
        }
        //-------------------------
        //public static int[] OrdenarMenor(int[] datos)
        //{
        //    //arrays ordenados de menor a mayor
        //    int aux;
        //    for (int i = 0; i < datos.Length; i++)
        //    {
        //        for (int j = i + 1; j < datos.Length; j++)
        //        {
        //            if (datos[i] > datos[j])
        //            {
        //                aux = datos[i];
        //                datos[i] = datos[j];
        //                datos[j] = aux;
        //            }
        //        }
        //    }
        //    return datos;
        //}
        //public static int[] OrdenarMayor(int[] datos)
        //{
        //    //arrays ordenados de mayor a menor
        //    int aux;
        //    for (int i = 0; i < datos.Length; i++)
        //    {
        //        for (int j = i + 1; j < datos.Length; j++)
        //        {
        //            if (datos[i] < datos[j])
        //            {
        //                aux = datos[i];
        //                datos[i] = datos[j];
        //                datos[j] = aux;
        //            }
        //        }
        //    }
        //    return datos;
        //}
        public static int[] OrdenarPorCriterio(int[] datos, bool ordenarMenor)
        {//Forma mas simple
            //arrays ordenados de menor a mayor
            int aux;
            for (int i = 0; i < datos.Length; i++)
            {
                for (int j = i + 1; j < datos.Length; j++)
                {
                    if((ordenarMenor == true && datos[i] > datos[j]) || (ordenarMenor == false && datos[i] < datos[j]))
                    {
                        aux = datos[i];
                        datos[i] = datos[j];
                        datos[j] = aux;   
                    }
                }
            }
            return datos;
        }
        public static int[] OrdenarMayor(int[] datos)
        {
            //arrays ordenados de mayor a menor
            int aux;
            for (int i = 0; i < datos.Length; i++)
            {
                for (int j = i + 1; j < datos.Length; j++)
                {
                    if (datos[i] < datos[j])
                    {
                        aux = datos[i];
                        datos[i] = datos[j];
                        datos[j] = aux;
                    }
                }
            }
            return datos;
        }
//--------------------------------
        //public static int[] MostrarPorCriterio(string mensaje, int[] vector, bool mostrarPositivo)
        //{
        //    Console.WriteLine(mensaje);
        //    foreach (int numero in vector)
        //    {
        //        if (mostrarPositivo == true) 
        //        {
        //            if (numero > 0) 
        //            {
        //                Console.WriteLine(numero); //muestra el numero
        //            }
        //        }
        //    }
        //    foreach (int numero in vector)
        //    {
        //        if (mostrarPositivo == false)
        //        {
        //            if (numero < 0) 
        //            {
        //                Console.WriteLine(numero);
        //            }
        //        }
        //    }
        //    return vector;
        //}
        public static int[] MostrarPorCriterio(string mensaje, int[] vector, bool mostrarPositivo)
        {//Forma simplificada
            Console.WriteLine(mensaje);
            foreach (int numero in vector)
            {
                if ((mostrarPositivo == true && numero > 0) || (mostrarPositivo == false && numero < 0))
                {
                    Console.WriteLine(numero); //muestra el numero
                }
            }
            return vector;
        }
        public static int PedirEnteroConRango(string mensaje, string mensajeError, int maximo, int minimo)
        {
            int numeroValido = 0;
            string numeroLeido;
            Console.Write(mensaje);
            numeroLeido = Console.ReadLine();

            while (!EsNumerico(numeroLeido) || (int.Parse(numeroLeido) > maximo) || (int.Parse(numeroLeido) < minimo))
            {
                Console.WriteLine(mensajeError);
                Console.Write(mensaje);
                numeroLeido = Console.ReadLine();
            }
            numeroValido = int.Parse(numeroLeido);
            return numeroValido;
        }
        //Uso funcion en formulario/primeraEvaluacion*********************************************************
        //Usando funcion booleano: responde a lo que tenia por parametro. Si es un numero o no
        public static bool EsNumerico(string dato) //Ingreso una cadena de caracteres                                 
        {//evalua si los datos son un digito
            bool esNumerico = true;
            foreach (char digito in dato)
            {
                if (!char.IsDigit(digito))
                {
                    esNumerico = false;
                    break;
                }
            }
            return esNumerico;
        }
        //******************************************************************+
        //Funcion creada para formulario/PrimeraEvaluacion
        public static bool EsSoloLetras(string dato) 
        {
            bool esLetra = true;
            foreach (char letra in dato)
            {
                if (!char.IsLetter(letra))
                {
                    esLetra = false;
                    break;
                }
            }
            return esLetra;
        }
        //***************************************************************************************************************
        public static bool EsPar(int numero)
        {
            bool esPar = false; //variable booleana que me diga que es par

            if (numero % 2 == 0)
            {
                esPar = true;
            }
            return esPar;
        }
        //***********************************Metodo*******************************************************
        //El metodo Avanzar(int km) que retornara un booleano para informar si pudo recorrer
        //o no la cantidad de kilometros recibo por parametro, tener en cuenta que para poder
        //avanzar se debe tener conbustible y por cada litro de combustible se pueden 10km.
        public bool Avanzar(int km)
        {
            bool retorno = false; //variable del tipo bool q puede retornar
            double combustibleNecesario = (double)km / 10.0; //10 km por cada litro de combustible 
            // Calcula el combustible necesario basado en los km (asumiendo 10 km por litro de combustible)
            if (cantCombustible > 0 && cantCombustible >= combustibleNecesario) // km menores o iguales a kmPosibles
            {// Si hay suficiente combustible, se resta la cantidad necesaria
                cantCombustible -= combustibleNecesario;//cantCombustible = cantCombustible - combustibleNecesario;
                retorno = true;// Devuelve true para indicar que el avance fue exitoso
            }
            return retorno;
        }
        //Verifica si hay suficiente combustible (cantCombustible) para cubrir la distancia especificada (combustibleNecesario).
        //-Si hay suficiente combustible:
        //Resta la cantidad calculada de combustible(combustibleNecesario) de cantCombustible.
        //Establece retorno en true para indicar que el avance fue exitoso.
        //-Si no hay suficiente combustible o cantCombustible es cero, retorno permanece false.
        //Metodo para convertir o castear combustible***************************************************************
        public bool ConvertirStringEnCombustible(string combustible)
        {//modifico componente (atributo) propio del objeto uso metodo de instancia
            bool retorno = false;//Variable local para almacenar el resultado de la conversión
                                 //retorno: es una variable booleana que inicialmente se establece en false.
                                 //Se utilizará para indicar si la conversión fue exitosa o no.
            if (double.TryParse(combustible, out double combValido))// Intenta convertir el string 'combustible' en un double
            {// Si tiene éxito, asigna el valor convertido a 'combValido' y devuelve true.

                this.cantCombustible = combValido;// Asigna el valor convertido a la propiedad 'cantCombustible'
                                                  //  del objeto actual.  
                retorno = true; // Establece el retorno como true, indicando que la conversión fue exitosa.
            }
            return retorno; // Devuelve 'retorno', que será true si la conversión fue exitosa, false si no.
        }
        //Crear el metodo publicv bool Escribir(int cantLetras), donde cada letra consume un nivel de tinta,
        //el metodo debe verificar si tiene tinta 
        public bool Escribir(int cantLetras)
        {
            bool sePuedeEscribir = false;

            if (nivelDeTinta >= cantLetras)//verificar si hay nivel de tinta-Comparacion
            {
                nivelDeTinta -= cantLetras; //hay tinta suficiente
                sePuedeEscribir = true; //sePuedeEscribir 
            }
            return sePuedeEscribir;
        }
        //**************************************Metodos Set******************************************************++
        public bool SetColor(Color nuevoColor)
        {
            bool retorno = false;
            if (nuevoColor == Color.Green || nuevoColor == Color.Red || nuevoColor == Color.Blue)
            {
                this.color = nuevoColor;//Establecer el color si es uno de los colores permitidos
                retorno = true; // Indicar que se pudo establecer el color
            }

            return retorno;// Devolver si se pudo establecer el color o no
        }
        public bool SetCantCombustible(double nuevoValor)
        {//Parametro->double nuevoValor: Es el nuevo valor que se desea establecer para cantCombustible.
            bool retorno = false;
            //bool retorno: Se inicializa en false y se utiliza para indicar si se pudo establecer el nuevo valor de cantCombustible.
            if (nuevoValor > 0 && nuevoValor <= 100)
            {
                this.cantCombustible = nuevoValor;// Establecer el nuevo valor de combustible si está en el rango válido
                retorno = true;// Indicar que se pudo establecer el valor
            }
            return retorno;
        }
        public static List<Color> ColoresValidos()
        {
            List<Color> list = new List<Color>()
            {
                Color.Red,Color.Purple,Color.Green,Color.Blue,Color.Black,Color.Salmon
            };
            return list;
        }
        //aplicación de Windows Forms donde tienes una lista desplegable(ComboBox) para seleccionar colores.
        //Además, tienes una propiedad SelectedItem para mantener el color seleccionado por el usuario.

    }
}

