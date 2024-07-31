using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClase_Animal
{
    public class Perro : Animal
    {
        public Perro(string nombre, int edad, double peso) : base(nombre, edad, peso)
        {
        }
        public override string EmitirSonido() 
        {
            return "Guauuuu guauuu";
        }
           
        public string MostrarDatosPerro()
        {
            return $"{base.MostrarDatos}";
        }
    }
}
