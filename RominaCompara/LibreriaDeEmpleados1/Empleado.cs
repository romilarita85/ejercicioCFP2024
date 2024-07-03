namespace LibreriaDeEmpleados1
{
    public class Empleado
    {
        private string nombre;
        private double salario;
        private string departamento;
        private int antiguedad;

        public Empleado(string nombre, double salario, string departamento, int antiguedad)
        {
            this.nombre = nombre;
            this.salario = salario;
            this.departamento = departamento;
            this.antiguedad = antiguedad;
        }

        public string MostrarInfo()
        {
            return $"Nombre: {nombre} - Salario: {salario} - Departamento: {departamento} - Antiguedad: {antiguedad}";

        }
  

        //**************************************************+
        public override string? ToString()//Metodo ToString propio de todos los objetos
        {
            return MostrarInfo();
        }
        protected string Nombre { get => nombre; set => nombre = value; }
        protected double Salario { get => salario; set => salario = value; }
        protected string Departamento { get => departamento; set => departamento = value; }
        protected int Antiguedad { get => antiguedad; set => antiguedad = value; }
    }
}
