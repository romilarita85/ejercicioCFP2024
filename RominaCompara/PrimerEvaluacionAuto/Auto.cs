using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace PrimerEvaluacionAuto
{
    public class Auto //clase auto
    {
        //A.Los atributos marca, cantCombustible, color.
        //declaramos atributos
        private string marca;
        private double cantCombustible;
        private Color color;

        //B. un constructor que inicialice todos los atributos.
        public Auto(string marca, double cantCombustible, Color color) //1°constructor
        {//le damos valores a los atributos dentro del constructor
            this.marca = marca;
            this.cantCombustible = cantCombustible;
            //this.SetCantCombustible(cantCombustible);//Metodo SetCantCombustible puede ser llamado dentro del constructor.
            this.color = color;
        }
        public Auto(string marca, string cantCombustible, Color color)//3°Constructor
        {
            this.marca = marca;
            this.cantCombustible = double.Parse(cantCombustible);
            this.color = color;
        }
        //this.cantCombustible = double.Parse(cantCombustible);-> convierte el valor de cantCombustible
        //de tipo string a tipo double utilizando double.Parse y lo asigna al campo cantCombustible
        //de la instancia actual de la clase Auto.
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

        //C. Solo metodos Get() para todos sus atributos.
        public string GetMarca()
        {
            return this.marca;
        }

        public double GetCantCombustible()
        {
            return this.cantCombustible;
        }

        public Color GetColor()
        {
            return this.color;

        }

        //D. El metodo AutoToString(), este metodo debe retornar un string con toda su informacion.
        public string AutoToString()
        {
            return $"Marca: {marca} | Cantidad de combustible: {cantCombustible} | Color: {color}";
        }

        //E. El metodo Avanzar(int km) que retornara un booleano para informar si pudo recorrer
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
        public bool ConvertirStringEnCombustible(string combustible) //De instancia
        {//modifico componente (atributo) propio del objeto uso metodo de instancia
            bool retorno = false;//Variable local para almacenar el resultado de la conversión
            //retorno: es una variable booleana que inicialmente se establece en false.
            //Se utilizará para indicar si la conversión fue exitosa o no.
            
            if (double.TryParse(combustible, out double combValido))
            {// Evaluar si double(TryParse me devuelve un bool: si pudo o no convertir el dato strig en combustible)
             //Recibia combustible intentaba parcearlo a double si salia todo bien devolvia un true
             //o caso contrario un false.Y si lograba convertirlo-> combustible era mayor a cero
             //Intenta convertir el string 'combustible' en un double
             //Si tiene éxito, asigna el valor convertido a 'combValido' y devuelve true.
                this.cantCombustible = combValido;// Asigna el valor convertido a la propiedad 'cantCombustible'
                                                  //  del objeto actual.  
                retorno = true; // Establece el retorno como true, indicando que la conversión fue exitosa.
            }
            return retorno; // Devuelve 'retorno', que será true si la conversión fue exitosa, false si no.
        }
        //**********************************************************************************************************
        //El método ConvertirStringAInt intenta convertir una cadena de texto en un número decimal (double)
        //La función double.TryParse intenta realizar esta conversión y devuelve un booleano
        //que indica si la operación fue exitosa o no.
        //Si la conversión es exitosa, el valor convertido se almacena en la variable combValido
        //la cual se pasa por referencia utilizando la palabra clave out.
        //Metodo estatico, propio de la clase. Trabaja igual que el tryParse.Tengo la posibilidad que me devuelva el 
        //el valor validado y si no me devuelve el true o false

        //public static bool ConvertirStringAInt(string valorAConvertir,out double combValido ) 
        //{
        //    return double.TryParse(valorAConvertir, out combValido);
        
        //}
        public static List<Color> ColoresValidos()
        {
            List<Color> list = new List<Color>()
            {
                Color.Red,Color.Purple,Color.Green,Color.Blue,Color.Black,Color.Salmon
            };
            return list;
        }
        public override string ToString() //Sobreecribir metodo ToString que es propio de los objetos
        {
            return this.AutoToString();
            //return "quiero morstrar los datos";
        }
    }
}
//****************CONSTRUCTORES*************************************
//public Auto(string marca, double cantCombustible, Color color) //1°constructor
//{
//    this.marca = marca;
//    this.cantCombustible = cantCombustible;
//    //this.SetCantCombustible(cantCombustible);
//    this.color = color;
//}
//////2°Constructo-Creamos otro constructor
////public Auto(string marca, string combustible, string color) //tres variables de tipo string 
////{
////    this.marca = marca;
////    //necesito parsear combustible y pasar color a uno de los que ya estoy trabajando
////    //->Creo metodos con funcion
////    this.ConvertirStringEnCombustible(combustible); // convertir o castear combutible
////    this.ConvertirStringEnColor(color); //comvertir o validar color
////}
////3°Constructor
//public Auto(string marca, string cantCombustible, Color color)
//{
//    this.marca = marca;
//    this.cantCombustible = double.Parse(cantCombustible);
//    this.color = color;
//}
////this.cantCombustible = double.Parse(cantCombustible);-> convierte el valor de cantCombustible
////de tipo string a tipo double utilizando double.Parse y lo asigna al campo cantCombustible
////de la instancia actual de la clase Auto.
//********************************************SetColor*****************************************************************
//1°forma de hacer SetColor:
//public bool SetColor(Color nuevoColor)
//{
//    bool retorno;
//    if (nuevoColor != Color.Green && nuevoColor != Color.Red && nuevoColor != Color.Blue)
//    {

//        retorno = false;
//    }
//    else 
//    { 
//        this.color = nuevoColor;
//        retorno = true;
//    }

//    return retorno;
//}
//2°forma de hacer el SetColor
//public bool SetColor(Color nuevoColor)
//{
//    bool retorno;
//    if (nuevoColor == Color.Green && nuevoColor == Color.Red && nuevoColor == Color.Blue)
//    {
//        this.color = nuevoColor;
//        retorno = false;
//    }
//    else
//    {
//        retorno = true;

//    }

//    return retorno;
//}
//public bool SetColor(Color nuevoColor)
//{
//    bool retorno = false;
//    if (nuevoColor != Color.Green && nuevoColor != Color.Red && nuevoColor != Color.Blue)
//    {
//        this.color = nuevoColor;
//        retorno = true;
//    }

//    return retorno;
//}
//**********************//Metodo para validar o convertir color//*************************************
//public bool ConvertirStringEnColor(string nuevoColor) 
//{//modifico componente (atributo) propio del objeto uso metodo de instancia
//    bool retorno = true;
//    switch (nuevoColor.ToLower()) //lo puede cambiar siempre y cuando sea rojo,azul o negro
//    {
//        case "rojo":
//            this.color = Color.Red;
//            break;
//        case "azul":
//            this.color = Color.Blue;
//            break;
//        case "negro":
//            this.color = Color.Black;
//            break;
//        default:
//            retorno = false;
//            break;
//    }
//    return retorno;
//}
//*****************************************************************
//