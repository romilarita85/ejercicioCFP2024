using LibreriaDeClase_Animal;
namespace TesteoGeneral_Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("constructor clase base",3,6.5);
            Animal animal2 = new Gato("tipo de animal constructor gato", 22, 6.5,"azul");
            Animal animal3 = new Pajaro("clase base", 3, 6.5);
            Animal animal4 = new Perro("tipo de animal constructor perro", 7, 6.5);
            
            Gato gato = new Gato("constructor de clase gato", 3, 4.5,"naranja");
            Perro perro = new Perro("constructor de clase perro", 20, 20);
            Pajaro pajaro = new Pajaro("constructor de clase pajaro", 2, 6.5);

            List<Animal> animales = new List<Animal>();
            animales.Add(animal);
            animales.Add(animal2);
            animales.Add(animal3);
            animales.Add(animal4);
            animales.Add(gato);
            animales.Add(pajaro);
            animales.Add(perro);

            foreach (Animal item in animales)
            {
                Console.WriteLine("************************************************************");
                Console.WriteLine($"Tipo de animal:{item.GetType().Name}");
                Console.WriteLine($"Sonido: {item.EmitirSonido()}");

                if (item.GetType() == typeof(Gato))
                {
                    Console.WriteLine(((Gato)item).MostrarDatosGato());//castear item a clase derivada q estamos casteando
                //algo de tipo animal lo quiero castear a algo de tipo Gato
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
