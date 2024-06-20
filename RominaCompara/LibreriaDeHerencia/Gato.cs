using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeHerencia
{
    public class Gato:Animal
    {
        
        string colorDePelo;
        string raza;
        public Gato(string nombre, double peso, int edad, string colorDePelo,string raza)
            :base(nombre,peso,edad)
        {
            
            this.colorDePelo = colorDePelo;
            this.raza = raza;
        }
        public override string EmitirSonido()
        {
            return "MIAUUU MIAUUU";
        }
        public override string EjercerAccion()
        {
            return "Rasguñar";
        }
        public override string MostrarInfo()
        {
            return $"{base.MostrarInfo()}|Color de pelo:{colorDePelo}|Raza:{raza}";
        }
    }
}
//************************************************************
//namespace LibreriaDeHerencia
//{
//    public class Gato
//    {
//        string nombre;
//        double peso;
//        int edad;
//        string colorDePelo;
//        string raza;
//        public Gato(string nombre, double peso, int edad, string colorDePelo, string raza)
//        {
//            this.nombre = nombre;
//            this.peso = peso;
//            this.edad = edad;
//            this.colorDePelo = colorDePelo;
//            this.raza = raza;
//        }
//        public string EmitirSonido()
//        {
//            return "MIAUUU MIAUUU";
//        }
//    }
//}
