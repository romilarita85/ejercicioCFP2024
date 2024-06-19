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
        private int nivelDeTinta ;//Todas las lapiceras se crean con el nivel de tinta al 100.
        //Un constructor que inicialice color, precio, marca.
        public Lapicera(Color color, double precio, string marca)
        {
            this.color = color;
            this.precio = precio;
            this.marca = marca;
            this.nivelDeTinta = 100;
        }
        public Lapicera(int nivelDeTinta)
        {
            this.nivelDeTinta = nivelDeTinta;
        }
        //crear propiedades todas las propiedad de lectura.
        public double Precio { get => precio; }
        public string Marca { get => marca; }
        public string GetMarca()
        {
            return marca;
        }
        public Color Color { get => color; }
        public int NivelDeTinta { get => nivelDeTinta;}

        //Sobreescribir el metodo ToString() para que muestre todos sus valores.
        public string LapiceraToString()
        {
            return $"Color: {Color}, Precio: {Precio}, Marca: {Marca}, Nivel de Tinta: {NivelDeTinta}";
        }
        public override string ToString()
        {
            return this.LapiceraToString();
        }

        //Crear el metodo publicv bool Escribir(int cantLetras), donde cada letra consume un nivel de tinta,
        //el metodo debe verificar si tiene tinta 
        public bool Escribir(int cantLetras)
        {
            bool sePuedeEscribir = false ;

            if (nivelDeTinta >= cantLetras)//verificar si hay nivel de tinta-Comparacion
            {
                nivelDeTinta -= cantLetras; //hay tinta suficiente
                sePuedeEscribir = true; //sePuedeEscribir 
            }
            return sePuedeEscribir;
        }
        public void Recargar()//El metodo public void Recargar() que colocara el nivel a 100 nuevamente.
        {
             this.nivelDeTinta = 100;
        }
        public static List<Color> ColoresValidos()
        {
            List<Color> list = new List<Color>()
            {
                Color.Cyan,Color.White,Color.Black,Color.Blue,Color.Green,Color.Black,Color.Red
            };
            return list;
        }
        //metodo creado para validar marca
        public static bool EsSoloLetras(string dato)
        {
            bool esLetra = true;
            foreach (char letra in dato)
            {
                if (!char.IsLetter(letra))
                {
                    esLetra = false;
                    break;
                }
            }
            return esLetra;
        }
    }
}    
    //Al igual que hicimos con los formularios de ingresante, crear dos forms, el principal con el
    //datagridview y el boton agregar y 
    //el fomrAlta para crear lapiceras, utilizar groupbox, combobox y la mayor variedad de componentes
    //posibles.

