using System.ComponentModel.Design;

namespace LibreriaDeEmpleados
{
    public abstract class Empleado //le saque el abstrac- public abstract class Empleado
    { //o Crear la clase Empleado con los atributos Nombre, Salario,Departamento,Antiguedad.
        protected string nombre;
        protected double salario;
        protected string departamento;
        protected int antiguedad;

        public Empleado(string nombre, double salario, string departamento, int antiguedad)
        {
            this.nombre = nombre;
            this.salario = salario;
            this.departamento = departamento;
            this.antiguedad = antiguedad;
        }
        //o Declarar el método abstracto Trabajar().
        public abstract string Trabajar();//cada clase derivada se hace cargo de su metodo
        //o Implementar el método virtual MostrarInfo() para mostrar la información básica del empleado.
        public virtual string MostrarInfo() 
        {
            return $"Nombre: {nombre} - Salario: {salario} - Departamento: {departamento} - Antiguedad: {antiguedad}";
        
        }
        //o Implementar el método virtual CalcularBonificacion() para calcular una bonificación base,
        //por defecto es 0.
        public virtual double CalcularBonificacion() 
        {
            return 0;
        }
        //o Declarar el método abstracto SueldoTotal(), retorna la informacion de
        //la suma del sueldo mas el valor de la bonificacion
        public abstract double SueldoTotal();


        //**************************************************+

    }
}
