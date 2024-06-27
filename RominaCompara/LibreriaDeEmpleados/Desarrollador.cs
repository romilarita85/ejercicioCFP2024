using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeEmpleados
{
    public class Desarrollador:Empleado//o Crear la clase Desarrollador que herede de Empleado.
    { //o Agregar los atributos LenguajeProgramacion y Experiencia.
        string lenguajeProgramacion;
        string experiencia;

        public Desarrollador(string nombre, double salario, string departamento, int antiguedad,string lenguajeProgramacion, string experiencia)
        :base(nombre,salario,departamento,antiguedad)
        {
            this.lenguajeProgramacion = lenguajeProgramacion;
            this.experiencia = experiencia;
           
        }
        //o Implementar el método Trabajar() para que imprima "El desarrollador está escribiendo código."
        public override string Trabajar() 
        {
            return "El desarrollador está escribiendo código.";
        }

        //o Sobrescribir CalcularBonificacion() para calcular una bonificación específica para desarrolladores,
        //los desarrolladores reciben una bonificacion del 15% del salario.
        public override double CalcularBonificacion()
        {
            return salario * 0.15;

        }

        //o   Implementar el método DepurarCodigo(), debe informar que
        //esta depurando el codigo escrito en un su lenguaje de programacion.
        public string DepurarCodigo()
        {
            return "El desarrollador esta depurando el codigo escrito en su lenguaje de programacion";
        }

        //o Implementar el método SalarioTotal().
        public override double SueldoTotal() 
        {
            return salario + CalcularBonificacion();
        }
        public override string MostrarInfo()
        {
            return $"{base.MostrarInfo()} - Lenguaje de programacion: {lenguajeProgramacion} - Experiencia {experiencia}";

        }

    }
}
