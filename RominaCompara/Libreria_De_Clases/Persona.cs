//clase 29-07-24
namespace Libreria_De_Clases
{
    //Segun el contexto en que trabaje las clases pueden ser:
    //1)-Clases de instancia: Para poder trabajar con los metodos o acceder a los atributos y propiedades de una
     //clase de instancia si o si tengo que crear un nuevo objeto de esa clase
    public class Persona 
    {
        private string nombre;
        private int edad;
        public double peso;

        public Persona() 
        { 
        }

        public Persona(string nombre, int edad, double peso)//Constructor parametrizado
        {
            this.nombre = nombre;
            this.edad = edad;
            this.peso = peso;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Peso { get => peso; set => peso = value; }

        public string Dni { get; set; } //Propiedad 
        //Metodos get/set: consultar o escribir los valores de mis atributos
        //Properties: metodos de lectura y escritura para distintos valores
        //public string Dni 
        //{
        //    set 
        //    {
        //        return "278034566";
        //    }
        //}
    }
    
    public static class Ejemplo //Es propio de la clase
    {
        static string nombre;
        public static string Nombre
        {
            set 
            {
                Ejemplo.nombre = value;
            }
         //no puedo usar el "this" por que no puedo generar una instancia de esa clase
         //el this hace referencia a la instancia de esa clase
        }
    }
}
//TIPOS DE CLASES
//namespace Libreria_De_Clases
//{
//    //Segun el contexto en que trabaje las clases pueden ser:
//    //1)-Clases de instancia: Para poder trabajar con los metodos o acceder a los atributos y propiedades de una
//    //clase de instancia si o si tengo que crear un nuevo objeto de esa clase
//    public class Persona
//    {
//        private string nombre;
//        private int edad;
//        public double peso;

//        public string Nombre { get => nombre; set => nombre = value; }
//        public int Edad { get => edad; set => edad = value; }
//        public double Peso { get => peso; set => peso = value; }
//    }
//    //2)-Clases estaticas-Es propio de la clase
//    //No se pueden instanciar.Se instancian de forma automatica al
//    //momento en que yo empiezo a correr la aplicacion.Al momento de instanciarse el compilador va a instanciar
//    //y esa instancia va ser lo mismo para todas las clases que yo utilice de "OtraClase"
//    //Para acceder a sus metodos y/o atributos no necesito instanciar la clase
//    public static class OtraClase
//    {

//    }
//}