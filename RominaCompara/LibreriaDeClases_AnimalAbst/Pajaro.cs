using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases_AnimalAbst
{
    public class Pajaro:Animal
    {
        public Pajaro(string nombre, int edad, double peso) : base(nombre, edad, peso)
        {
        }

        public override string EmitirSonido() //las clases que hereden de animal van a heredar este metodo
        {
            return "pio pio pio";//puedo llamar a lo que tienen el metodo base de la clase base
                                 //o escribir el sonido q quiero q haga
        }
        public override string MostrarDatos() //tengo la obligacion de implementar metodo abstracto
        {
            return $"{this.nombre} - {this.edad}";
        }
    }
}
