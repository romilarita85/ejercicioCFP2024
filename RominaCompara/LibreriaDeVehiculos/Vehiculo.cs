using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibreriaDeVehiculos
{
    public abstract class Vehiculo
    {
        protected string marca;
        protected string modelo;

        protected Vehiculo(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        public abstract string Conducir();//Metodo Conducir() (método abstracto)

        public virtual string MostrarInfo()//Metodo MostrarInfo() (método que muestra la información básica del vehículo
        {
            return $"Marca:{marca}|Modelo: {modelo}";
        }

    }
}
