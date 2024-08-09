using System.Text;

namespace BibliotecaDeComputadoras
{
    public class Computadora
    {
        private int memoriaRam;
        private int capacidadDisco;
        private string procesador;
        private string sistemaOperativo;
        private List<string> programas;

        //❖	Constructor privado que solo instancia la lista de programas.
        private Computadora() 
        {
            this.programas = new List<string>();
        }
  
        //❖Constructor público que asigna valores a todos sus campos excepto a la lista de programas.
        public Computadora(int memoriaRam, int capacidadDisco, string procesador, string sistemaOperativo)
        :this()
        {
            this.memoriaRam = memoriaRam;
            this.capacidadDisco = capacidadDisco;
            this.procesador = procesador;
            this.sistemaOperativo = sistemaOperativo;
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

        //❖	Todas las propiedades son de solo lectura y retornan el valor de los atributos que
        //hacen referencia, excepto Programas, esta propiedad retorna un string con todos los nombres
        //de los programas concatenados.
        public int MemoriaRam { get => memoriaRam; }
        public int CapacidadDisco { get => capacidadDisco; }
        public string Procesador { get => procesador; }
        public string SistemaOperativo { get => sistemaOperativo; }

        public string Programas 
        {
            get 
            {
                string todos = string.Empty;
                for (int i = 0; i < programas.Count; i++)
                {
                    todos += programas[i];
                    if (i<programas.Count -1)
                    {
                        todos +=  " - ";
                    }
                }
                return todos;
            }
        }
        public void CargarProgramasDesdeUnString(string programas) 
        {
            List<string> list = new List<string>();
            list.AddRange(programas.Split(" - "));
            this.programas = list;  
        }

        //public string Programas
        //{
        //    get
        //    {
        //        StringBuilder todos = new StringBuilder();
        //        for (int i = 0; i < programas.Count; i++)
        //        {
        //            todos.Append(programas[i]);
        //            if (i < programas.Count - 1)
        //            {
        //                todos.Append(" - ");
        //            }
        //        }
        //        return todos.ToString();
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

    }
}
