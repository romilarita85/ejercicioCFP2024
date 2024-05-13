//CLASE 22-04-24*********************************************************************
//Pilares:
//1)-ABASTRACCION: Simplificacion de la realidad donde me quedo con lo importsnte y descarto  los 
//detalles irrelevantes.Capturar la idea principal de un objeto dentro de un determinado contexto, 
//ignorando los detalles y especificaciones que no sean relevantes.
//Tratar de reducir a la mayor cantidad de objetos para llegar a la minima expresion.
//Capacidad de reducir el numero, la cantidad de atributos o condiciones de un proyecto
//2)-ENCAPSULAMIENTO: Restriccion de acceso a los metodos, a los atributos de nuestra clase. Atributos y 
//metodos protegidos.Se pueden cambiar pero internamente no sabemos que pasa. 
//
//implica ocultar los detalles internos de un objeto y exponer solo las funcionalidades
//necesarias a través de interfaces públicas. Esto se logra mediante el uso de modificadores de acceso
//como public, private, protected, internal, entre otros, para controlar el acceso a los miembros de una clase.
//Permite que los datos de un objeto sean protegidos de modificaciones no autorizadas
//y que las operaciones sobre esos datos se realicen mediante métodos públicos.

//3)-HERENCIA:
//4)-POLIFORMISMO:
//**********************************COMPORTAMIENTOS DE CLASE:************************************
//-ESTATICO: Por medio de la clase accedemos a sus metodos o atributos.
//No se pueden instanciar.
//-DE INSTANCIA: Cuando preciso crear una nueva instancia para crear un objeto.
//podemos tener clases estaticas y de instancia.
//***********************************************************************************************
//Las clases no se pueden ejecutar -> son muertas
//Los proyectos de consola son ejecutables
//Si a la clase le pongo internal es inaccesible
//Dentro de mi libreria puedo crear varias clases
//Dentro de mi clase voy a tener:
//1)-ATRIBUTOS: son los campos que definen mi objeto(van a ser privados en este caso -si no le pongo nada asume que son privados)

//2)-CONSTRUCTOR:el unico metodo que no tenia retorno (void)
//constructor va a ser de instancia
//no tiene retorno y lleva siempre el nombre de la clase
//puedo tener varios constructores pero respetando los parametros
//es un metodo que permite crear (instanciar o crear una nueva instancia) objetos de mi clase.
//Contiene:
//1-Visibilidad (public)
//2-Comportamiento -> estatico o de instancia --
//para ser STATIC de decirlo explicitamente.
//de lo contrario es de INSTANCIA
//3-NUNCA TIENEN RETORNO
//4-Nombre: SIEMPRE el MISMO que la CLASE (en este caso Empleado)
//5-Parametros

//3)-METODOS GET Y SET:Permitir consultar(get)
//y/o modificar atributos(set insertar o agregar)
//tienen que hacer referencia al atributo con el q estan trabajando

//4)-PROPIEDADES:son una mezcla entre los atributos y/o metodos (get y set) proximamente......

//5)-METODOS O COMPORTAMIENTO: son los comportamientos de mi clase (por lo gral se usan para comunicar info)
//no son obligatorios (por lo menos tener uno).
//1-visibilidad
//2-comportamiento -> estatico o de instancia -- para ser STATIC de decirlo explicitamente. de lo contrario es de INSTANCIA
//3-retorno
//4-nombre
//5-parametros 
//**********************************************
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            ejemplo_de_otra_clase.PedirCadena("Ingrese su nombre: ");
//            ejemplo_de_otra_clase miObjeto = new ejemplo_de_otra_clase();
//            Console.WriteLine(miObjeto.nombre);
//        }
//    }
//}
//**************************************PARSEO**********************************
//Cuando trabajas con la consola a menudo necesitas leer datos que el usuario ingresa
//como cadenas (strings) y luego convertir esos datos en otros tipos,
//como números enteros (int), números de punto flotante (float), etc.
//Esto se debe a que la consola solo puede leer y escribir cadenas de texto.
//Por ejemplo, si esperas que el usuario ingrese un número entero a través de la consola
//y deseas hacer cálculos con ese número, necesitas convertir la cadena ingresada por el usuario
//en un número entero antes de poder usarlo en operaciones matemáticas.
//******METODO Parseo: Convertir un tipo de dato a otro
//******METODO To String: Convierto lo que tengo dentro en texto (de int -> string)
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int edad;
//            string edadEnTexto;

