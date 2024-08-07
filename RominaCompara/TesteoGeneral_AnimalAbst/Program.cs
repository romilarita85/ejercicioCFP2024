//Testeando la clase animal Abstracta
using LibreriaDeClases_AnimalAbst;
namespace TesteoGeneral_AnimalAbst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //no puedo generar una nueva instancia del tipo animal
            //si puedo utilizar el tipo de variable animal para guardar un gato,perro o pajaro
            //puedo generar o guardar datos del tipo animal con un constructor de las clases derivadas
            //pero no con el constructor animal por que es una clase abstracta
            Animal animal2 = new Gato("tipo de animal constructor gato", 22, 6.5, "azul");
            Animal animal3 = new Pajaro("clase base", 3, 6.5);
            Animal animal4 = new Perro("tipo de animal constructor perro", 7, 6.5);

            Gato gato = new Gato("constructor de clase gato", 3, 4.5, "naranja");
            Perro perro = new Perro("constructor de clase perro", 20, 20);
            Pajaro pajaro = new Pajaro("constructor de clase pajaro", 2, 6.5);

            List<Animal> animales = new List<Animal>();
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
                Console.WriteLine(item.MostrarDatos());
                Console.WriteLine($"Sonido: {item.EmitirSonido()}");
                
                //no hace falta usar el getType ni castear ya que todo volvio a ser polimorfico
               

            }
        }
    }
}
