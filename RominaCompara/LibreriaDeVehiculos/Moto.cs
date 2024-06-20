using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeVehiculos
{
    public class Moto:Vehiculo
    {
        string tipo;
        int cilindrada;

        public Moto(string marca,string modelo,string tipo, int cilindrada)
            :base(marca,modelo)
        {
            this.tipo = tipo;
            this.cilindrada = cilindrada;
        }
        public override string Conducir()//Implementar el método Conducir() para imprimir "Conduciendo una moto"
        {
            return "Conduciendo una moto";
        }
        public string HacerCaballito()//HacerCaballito() : Imprime "La moto está haciendo un caballito
        {
            return "La moto esta haciendo un caballito";
        }

        public virtual string MostrarInfo()//Metodo MostrarInfo() (método que muestra la información básica del vehículo
        {
            return $"{base.MostrarInfo()}|Tipo: {tipo}|Cilindrada: {cilindrada}";
        }


    }
}
