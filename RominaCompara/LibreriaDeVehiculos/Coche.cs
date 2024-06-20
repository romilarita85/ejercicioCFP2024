using System.Reflection;
using System.Text.RegularExpressions;

namespace LibreriaDeVehiculos
{
    public class Coche:Vehiculo
    {
        int numeroPuertas;
        double capacidadMaletero;

        public Coche(string marca,string modelo,int numeroPuertas, double capacidadMaletero)
        : base(marca, modelo)
        {
            this.numeroPuertas = numeroPuertas;
            this.capacidadMaletero = capacidadMaletero;
        }
        public override string Conducir()//Implementar el método Conducir() para imprimir "Conduciendo un coche"
        {
            return "Conduciendo un coche";
        }
        public string AbrirMaletero() //AbrirMaletero() : Imprime "El maletero del coche se ha abierto"
        {
            return "El maletero del coche se ha abierto";
        }

        public virtual string MostrarInfo()//Metodo MostrarInfo() (método que muestra la información básica del vehículo
        {
            return $"{base.MostrarInfo()}|Numero de puertas: {numeroPuertas}|Capacidad de maletero: {capacidadMaletero}";
        }
     
       
       

    }
}
