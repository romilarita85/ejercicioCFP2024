namespace Libreria_De_Farmacias
{
    public class Farmacia
    {
        //atributos
        private int capacidadEmpleados;
        private string proveedor;
        private string ubicacionFarm;
        private string nombreMedicamento;
        private int cantidadStock;
        
        //constructor:
        public Farmacia(int capacidadEmpleados, string proveedor, string ubicacionFarm, string nombreMedicamento, int cantidadStock)
        {
            this.capacidadEmpleados = capacidadEmpleados;
            this.proveedor = proveedor;
            this.ubicacionFarm = ubicacionFarm;
            this.nombreMedicamento = nombreMedicamento;
            this.cantidadStock = cantidadStock;
        }
        //Metodos get y set:
        public int GetCapacidadEmpleados()
        {
            return capacidadEmpleados;
        }
        public string GetProveedor()
        {
            return proveedor;
        }
        public string GetUbicacion()
        {
            return ubicacionFarm;
        }
        public string GetNombreMedicamento()
        {
            return nombreMedicamento ;
        }
        public int GetCantidadStock()
        {
            return cantidadStock;
        }
        public void SetUbicacionFarm(string ubicacion)
        {
            ubicacionFarm = ubicacion;
        }
        public void SetProveedor(string nuevoProveedor)
        {
            proveedor = nuevoProveedor;
        }
        //comportamientos
        public string FarmaciaToString()
        {
            return $"Capacidad de empleados:{capacidadEmpleados}-Proveedor:{proveedor}-Ubicacion:{ubicacionFarm}-Nombre medicamento:{nombreMedicamento}-Stock:{cantidadStock}";

        }

        public static string MostrarProveedor() 
        {
            return "Roemmers";
        
        }
    }
}

