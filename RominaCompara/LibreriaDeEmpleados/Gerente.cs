using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeEmpleados
{
    public class Gerente:Empleado //o Crear la clase Gerente que herede de Empleado.
    {
        int numeroEnpleados;//o Agregar el atributo NumeroEmpleados.
       
        public Gerente(string nombre, double salario, string departamento, int antiguedad, int numeroEmpleados)
            :base(nombre,salario,departamento,antiguedad)
        {
            this.numeroEnpleados = numeroEmpleados;            
        }

        //o Implementar el método Trabajar() para que imprima "El gerente está gestionando el departamento."
        public override string Trabajar()
        {
            return "El gerente esta gestionando el departamento";
        }

        //o Sobrescribir CalcularBonificacion() para calcular una bonificación específica para gerentes,
        //los gerentes reciben una bonificacion del 25% del salario.
        public override double CalcularBonificacion() 
        { 
            return salario* 0.25; 
        
        }

        //o   Implementar el método Planificar(), es retorna un string que informara que
        //el gerente es creando una planificacion para la cantidad de empleados que tenga a cargo.
        public string Planificar() 
        {
            return "El gerente esta creando una planificacion para la cantidad de empleados a su cargo";
        }
        public override double SueldoTotal()
        {
            return salario + CalcularBonificacion();
        }
        public override string MostrarInfo()
        {
            return $"{base.MostrarInfo()} - Numero de empleados: {numeroEnpleados}";

        }
    }
}
