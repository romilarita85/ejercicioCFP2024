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

        public string MostrarInfo()
        { 
            return $"{this.nombre}; //nombre es inacsesible por el tipo de proteccion
        }
    }
}
