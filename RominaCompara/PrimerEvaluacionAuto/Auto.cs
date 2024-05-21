using System.Drawing;
using System.Runtime.CompilerServices;

namespace PrimerEvaluacionAuto
{
    public class Auto
    {
        //A.Los atributos marca, cantCombustible, color.
        private string marca;
        private double cantCombustible;
        private Color color;

        //B. un constructor que inicialice todos los atributos.
        public Auto(string marca, double cantCombustible, Color color)
        {
            this.marca = marca;
            this.cantCombustible = cantCombustible;
            //this.SetCantCombustible(cantCombustible);
            this.color = color;
        }
        //Creamos otro constructor
        public Auto(string marca, string combustible, string color) //tres variables de tipo string 
        {
            this.marca = marca;
            //necesito parsear combustible y pasar color a uno de los que ya estoy trabajando->Creo metodos con funcion
            this.ConvertirStringEnCombustible(combustible); // convertir o castear combutible
            this.ConvertirStringEnColor(color); //comvertir o validar color
        }

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

        public bool SetColor(Color nuevoColor)
        {
            bool retorno = false;
            if (nuevoColor == Color.Green || nuevoColor == Color.Red || nuevoColor == Color.Blue)
            {
                this.color = nuevoColor;
                retorno = true;
            }

            return retorno;
        }

        public bool SetCantCombustible(double nuevoValor)
        {
            bool retorno = false;
            if (nuevoValor > 0 && nuevoValor <= 100)
            {
                this.cantCombustible = nuevoValor;
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
            bool retorno = false;
            double combustibleNecesario = (double)km / 10.0; //10 km por cada litro de combustible 

            if (cantCombustible > 0 && cantCombustible >= combustibleNecesario) // km menores o iguales a kmPosibles
            {
                cantCombustible -= combustibleNecesario;
                retorno = true;
            }
            return retorno;
        }

        public bool ConvertirStringEnCombustible(string combustible) //metodo para convertir o castear combutible
        {//modifico componente (atributo) propio del objeto uso metodo de instancia
            bool retorno = false;
            if (double.TryParse(combustible, out double combValido))
            {
                this.cantCombustible = combValido;
                retorno = true;
            }
            return retorno;
        }
        public bool ConvertirStringEnColor(string nuevoColor) //metodo para validar o convertir color
        {//modifico componente (atributo) propio del objeto uso metodo de instancia
            bool retorno = true;
            switch (nuevoColor.ToLower()) //lo puede cambiar siempre y cuando sea rojo,azul o negro
            {
                case "rojo":
                    this.color = Color.Red;
                    break;
                case "azul":
                    this.color = Color.Blue;
                    break;
                case "negro":
                    this.color = Color.Black;
                    break;
                default:
                    retorno = false;
                    break;
            }
            return retorno;


        }
        public static List<string> ColoresValidos()
        {

            List<string> list = new List<string>(){
            "azul","verde","amarillo","negro" 
            };
                
           

            return list;
        }
    }
}
