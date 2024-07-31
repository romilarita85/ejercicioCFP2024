using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClase_Animal
{
    public class Pajaro : Animal
    {
        public Pajaro(string nombre, int edad, double peso) : base(nombre, edad, peso)
        {
        }

        public string MostrarInfo() //Metodo propio de la clase pajaro
        { 
            return $"{this.nombre} - {this.edad}";
                //nombre es inacsesible si no uso protected en los atributos de la clase animal
                //por el tipo de proteccion
        }
        
        //Clase derivada tiene la facultad de escribir o no el metodo EmitirSonido (por q tiene virtual)
        public override string EmitirSonido() //las clases que hereden de animal van a heredar este metodo
        {
            return "pio pio pio";//puedo llamar a lo que tienen el metodo base de la clase base
                                 //o escribir el sonido q quiero q haga
        }
        public string MostrarDatosPajaro()
        {//no es un metodo de instancia que puede ser static y tampoco lo puedo sobreescrir
            return $"{base.MostrarDatos}";
        //tengo que darle nombre propio al metodo MostrarDatos(ya que no tiene la palabra reservada override)
        }
    }
}
//************************************************************************************
//namespace LibreriaDeClase_Animal
//{
//    public class Pajaro : Animal
//    {
//        public Pajaro(string nombre, int edad, double peso) : base(nombre, edad, peso)
//        {
//        }

//        public string MostrarInfo() //Metodo propio de la clase pajaro
//        {
//            return $"{this.nombre} - {this.edad}";
//            //nombre es inacsesible si no uso protected en los atributos de la clase animal
//            //por el tipo de proteccion
//        }
//        //Clase derivada tiene la facultad de escribir o no el metodo EmitirSonido (por q tiene virtual)
//        public override string EmitirSonido() //las clases que hereden de animal van a heredar este metodo
//        {
//            return "pio pio pio";//puedo llamar a lo que tienen el metodo base de la clase base
//                                 //o escribir el sonido q quiero q haga
//        }
//    }
//}
