using BibliotecaDeAlumnos2;
using System.Text;
using System;
namespace BibliotecaDeAlumnos2
{
    public class Alumno
    {
        //private int legajo;
        private string legajo;
        private string nombre;
        private string apellido;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;
        //static Random random = new Random();

        //PROPIEDADES ********************************************************************************************
        //Condicion de set y get al mismo tiempo. //1°get; 2°set
        //Pueden ser autosostenidas-No precisan atributo para existir
        //Puede ser una propiedad que utilice un atributo set y get.
        //puedo hacer q sea solo get o set
        //puedo modificar la visibilidad del get/set
        //Validaciones dentro de un mismo metodo
        //Enmascarar un metodo dentro de una propiedad 
        //Va a hacer referencia a un atributo propio de la clase
        //puedo poner el nombre que quiera pero debe empezar con mayuscula ej: Legajo, Promedio,NotaFinal
        public string Legajo //Propiedad publica de legajo (de la clase)
        {
            get//Define el bloque de código que se ejecutará cuando se intente obtener el valor de la propiedad "Legajo".
            {
                return legajo;//Devuelve el valor de la variable de instancia "legajo".
            }
            set
            {//Define el bloque de código que se ejecutará cuando se intente asignar un valor a la propiedad "Legajo".
                this.legajo = value;//hace referencia a lo que yo haga
                                    //Asigna el valor proporcionado (value) a una variable de instancia llamada "legajo".
                                    //this.legajo = string.Empty;
            }
        }
        //"value" representa el valor que se está asignando a la propiedad.
        //valor que se está asignando a la propiedad en el momento de la asignación
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public static Random Random { get => random; set => random = value; } 

        public int NotaPrimerParcial //Propiedad NotaPrimerParcial
        {
            get => notaPrimerParcial;
            set
            {
                if (value >= 0 && value <= 10)//Validaciones dentro de un mismo metodo
                {
                    notaPrimerParcial = value;
                }
                else
                {
                    notaPrimerParcial = 0;
                }
            }
        }
        public int NotaSegundoParcial //Propiedad NotaSegundoParcial
        {
            get => notaSegundoParcial;
            set
            {
                if (value >= 0 && value <= 10)
                {
                    notaSegundoParcial = value;
                }
                else
                {
                    notaSegundoParcial = 0;
                }
            }
        }
        public double NotaFinal //Propiedad NotaFinal
        {
            get
            {
                return this.CalcularNotaFinal();
            }
        }
        public double Promedio//Propiedad Promedio (para consultar datos)
        {
            get
            {
                return this.CalcularPromedio();
            }
        }
        //CONSTRUCTOR*************************************************************
        //●	Tendrá un constructor estático que inicializará el atributo estático random.

        static Alumno() //CONSTRUCTOR ESTATICO (no puedo acceder a algo de instancia)
        {//no puedo usar this
            Alumno.random = new Random();
        }

        //●	Tendrá un constructor de instancia que inicializará los atributos
        //nombre, apellido y legajo.
        public Alumno(string legajo, string nombre, string apellido)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
        }
        //METODO SET**************************************************************
        //●	El método setter SetNotaPrimerParcial permitirá cambiar
        //el valor del atributo notaPrimerParcial.

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }
        //●	El método setter SetNotaSegundoParcial permitirá cambiar
        //el valor del atributo notaSegundoParcial.

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }
        //COMPORTAMIENTOS************************************************************
        //●El método privado CalcularPromedio retornará el promedio de las dos notas.

        private double CalcularPromedio()
        {
            return ((double)this.notaPrimerParcial + this.notaSegundoParcial) / 2;//Pedia que retorne el double-Castear
        }

        //●	El método CalcularNotaFinal deberá retornar la nota del final
        //con un número aleatorio entre 6 y 10 incluidos siempre y
        //cuando las notas del primer y segundo parcial sean mayores o iguales a 4,
        //caso contrario la inicializará con el valor -1.

        public double CalcularNotaFinal()
        {
            double resultado = -1;
            if ((this.notaPrimerParcial >= 4) && (this.notaSegundoParcial >= 4))
            {
                resultado = Alumno.random.Next(6, 10);//numero aleatorio entre 6 y 10
            }
            return resultado;

        }

        //●	El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
        //Nombre, apellido y legajo.
        //Nota del primer y segundo parcial.
        //Promedio.
        //Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario
        //se mostrará la leyenda "Alumno desaprobado".
        public string Mostrar()
        {
            // Implementa la lógica para mostrar los datos del estudiante
            StringBuilder sb = new StringBuilder();//Se inicializa un objeto StringBuilder llamado sb.
           
            sb.AppendLine($"Alumno: {this.apellido},{this.nombre} - Legajo n°: {this.legajo}");
            sb.AppendLine($"Nota 1° parcial: {this.notaPrimerParcial}");
            sb.AppendLine($"Nota 2° parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {this.CalcularPromedio()}");
            
            double notaFinal = this.CalcularNotaFinal();//Se calcula la nota final del alumno utilizando el
            //método CalcularNotaFinal() y se almacena en la variable notaFinal.

            if (notaFinal != -1)//Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario             
            { //se mostrará la leyenda "Alumno desaprobado".
                sb.AppendLine($"Nota final: {notaFinal}");//Si notaFinal es diferente de -1 (indicando que el
               //alumno aprobó),se añade una línea que muestra la nota final obtenida.
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");//Si notaFinal es -1 (indicando que el alumno desaprobó),
               //se añade una línea indicando "Alumno desaprobado"
            }
            return sb.ToString();
            //Finalmente, el contenido completo del StringBuilder se convierte en una cadena de texto
            //utilizando sb.ToString() y se devuelve como resultado del método Mostrar().
        }
        public static List<Alumno> ListaAlumnos()
        {
            return new List<Alumno>()
                {
                    new Alumno("1001","Roxana","Gomez"),
                    new Alumno("1002","Carlos","Ramos"),
                    new Alumno("1003","Cesar","Vivas"),
                    new Alumno("1004","Clara","Sanchez"),
                    new Alumno("1005", "Andrea", "Alvares")
                };
        }
        public override string? ToString()
        {
            return $"{apellido},{nombre}";
        }

    }
}
