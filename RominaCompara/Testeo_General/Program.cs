//Clase 29-07-24
using Libreria_De_Clases;
namespace Testeo_General
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona primeraPesona = new Persona("Luis",22,70.5);//->Metodo retorna una nueva instnacia de la clase persona
            //Clase--Instancia --=
            //Con algo de instancia puedo crear un nuevo objeto y darle valores a sus atributos
            //por medio de las properties o un constructor parametrizado
            //primeraPesona.Dni = "27944534545";
            //string dato = primeraPesona.Dni; //Propiedad autosostenida "Dni"

            //Usando Properties
            string nombrePropiedad = primeraPesona.Nombre;//usando metodo get (de la propertie)
            primeraPesona.Nombre = "Carlos"; 
            //Usando Metodos get/set
            string nombreGet = primeraPesona.GetNombre();//usando metodo get
            primeraPesona.SetNombre ("Carlos");
        }
    }
}
//***********************************************************************************************************
//using Libreria_De_Clases;
//namespace Testeo_General
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Persona primerPesona = new Persona();//->Metodo retorna una nueva instnacia de la clase persona
//            //puedo crear una nueva instancia.Por default si no hago declaracion de un constructor
//            //voy a tener un constructor vacio.Por medio del constructor vacio tengo
//            //una nueva instancia
//            //Puedo darle valores por medio de las propiedades de lectura y estritura que cree en libreria
//            primerPesona.Nombre = "Luis";
//            primerPesona.Edad = 22;
//            primerPesona.Peso = 70.5;
//            //Con algo de instancia puedo crear un nuevo objeto y darle valores a sus atributos
//            //por medio de las properties o un constructor parametrizado
//        }
//    }
//}
//*****************************************************************************************************
//namespace Testeo_General
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Persona primeraPesona = new Persona("Luis", 22, 70.5);//->Metodo retorna una nueva instnacia
//            de la clase persona
//            //Clase--Instancia --=
//            //Con algo de instancia puedo crear un nuevo objeto y darle valores a sus atributos
//            //por medio de las properties o un constructor parametrizado
//            primeraPesona.Dni = "27944534545";
//            string dato = primeraPesona.Dni; //Propiedad autosostenida "Dni"
//        }
//    }
//}