//            Console.Write("Ingrese su edad: "); 

//            edad = int.Parse(Console.ReadLine());
//            Console.WriteLine($"Edad parseada de string a int {edad}");

//            edadEnTexto = edad.ToString();
//            Console.WriteLine($"Edad parseada de int a string {edadEnTexto}");
//        }
//    }
//}
//****************************************METODO GetType*************************************
//Get tyoe:Me devuelve algo de la clase type. Me dice como se llama.
//Brinda información sobre el tipo de datos de un objeto específico
//en el momento en que se ejecuta el programa. Ejemplo:
//Edad parseada de string a int 33 edad es de tipo: System.Int32
//Edad parseada de int a string 33 edad es de tipo: System.String
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int edad;
//            string edadEnTexto;

//            Console.Write("Ingrese su edad: ");

//            edad = int.Parse(Console.ReadLine());
//            Console.WriteLine($"Edad parseada de string a int {edad} edad es de tipo: {edad.GetType()} ");

//            edadEnTexto = edad.ToString();
//            Console.WriteLine($"Edad parseada de int a string {edadEnTexto} edad es de tipo: {edadEnTexto.GetType()}");
//        }
//    }
//}
//******************************************METODO Try parse********************************************
//TryParse: Espera recibir un string. Siempre retorna un boleano.
//Si la conversion fue correcta o no representa un dato numerico.
//Utiliza int.TryParse() para intentar convertir la cadena lectura en un número entero.
//Si tiene éxito, asigna el valor convertido a la variable edad y devuelve true.
//Si falla, no se modifica edad y devuelve false.
//Si TryParse() tiene éxito, imprime un mensaje que muestra la edad ingresada por el usuario.
//Si TryParse() falla, imprime un mensaje indicando que el dato ingresado es incorrecto.
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int edad;
//            string lectura;

//            Console.Write("Ingrese su edad: ");
//            lectura = Console.ReadLine();

//            if (int.TryParse(lectura,out edad)) // Evalua el metodo dentro del if (evalua su retorno)
//            {
//                Console.WriteLine($"Edad ingresada es: {edad}"); //True
//            }
//            else 
//            {
//                Console.WriteLine("El dato ingresado no es valido"); //false
//            }
//        }
//    }
//}
//*********************************BUCLES REPETITIVOS*************************************************
//**For ->Para cuando conocemos la cantidad de repeticiones
//Puedo declarar la variable de control dentro del for  o por fuera.
//CUANDO SE LA CANTIDAD DE REPETICIONES QUE TENGO USO FOR
//*******************************************************************
//**While ->Para cuando desconozca la cantidad de repeticiones y
//solo se va a ejecutar si la condicion es verdadera
//SIEMPRE QUE LA CONDICION SE REPITA Y SEA VERDADERA USAR WHILE
//*******************************************************************
//**Do While ->Para cuando desconozca la cantidad de repeticiones y
//preciso que se ejecute el codigo por lo menos 1 vez
//SIEMPRE QUE LA CONDICION SE REPITA Y SEA FALSA USAR DO WHILE
//******************************************************************
//-Variable de control->for-while-do while
//-condicion de corte->for-while-do while
//-cantidad de repeticiones-for
//***********************************************************
//SWITCH = (segun) Condicional multiple
//Sabe de entrada que valores voy a asumir. 
//toma multiples valores de una variable
//*****************************************************************************************************
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            bool bandera = false;
//            int contador = 0;
////SIEMPRE QUE LA CONDICION SE REPITA Y SEA VERDADERA USAR WHILE
//            while (bandera == false) 
//            {
//                //contador++;-> puede ir aca o abajo del if funciona igual
//                Console.WriteLine($"Vuelta n°{contador}");
//                if (contador > 10) 
//                {
//                    bandera = true;
//                }
//                contador++;
//            }
//        }
//    }
//}
//-------------------
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            bool bandera = false;
//            int contador = 0;

//            bool resultado = bandera == false;

//            while (resultado)
//            {
//                contador++;//puede ir aca o abajo del if funciona igual
//                Console.WriteLine($"Vuelta n°{contador} valor de la evaluacion: {resultado}");
//                if (contador > 10)
//                {
//                    resultado = false;
//                }
//            }
//        }
//    }
//}
//------------------------------------------------------------------------------
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int i;
//            for (i = 0; i < 0; i++/* i =i+1, i +=1 */)
//            {
//                Console.WriteLine($"Vuelta n°{i} del for");
//            }
//            Console.WriteLine($"Valor de i: {i}");
//            Console.WriteLine("-------------------------------------------");
//
//            int contador = 0;
//            while (contador < 0)
//            { 
//                Console.WriteLine($"Vuelta n°{contador} del while");

