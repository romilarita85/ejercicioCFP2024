using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeHerencia
{
    public class Loro:Animal
    {
        
        public Loro(string nombre, double peso, int edad)
            :base(nombre,peso,edad)
        {

        }
        public override string EmitirSonido() 
        {
            return "PRRRR PRRRR";
        }
        public override string EjercerAccion()
        {
            return "Picar";
        }
        public override string MostrarInfo()
        {
            return base.MostrarInfo();
        }
    }
}
//*************************************************
//namespace LibreriaDeHerencia
//{
//    public class Loro
//    {
//        string nombre;
//        double peso;
//        int edad;

//        public Loro(string nombre, double peso, int edad)
//        {
//            this.nombre = nombre;
//            this.peso = peso;
//            this.edad = edad;
//        }
//        public string EmitirSonido()
//        {
//            return "PRRRR PRRRR";
//        }
//    }
//}
