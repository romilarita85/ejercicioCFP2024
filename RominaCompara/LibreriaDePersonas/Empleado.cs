namespace LibreriaDePersonas
{
    public class Empleado
    {
        //1)-ATRIBUTOS -> son los campos que definen mi objeto
        int legajo;
        string nombre;
        string apellido;
        double sueldo;
        string areaDeTrabajo;
        //------------------------------------------------------------------------------------
        //2)-METODOS SET y GET: Darle acceso al usuario para que consulte o cambie un valor
        //-visibilidad
        //-Retorno
        //-Llevar el mismo nombre del campo
        public double GetSueldo() //Consultar un valor
        {
            return this.sueldo;
        }
        public void SetSueldo(double sueldo) //Modificar un valor
        {
            if (sueldo > 0 && sueldo < 10000000)
            {
                this.sueldo = sueldo;
            }
        }
        //---------------------------------------------------------------------------------------------
        //3)-PROPIEDADES-> son una mezcla entre los atributos y/o metodos (get y set) proximamente......

        //---------------------------------------------------------------------------------------------
        //4)-CONSTRUCTOR -> es un metodo que permite crear (instanciar o crear una nueva instancia)
        //objetos de mi clase.
        //Contiene:
        //1-visibilidad (public)
        //2-comportamiento -> estatico o de instancia --
        //para ser STATIC de decirlo explicitamente.
        //de lo contrario es de INSTANCIA
        //3-NUNCA TIENEN RETORNO
        //4-Nombre: SIEMPRE el MISMO que la CLASE (es este caso Empleado)
        //5-Parametros
        public Empleado(int legajo, string nombre, string apellido, double sueldo, string area) //()lo que tengo que recibir
        { 
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sueldo = sueldo;
            this.areaDeTrabajo = area;
        }//this = hace referencia de objetos que estoy creando

        public Empleado(int legajo, string nombre, string apellido)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            //this.sueldo = 0;
            //this.areaDeTrabajo = "sin puesto"; ///this.aredaDeTrabajo = string.Empty
        }
        //------------------------------------------------------------------------------------------------
        //5)-METODOS -> son los comportamientos de mi clase (por lo gral se usan para comunicar info)
        //no son obligatorios (por lo menos tener uno).
        //1-visibilidad
        //2-comportamiento -> estatico o de instancia -- para ser STATIC de decirlo explicitamente. de lo contrario es de INSTANCIA
        //3-retorno
        //4-nombre
        //5-parametros 

        //para mostrar todos o algunos valores.
        public string InformarDatos()
        {
            return $"Legajo: {legajo} - Nombre:{apellido},{nombre} - Puesto:{areaDeTrabajo} - Sueldo: ${sueldo}";
        }
    }
}