//                contador++;
//            }
//            Console.WriteLine($"Valor de contador: {contador}");
//            Console.WriteLine("-------------------------------------------");
//
//            int contadorDo = 0;
//            do
//            {
//                Console.WriteLine($"Vuelta n°{contadorDo} del Do while");
//                contadorDo++;
//            } while (contadorDo<0);
//            Console.WriteLine($"Valor de contadorDo: {contadorDo}");
//        }   
//    }
//}
//**************************************STRINGS-CADENAS***************************************
//String:tipo de dato. Es un conjunto de caracteres. Puedo recorrerlo con un for
//Variable string no se puede modificar. Son inmutables (puedo pisarlos con un nuevo valor)
//Una vez que se crea un objeto string, su valor no puede ser cambiado.
//Cualquier operación que parezca modificar un string, en realidad está creando
//un nuevo string con el valor modificado en lugar de modificar directamente el string original.
//*********************************************************************************************
//Inicializa una variable frase con un valor de "frase que escribi".
//Luego, imprime la longitud de la frase utilizando frase.Length.
//Después, realiza un bucle for que recorre cada carácter de
//la frase e imprime cada carácter en una línea separada.
//El código está mostrando dos cosas:
//Imprime la longitud de la frase.
//Imprime cada carácter de la frase en líneas separadas.
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string frase = "frase que escribi";

//            Console.WriteLine($"La frase: \"{frase}\" tiene {frase.Length} caracteres");

//            for (int i = 0; i < frase.Length; i++/* i =i+1, i +=1 */)
//            {
//                Console.WriteLine(frase[i]);
//            }
//        }
//    }
//}
////Propiedad Length: Valor numerico. Representa la cantidad de caracteres que tiene
////mi cadena. Los espacios representan un caracter (los van a contar).
//*************************************METODO FOREACH*****************************************
////Es util para recorrer una coleccion. Siempre y cuando queramos recorrer una coleccion
////de datos (string-> cadena de caracteres->char)
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string frase = "frase que escribi";

//            foreach (char letra in frase)
//            {
//                Console.WriteLine(letra);
//                if (letra == 'q') 
//                {
//                    break;
//                }
//            }
//        }
//    }
//}
///Dos formas de romper un bucle foreach:
///-Condicion normal
///-Puedo romper el bucle con un break. Dejo de iterar para que deje de recorrer
//*****************************************METODO TRIM******************************************
//Trim: Elimina espacios en blanco
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string frase = ".....     ******frase que escribi******      .....";

//            //frase = frase.Trim(); //borrar espacios en blanco
//            //frase = frase.Trim('*');//especifica que espacios quiero borrar
//            frase = frase.Trim(['*',' ','.']); //no importa el orden de los parametros 
//                                               //los borra igual
//            frase = frase.ToUpper();
//            for (int i = 0; i < frase.Length; i++)
//            {
//                Console.WriteLine(frase[i]);

//            }

//        }
//    }
//}
////Toupper:es un método que se utiliza para convertir
////una cadena de caracteres a su equivalente en mayúsculas.
//*********************************VECTORES-ARRAY DE NUMEROS***************************************
//ARRAY: Cadenas o conjunto de datos del mismo tipo. Coleccion de distintas variables bajo el mismo nombre.
//Por medio de las posiciones yo puedo acceder a {}
//Se pueden recorrer con un for o foreach
//Es una estructura de datos que permite almacenar una colección ordenada
//de elementos del mismo tipo bajo un solo nombre de variable. 
//**********************************************************************
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //Dos formas de inicializar el array:
//            int[] numeros= new int[5];
//            int[] numeros2 = { 1, 2, 85, 100, -98 };

//            for (int i = 0; i < numeros.Length;i++) //recorro array contando el numero de posiciones de i (0,1,2,3,4)
//            {
//                numeros[i] = i + 1;
//            }
//            numeros[3] = 15; //puedo dar un nuevo valor de forma arbitraria

