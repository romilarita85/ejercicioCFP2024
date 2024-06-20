using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeHerencia
{
    public abstract class Animal // usando abstract
    {
        protected string nombre;
        protected double peso;
        protected int edad;

        public Animal(string nombre, double peso, int edad)
        {
            this.nombre = nombre;
            this.peso = peso;
            this.edad = edad;
        }
        public abstract string EmitirSonido();
        public abstract string EjercerAccion();

        public virtual string MostrarInfo() 
        {
            return $"Nombre:{nombre}|Peso: {peso}|Edad: {edad}";
        }

    } 
}
//ABSTRACT:Las clases padres pueden ser abstractas.Nunca voy a poder tener una instancia de esa clase
//cada clase se hace cargo de sus metodos.
//Solo va a ser una plantilla y no va a tener una implementacion
//No puedo generar un objeto de una clase abstracta el que herede esta obligado a implementarla
//***********************************************+****************************************************
//VITUAL: Puedo sobrescribir o no el metodo.
//si quiero que tenga implementacion y que pueda sobreescribirlo
//Usando solo VIRTUAL
//namespace LibreriaDeHerencia
//{
//    public class Animal
//    {
//        protected string nombre;
//        protected double peso;
//        protected int edad;

//        public Animal(string nombre, double peso, int edad)
//        {
//            this.nombre = nombre;
//            this.peso = peso;
//            this.edad = edad;
//        }
//        public virtual string EmitirSonido()
//        {
//            return "RRRRRRRRRRRRRR";
//        }

//    }
//}