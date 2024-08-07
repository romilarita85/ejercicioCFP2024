using LibreriaDeClase_Animal;
namespace TesteoGeneral_Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("constructor clase base",3,6.5);

            Animal animal2 = new Gato("tipo de animal constructor gato", 22, 6.5,"azul");
            Animal animal3 = new Pajaro("constructor clase base", 3, 6.5);
            Animal animal4 = new Perro("tipo de animal constructor perro", 7, 6.5);
            
            Gato gato = new Gato("constructor de clase gato", 3, 4.5,"naranja");
            Perro perro = new Perro("constructor de clase perro", 20, 20);
            Pajaro pajaro = new Pajaro("constructor de clase pajaro", 2, 6.5);

            //COMO LORO,GATO Y PERRO SON CLASE CON HERENCIA SON DE LA MISMA FAMILIA-
            //PUEDO GENERAR UNA LISTA GENERICA
            List<Animal> animales = new List<Animal>(); //Coleccion o lista de animales
            animales.Add(animal);
            animales.Add(animal2);
            animales.Add(animal3);
            animales.Add(animal4);
            animales.Add(gato);
            animales.Add(pajaro);
            animales.Add(perro);

            foreach (Animal item in animales) //sacamos algo del tipo Animal,un item dentro de la coleccion animales
            { //item:  representa c/elemento de la iteracion
                Console.WriteLine("************************************************************");
                Console.WriteLine($"Tipo de animal:{item.GetType().Name}");
                //GetType: me va a devolver algo del tipo de la clase (con nombre de la clase: gato,perro,loro etc)
                Console.WriteLine($"Sonido: {item.EmitirSonido()}");
               
                if (item.GetType() == typeof(Gato))
                {
                    Console.WriteLine(((Gato)item).MostrarDatosGato());//castear item a clase derivada q
                                                                       //estamos casteando algo de tipo animal lo quiero castear a algo de tipo Gato
                }
                else
                {
                    Console.WriteLine(item.MostrarDatos());
                }
            }

            //Console.WriteLine(animal2.GetType().Name);
        }
    }//Puedo crear objetos utilizando el tipo de la clase base en algo derivado
}