//            foreach (int numero in numeros) //recorro el array
//            {
//                Console.WriteLine(numero);
//            }
//        }
//    }
//}
///******************************************ARRAY REVERSE*******************************************************
//ARRAY REVERSE: Da vuelta los valores
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        { 
//            int[] numeros = new int[5];

//            for (int i = 0; i < numeros.Length; i++)
//            {
//                numeros[i] = i + 1;
//            }
//            numeros[3] = 15; //puedo dar un nuevo valor de forma arbitraria

//            Array.Reverse(numeros); // doy vuelta los valores
//            foreach (int numero in numeros)
//            {
//                Console.WriteLine(numero);
//            }
//        }
//    }
//}
//CLASE 24-04-24***********
//******************************************FUNCIONES***********************************************
//Es un pequeño bloque de codigo que se encarga de hacer una unica tarea. Va a resolver una solucion(un problema)
//1)-Visibilidad: podra ser public o privada (private)
//2)-Comportamiento: Estatic o de instancia.
//3)-Retorno: Sin retorno (VOID) o cualquier tipo de dato (int, string,bool)
//4)-Nombre: Debe empezar con mayuscula PascalCase, tiene que ser representativo
//a lo que hace y por lo general es un verbo (por que hace una accion)
//5)-Prametros: Puedo no tenerlos, en caso de tenerlos pueden ser de cualquier 
//tipo o cantidad.

//Existen 4 tipos de firmas:
//1-Las que retornan algo y reciben parametros-> las ideales
//2-Las que retornan algo y no reciben paramentros
//3-Las que no retornan nada y reciben parametros
//4-Las que no retornan nada y no reciben parametros

//Etapas que componen una funcion:
//1° etapa -La firma
//2° etapa -El desarrollo
//3° etapa -El llamado o invocacion
//
//!true -> false
//!false -> true
//SIEMPRE QUE TENGA RETORNO MI FUNCION USA LA PALABRA RETURN
//si no retorna nada es void
//*****************************************************************************
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        { //3° etapa -El llamado o invocacion
//            ///paso valor a la funcion-harcodeados:
//            //int suma;
//            //suma = SumarEnteros (45,16);
//            //Console.WriteLine($"El valor de la suma es: {suma}");

//            ///O podria hacer datos que vengan de una variable:
//            int suma;
//            int numero1 = 45;
//            int numero2 = 16;
//            suma = SumarEnteros(numero1,numero2);
//            Console.WriteLine($"El valor de la suma entre {numero1} y {numero2} es: {suma}");

//        }
//        //ejemplo: Recibir dos numeros y sumarlos
//        public static int SumarEnteros(int numero1, int numero2) //1° etapa -La firma
//        {//2° etapa -El desarrollo
//            int resultado;
//            resultado = numero1 + numero2;
//            return resultado;
//        }
//    }
//}
//---------------**************************************------------------
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        { //3° etapa -El llamado o invocacion
//            ///paso valor a la funcion-harcodeados:
//            //int suma;
//            //suma = SumarEnteros (45,16);
//            //Console.WriteLine($"El valor de la suma es: {suma}");

//            ///O podria hacer datos que vengan de una variable:
//            //int suma;
//            //int numero1 = 45;
//            //int numero2 = 16;
//            //suma = SumarEnteros(numero1, numero2);
//            //Console.WriteLine($"El valor de la suma entre {numero1} y {numero2} es: {suma}");
//            //****************
//            int numero;
//            Console.WriteLine("Ingrese un numero: ");

//            if (int.TryParse(Console.ReadLine(), out numero)) //amaliza si el dato ingresado es un numero o no
//            { ///si puede leerlo y el dato ingresado es un numero entre al if
//                if (EsPar(numero)) // evalua si el numero ingresado es par o impar
//                {
//                    Console.WriteLine($"El numero {numero} es par");
//                }
//                else 
//                {
//                    Console.WriteLine($"El numero {numero} es impar");
//                }
//            }
//            else 
//            {
//                Console.WriteLine("El dato ingresado es incorrecto");
//            }
//        }
//        //ejemplo: Recibir dos numeros y sumarlos
//        public static int SumarEnteros(int numero1, int numero2) //1° etapa -La firma
//        {//2° etapa -El desarrollo
//            int resultado;
//            resultado = numero1 + numero2;
//            return resultado;
//        }
//        //**************************
//        //Ejemplo: Quiero saber si el numero es par
//        public static bool EsPar(int numero) 
//        {
//            bool esPar = false; //variable booleana que me diga que es par

//            if (numero % 2 == 0) 
//            {
//                esPar = true;
//            }
//            return esPar;

//        }
//        //*******************+
//        public static int PedirNumero() 
//        {
//            //int numero;
//            //Console.Write("Ingrese un numero: ");
//            //while (!int.TryParse(Console.ReadLine(), out numero))
//            //{
//            //    Console.WriteLine("El dato ingresado no es un numero");
//            //    Console.Write("Ingrese un numero: ");
//            //}
//            //return numero;

//            int numero;
//            string lectura;
//            Console.Write("Ingrese un numero: ");
//            lectura = Console.ReadLine();

//            while (!int.TryParse(lectura, out numero))
//            {
//                Console.WriteLine("El dato ingresado no es un numero");
//                Console.Write("Ingrese un numero: ");
//                lectura = Console.ReadLine();
//            }
//            return numero;
//        }
//    }
//}
//***************************************************************************
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        { //3° etapa -El llamado o invocacion
//            ///-paso valor a la funcion-harcodeados:
//            //int suma;
//            //suma = SumarEnteros (45,16);
//            //Console.WriteLine($"El valor de la suma es: {suma}");

//            ///-O podria hacer datos que vengan de una variable:
//            //int suma;
//            //int numero1 = 45;
//            //int numero2 = 16;
//            //suma = SumarEnteros(numero1, numero2);
//            //Console.WriteLine($"El valor de la suma entre {numero1} y {numero2} es: {suma}");
//            //****************
//            int numero;
//            numero = PedirNumero("Ingrese un numero: ");

//            if (EsPar(numero))
//            {
//                Console.WriteLine($"El numero {numero} es par");
//            }
//            else
//            {
//                Console.WriteLine($"El numero {numero} es impar");
//            }
//        }
//        //ejemplo: Recibir dos numeros y sumarlos
//        public static int SumarEnteros(int numero1, int numero2) 
//        {
//            //return numero1 + numero2;
//            int resultado;
//            resultado = numero1 + numero2;
//            return resultado;
//        }
//        //**************************
//        //Ejemplo: Quiero saber si el numero es par
//        public static bool EsPar(int numero)
//        {
//            //1-Paso a paso:
//            //bool esPar = false; //variable booleana que me diga que es par

//            //if (numero % 2 == 0)
//            //{
//            //    esPar = true;
//            //}
//            //return esPar;

//            //2-Modo ninja:
//            //return numero % 2 == 0;

//            //3-
//            if (numero % 2 == 0)
//            {
//                return true;
//            }
//            return false;
//        }
//        //*******************+
//        public static int PedirNumero(string mensaje)
//        {
//            int numero;
//            string lectura;
//            Console.Write(mensaje);
//            lectura = Console.ReadLine();

//            while (!int.TryParse(lectura, out numero))
//            {
//                Console.WriteLine("El dato ingresado no es un numero");
//                Console.Write(mensaje);
//                lectura = Console.ReadLine();
//            }
//            return numero;
//        }
//    }
//}
//**************************************************************************************************
////Referencia de Repaso General a Libreria_de_funciones_2
////copio las funciones en Libreria_de_funciones_2
//using Libreria_de_funciones_2;
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int numero;
//            string pedido = "Ingrese su altura(cm): " ;
//            int suma;

//            numero = MisFunciones.PedirNumero(pedido);

//            if (MisFunciones.EsPar(numero))
//            {
//                Console.WriteLine($"El numero {numero} es par");
//            }
//            else
//            {
//                Console.WriteLine($"El numero {numero} es impar");
//            }
//            suma = MisFunciones.SumarEnteros(78,102);
//            Console.WriteLine(suma);
//        }
//    }
//}
//************************************VECTORES O ARRAYS*****************************
////Es una coleccion de varias variables del mismo tipo, con un mismo nombre
//using Libreria_de_funciones_2;
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //Ingrese 5 variables del mismo tipo

//            int[] numeros = new int [5];//INSTANCIAR

//            for (int i = 0; i < 5; i++) 
//            {
//                Console.WriteLine("Ingrese un numero: ");
//                numeros[i] = int.Parse(Console.ReadLine());

//            }

//            int[] otrosNumeros = {12,-58,89,75,0};//INICIALIZAR

//        }
//    }
//}
//****************************************
////Dos formas de recorrer el array: Usando for o Foreach
//using Libreria_de_funciones_2;
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] otrosNumeros = { 12, -58, 89, 75, 0 };//INICIALIZAR

//            //foreach (int numero in otrosNumeros)
//            //{
//            //    Console.WriteLine(numero);
//            //}

//            for (int i = 0; i < otrosNumeros.Length; i++)
//            {
//                Console.WriteLine(otrosNumeros[i]);
//            }
//            Array.Reverse(otrosNumeros);

//            for (int i = 0; i < otrosNumeros.Length; i++)
//            {
//                Console.WriteLine(otrosNumeros[i]);
//            }

//        }
//    }
//}
//**********************METODO DE ORDENAMIENTO-VARIABLE AUX********************
////
//using Libreria_de_funciones_2;
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] otrosNumeros = { 12, -58, 89, 75, 0 };//INICIALIZAR
//            int auxiliar;
//            Console.WriteLine("Array sin ordenar");

//            foreach (int numero in otrosNumeros)
//            {
//                Console.WriteLine(numero);
//            }

//            for (int i = 0; i < otrosNumeros.Length; i++)
//            {
//                for (int j= i + 1; j < otrosNumeros.Length; j++) 
//                {
//                    if(otrosNumeros[i] < otrosNumeros[j]) //Evaluar quien es mas chico
//                    {
//                        //Cambiar las posiciones
//                        auxiliar = otrosNumeros[i];
//                        otrosNumeros[i] = otrosNumeros[j];
//                        otrosNumeros[j] = auxiliar;
//                    }
//                }
//            }
//            Console.WriteLine("Array ordenado");
//            foreach (int numero in otrosNumeros)
//            {
//                Console.WriteLine(numero);
//            }
//        }
//    }
//}
//*****************************************ARRAY DE CHAR*****************************************
//using Libreria_de_funciones_2;
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            char[] palabra = {'m','a','n','z','a','n','a'};

//            foreach (char letra in palabra)
//            {
//                Console.WriteLine(letra);
//            }
//        }
//    }
//}
//********************************CAMBIAR LETRA POR CARACTER**************************************
////Quiero cambiar letra por un caracter distinto
//using Libreria_de_funciones_2;
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            char[] palabra = { 'm', 'a', 'n', 'z', 'a', 'n', 'a' };

//            for (int i = 0; i < palabra.Length; i++)
//            {
//                if (palabra[i] == 'a')
//                {
//                    palabra[i] = '#';
//                }

//            }

//            foreach (char item in palabra)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}
//*******************************PRIMER LETRA A MAYUSCULA*************************************
////Quiero que la primer letra se transforme en mayuscula
//using Libreria_de_funciones_2;
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            char[] palabra = { 'm', 'a', 'n', 'z', 'a', 'n', 'a' };

//            for (int i = 0; i < palabra.Length; i++)
//            {
//                if (i == 0)
//                {
//                    palabra[i] = char.ToUpper(palabra[i]);
//                }

//                if (palabra[i] == 'a')
//                {
//                    palabra[i] = '#';
//                }

//            }

//            foreach (char item in palabra)
//            {
//                Console.Write(item);
//            }
//        }
//    }
//}
//***********************LAS LETRAS DE MINUSCULA A MAYUSCULA*****************
//Si queremos que se convierta en mayuscula
//using Libreria_de_funciones_2;
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            char[] palabra = { 'm', 'a', 'n', 'z', 'a', 'n', 'a' };

//            for (int i = 0; i < palabra.Length; i++)
//            {
//                if (palabra[i] == 'a') // las posiciones donde este la letra "a"
//                {
//                    palabra[i] = char.ToUpper(palabra[i]); //convierte en mayuscula
//                }
//            }

//            foreach (char item in palabra)
//            {
//                Console.Write(item);
//            }
//        }
//    }
//}
//*************************************ARRAY DE STRING*************************************
//using Libreria_de_funciones_2;
//namespace Repaso_GRAL
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] palabra = { "mercado", "sandia", "casa" };

//            foreach (string item in palabra)
//            {
//                Console.WriteLine(item);
//            }

//        }
//    }
//}
//*********************************METODO SPLIT****************************************
//Queremos partirlas siempre que encuentre un guion.
using Libreria_de_funciones_2;
namespace Repaso_GRAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = "mercado-sandia-casa-coche";
            string[] palabras = frase.Split(['-', ' ']);
            //string[] palabras = frase.Split('-');

            foreach (string item in palabras)
            {
                Console.WriteLine(item);
            }
        }
    }
}