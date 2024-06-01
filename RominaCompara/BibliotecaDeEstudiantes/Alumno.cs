using BibliotecaDeEstudiantes;
using System.Text;
using System;
namespace BibliotecaDeEstudiantes
{                                              //CAPTURA 1412
    public class Alumno
    {   //private int legajo;
        private string legajo;
        private string nombre;
        private string apellido;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;
        //static Random random = new Random();

        //PROPIEDADES ********************************************************************************************
        //puedo modificar la visibilidad del get/set
        //1°get; 2°set
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
        public string Nombre { get; set; }
        public string Apellido { get; set; }
       
        public static Random Random { get; set; }
        public int NotaPrimerParcial //Propiedad NotaPrimerParcial
        { 
            get => notaPrimerParcial;
            set 
            {
                if (value >= 0 && value <= 10)
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
        public double Promedio//Propiedad Promedio
        {
            get
            {
                return this.CalcularPromedio();
            }
        }
        //CONSTRUCTOR*************************************************************
        //●	Tendrá un constructor estático que inicializará el atributo estático random.
        static Alumno() //CONSTRUCTOR ESTATICO
        { 
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
            return ((double)this.notaPrimerParcial + this.notaSegundoParcial) / 2;
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
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Alumno: {this.nombre},{this.apellido} - Legajo n°: {this.legajo}");
            sb.AppendLine($"Nota 1° parcial: {this.notaPrimerParcial}");
            sb.AppendLine($"Nota 2° parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {this.CalcularPromedio()}");
            double notaFinal = this.CalcularNotaFinal();
            
            if (notaFinal != -1)
            {
                sb.AppendLine($"Nota final: {notaFinal}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }
            return sb.ToString();
        }
    }
}

//public string Mostrar()
//{
//    double notaFinal = CalcularNotaFinal();
//    if (CalcularNotaFinal() == -1)
//    {
//        return $"Nombre: {nombre}\n" +
//           $"Apellido: {apellido}\n" +
//           $"Legajo: {legajo}\n" +
//           $"Nota del primer parcial: {notaPrimerParcial}\n" +
//           $"Nota del segundo parcial: {notaSegundoParcial}\n" +
//           $"Promedio: {CalcularPromedio()}\n" +
//           "Alumno desaprovado";
//    }
//    else 
//    {
//        return $"Nombre: {nombre}\n" +
//           $"Apellido: {apellido}\n" +
//           $"Legajo: {legajo}\n" +
//           $"Nota del primer parcial: {notaPrimerParcial}\n" +
//           $"Nota del segundo parcial: {notaSegundoParcial}\n" +
//           $"Promedio: {CalcularPromedio()}\n" +
//           $"Nota final: {notaFinal}";

//    }
//}