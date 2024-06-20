using LibreriaDeHerencia;
namespace Ej_Herencia_Class19_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal loro1 = new Loro("Pepe",500,30);
            //Animal gato1 = new Gato("Silvestre",5000,5,"Naranja","Angora");
            //Animal perro1 = new Perro("Bobby",20000,7,"Corto","Pastor Aleman","Jorge");

            List<Animal> animales = new List<Animal>() 
            { 
                new Loro("Pepe",500,30), 
                new Gato("Silvestre", 5000, 5, "Naranja", "Angora"),
                new Perro("Bobby", 20000, 7, "Corto", "Pastor Aleman", "Jorge")
            };

            foreach (Animal animal in animales)
            {
                Console.WriteLine( $"Tipo de animal: {animal.GetType().Name} {animal.MostrarInfo()}" );
            }
        }
    }
}
//***********************************************************************
//using LibreriaDeHerencia;
//namespace Ej_Herencia_Class19_06
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Loro loro1 = new Loro("Pepe", 500, 30);
//            Gato gato1 = new Gato("Silvestre", 5000, 5, "Naranja", "Angora");
//            Perro perro1 = new Perro("Bobby", 20000, 7, "Corto", "Pastor Aleman", "Jorge");
//            Animal animal1 = new Animal("Generico", 0, 0);//sin usar abstract


//            List<Animal> animales = new List<Animal>();

//            animales.Add(loro1);
//            animales.Add(gato1);
//            animales.Add(perro1);
//            animales.Add(animal1);//sin usar abstract

//            foreach (Animal animal in animales)
//            {
//                //    if (animal is Perro)
//                //    {
//                //        Console.WriteLine(((Perro)animal).EmitirSonido());
//                //    }
//                //    else if (animal is Gato)
//                //    {
//                //        Console.WriteLine(((Gato)animal).EmitirSonido());
//                //    }
//                //    else if (animal is Loro) 
//                //    {
//                //        Console.WriteLine(((Loro)animal).EmitirSonido());
//                //    }

//                Console.WriteLine($"Tipo de animal: {animal.GetType().Name} sonido:{animal.EmitirSonido()}");

//            }
//        }
//    }
//}