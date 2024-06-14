//Crear la clase lapicera, esta debe tener los atributos:
//color,precio,marca, nivel de tinta




using System.Drawing;
using System.Text.RegularExpressions;
using System.Xml.Linq;
namespace BibliotecaDeLapiceras
{
    public class Lapicera
    {
        Color color;
        private double precio;
        private string marca;
        private int nivelDeTinta;
//Un constructor que inicialice color, precio, marca.
        public Lapicera(Color color, double precio, string marca)
        {
            this.color = color;
            this.precio = precio;
            this.marca = marca;
        }
        //Todas las lapiceras se crean con el nivel de tinta al 100.
        public Lapicera(int nivelDeTinta)
        {
            this.nivelDeTinta = 100;
        }
        //crear propiedades todas las propiedad de lectura.
        public double Precio { get => precio; }
        public string Marca { get => marca; }
        public int NivelDeTinta { get => nivelDeTinta; }
        public Color Color { get => color; }
        //Sobreescribir el metodo ToString() para que muestre todos sus valores.
        public override string ToString()
        {

            return $"Color: {Color}, Precio: {Precio}, Marca: {Marca}, Nivel de Tinta: {NivelDeTinta}";

        }
        //Crear el metodo publicv bool Escribir(int cantLetras), donde cada letra consume un nivel de tinta,
        //el metodo debe verificar si tiene tinta 
        public bool Escribir(int cantLetras)
        {

            if (nivelDeTinta >= cantLetras)
            {

                nivelDeTinta -= cantLetras;

                return true;
            }
            else
            {//para escribir la cantidad de letas solicitadas por parametro en informara con un true o false si le alcanzo.

                return false;
            }
            
        }
        public void Recargar()//El metodo public void Recargar() que colocara el nivel a 100 nuevamente.
        {
             nivelDeTinta = 100;
        }
        public static List<Color> ColoresValidos()
        {
            List<Color> list = new List<Color>()
            {
                Color.Black,Color.Blue,Color.Green,Color.Black,Color.Red
            };
            return list;
        }
       

    }

}    
    //Al igual que hicimos con los formularios de ingresante, crear dos forms, el principal con el
    //datagridview y el boton agregar y 
    //el fomrAlta para crear lapiceras, utilizar groupbox, combobox y la mayor variedad de componentes
    //posibles.color, precio, marca, nivelDeTinta

