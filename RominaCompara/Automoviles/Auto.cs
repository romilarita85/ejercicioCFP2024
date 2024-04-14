
namespace Automoviles
{
    public class Auto
    {
        //Tipos de clases
        //-Estatic: no requiere instancia.
        //-De instancia

        //Atributos
        //marca, modelo, motor, puertas, rodado, color, transmicion, patente
        public string marca;
        public string patente;
        public int modelo;
        public double precio;
        public Auto(string marca, string patente, int modelo, double precio)
        {
            this.marca = marca;
            this.patente = patente;
            this.modelo = modelo;
            this.precio = precio;
        }

        //Comportamiento
        public string TocarBocina() 
        {
            return "tuuuuuuuuutuuu";
        }
    }
}
