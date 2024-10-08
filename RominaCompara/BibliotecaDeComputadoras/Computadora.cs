﻿using System.Text;

namespace BibliotecaDeComputadoras
{
    public class Computadora
    {
        int numeroDeSerie;
        int memoriaRam;
        int capacidadDisco;
        string procesador;
        string sistemaOperativo;
        List<string> programas;
        //❖Todas las propiedades son de solo lectura y retornan el valor de los atributos que
        //hacen referencia, excepto Programas, esta propiedad retorna un string con todos los nombres
        //de los programas concatenados.
        public int NumeroDeSerie { get => numeroDeSerie; set => numeroDeSerie = value; }
        public int MemoriaRam { get => memoriaRam; }
        public int CapacidadDisco { get => capacidadDisco; }
        public string Procesador { get => procesador; }
        public string SistemaOperativo { get => sistemaOperativo; }
       
        public string Programas
        {
            get
            {
                StringBuilder todos = new StringBuilder();
                for (int i = 0; i < programas.Count; i++)
                {
                    todos.Append(programas[i]);
                    if (i < programas.Count - 1)
                    {
                        todos.Append(" - ");
                    }
                }
                return todos.ToString();
            }
        }
        //❖	Constructor privado que solo instancia la lista de programas.
        private Computadora() 
        {
            this.programas = new List<string>();
        }
  
        //❖Constructor público que asigna valores a todos sus campos excepto a la lista de programas.
        public Computadora(int memoriaRam, int capacidadDisco, string procesador, string sistemaOperativo, int numeroDeSerie = 0 )
        : this()
        {
            this.memoriaRam = memoriaRam;
            this.capacidadDisco = capacidadDisco;
            this.procesador = procesador;
            this.sistemaOperativo = sistemaOperativo;
            this.numeroDeSerie = numeroDeSerie;
        }
        //❖	Método get que retorna la lista de programas.
        public List<string>GetProgramas()
        {
            return this.programas;
        
        }
        //❖	Método set que se encarga de agregar un programa a la lista.
        public void SetPrograma(string programa) //Metodo
        {
            this.programas.Add(programa);
        
        }
        //❖Método static ListadoDeProcesadores() que retorna una lista de al menos 5 tipos de procesadores
        //public static List<string> ListadoDeProcesadores()
        //{
        //    List<string> list = new List<string>()
        //    {
        //        "Word pad","Microsoft word","Google Docs","Mac os","Pentium"
        //    };
        //    return list;
        //}
        public static List<string> ListadoDeProcesadores()
        {
            return new List<string>()
            {
                "Word pad","Microsoft word","Google Docs","Mac os","Pentium"
            };
        }

       
        public override string ToString() 
        {
            return $"{procesador} - {memoriaRam} - {sistemaOperativo}";
        }
        public void CargarProgramasDesdeUnString(string programas) 
        {
            //List<string> list = new List<string>();
            //list.AddRange(programas.Split(" - "));
            //this.programas = list;  
            this.programas.AddRange(programas.Split(" - "));
        }
        //Metodo Split: Para hacer particion de cadena.Tipo de caracter va a particionar cada palabra.
        //quiero q haga un corte y particine las palabras.
      
        //Sobreecribir metodo para pc:
        //1-Metodo largo Equals
        //public override bool Equals(object pc) 
        //{
        //    bool sonIguales = false;
        //    if (pc is not null)//ver q el objeto no sea nul0
        //    {
        //        if (pc.GetType().Name == typeof(Computadora).Name) //ver si es del mismo tipo
        //        {//lo puedo pasar a computadora
        //            Computadora pcComparar = (Computadora)pc;
        //            sonIguales = this.numeroDeSerie == pcComparar.numeroDeSerie;
        //        }
        //    }
        //    return sonIguales;
        //}
        //2-Metodo mas simple de Equals
        public override bool Equals(object pc)
        {
            Computadora pcComparar = pc as Computadora;
            //Comparar q no sea nulo y luego acceder a los metodos
            
            return pcComparar is not null && this.numeroDeSerie == pcComparar.numeroDeSerie;
        }
        //Equals: recibe un object y lo compara contra si mismo de lo da con la base principal object.
         //Se utiliza para comparar dos objetos y determinar si son iguales.
         //Es un método que está definido en la clase base Object, que es la clase raíz de todas las clases en C#. 
    }
}
//public string Programas 
//{
//    get 
//    {
//        string todos = string.Empty;
//        for (int i = 0; i < programas.Count; i++)
//        {
//            todos += programas[i];
//            if (i<programas.Count -1)
//            {
//                todos +=  " - ";
//            }
//        }
//        return todos;
//    }
//}

//Usando StringBuilder*********
//public string Programas
//{
//    get
//    {
//        StringBuilder sb = new StringBuilder();

//        for (int i = 0; i < programas.Count; i++)
//        {
//            sb.Append(programas[i]);

//            if (i < programas.Count - 1)
//            {
//                sb.Append(" - ");
//            }
//        }
//        return sb.ToString(); 
//    }
//}
//Modificacion 24/04/24