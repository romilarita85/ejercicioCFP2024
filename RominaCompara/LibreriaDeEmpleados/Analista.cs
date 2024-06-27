using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeEmpleados
{
    public class Analista:Empleado //o Crear la clase Analista que herede de Empleado.
    {//o Agregar los atributos Especialidad y Proyectos.
        string especialidad;
        int proyectos;

        public Analista(string nombre, double salario, string departamento, int antiguedad, string especialidad,int proyectos)
        : base(nombre, salario, departamento, antiguedad)
        {
            this.especialidad = especialidad;
            this.proyectos = proyectos;

        }
        //o Implementar el método Trabajar() para que imprima "El analista está analizando los datos."
        //o Sobrescribir CalcularBonificacion() para calcular una bonificación específica para analistas,
        //los desarrolladores reciben una bonificacion del 10% del salario.

        public override string Trabajar()
        {
            return "El analista está analizando los datos.";
        }

       
        public override double CalcularBonificacion()
        {
            return salario * 0.10;

        }
        // o Implementar el método PrepararInforme(),debe informar que
        // le analista esta preparando los informes de sus proyectos.
        public string PrepararInforme() 
        {
            return "El analista esta preparando los informes de sus proyectos";
        }


        //o Implementar el método SalarioTotal().
        public override double SueldoTotal()
        {
            return salario + CalcularBonificacion();
        }
        public override string MostrarInfo()
        {
            return $"{base.MostrarInfo()} - Especialidad: {especialidad} - Proyectos: {proyectos}";

        }

    }
}
