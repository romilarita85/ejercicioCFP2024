namespace LibreriaDeClase_Animal
{
    public class Animal
    {
        protected string nombre;
        protected int edad;
        protected double peso;

        public Animal(string nombre, int edad, double peso)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.peso = peso;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Peso { get => peso; set => peso = value; }

        public virtual string EmitirSonido() //las clases que hereden de animal van a heredar este metodo
        {
            return "hace un ruido generico";
        }
        //virtual: por que tiene la capacidad de utilizarlo tal cual como esta
        //o sobreescribir este metodo en las clases derivadas
    }
}
//Pilares:
//1-Abstraccion: Capacidad de poder resumir al minimo la cantidad de atributos necesarios
//para construir objetos de esa clase bajo un contexto dado

//2-Encapsulamiento: Forma de proteger mis atributos restringiendo o privando el acceso a los mismos

//3-Herencia: Dentro de las clases evitamos repeticiones de codigo y atributo
//todo lo comun a todas las clases van a estar en una clase principal (ej: clase animal)
//y en las clases derivadas va lo propio y especifico de cada clase
//(ej: clase pajaro pia,clase perro ladra,clase gato maulla)
//Usamos reutilizacion de codigo

//4-Polimorfismo: La capacidad de un metodo con el mismo nombre y con la misma firma
//darle una funcionalidad distinta dentro de la misma clase
