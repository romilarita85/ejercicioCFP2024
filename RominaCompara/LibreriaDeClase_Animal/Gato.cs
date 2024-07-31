using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClase_Animal
{
    public class Gato : Animal
    {
        string colorPelo;

        public Gato(string nombre, int edad, double peso, string colorPelo) : base(nombre, edad, peso)
        {
            this.colorPelo = colorPelo;
        }
        //puedo sobreescribir metodo o no 
        public override string EmitirSonido() //las clases que hereden de animal van a heredar este metodo
        {
            return "Miauuuuuuu miauuuuu";//puedo llamar a lo que tienen el metodo base de la clase base
                                 //o escribir el sonido q quiero q haga
        }
        public string MostrarDatosGato()
        {
            return $"{base.MostrarDatos} - {this.colorPelo}";

        }
    }
}
