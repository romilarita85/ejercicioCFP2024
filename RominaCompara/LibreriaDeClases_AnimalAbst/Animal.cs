//Usando Abstract-contrato de obligacion de ser implementado
//cuando solo quiero usar como plantilla
//clase abstracta: no se va a poder instanciar desde ningun lugar solo la quiero para generar herencia
//Dentro de la clase abstracta puedo tener metodos abstractos, metodos virtuales o metodos de instancia normal 
//que van a tener q heredar o implementar las clases derivadas
//Voy a tener metodos que no tienen implementacion
//las clases abstractas no pueden ser implementadas
//le doy la libertad a la clase derivada q lo implemente como quiera esta obligada a implementarla
namespace LibreriaDeClases_AnimalAbst
{
    public abstract class Animal
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
        //Virtual: por que tiene la capacidad de utilizarlo tal cual como esta
        //o sobreescribir este metodo en las clases derivadas

        public abstract string MostrarDatos();//Metodos abstractos son los unicos metodos que no llevan llaves
        //por que no tienen implementacion
        
    }
}
