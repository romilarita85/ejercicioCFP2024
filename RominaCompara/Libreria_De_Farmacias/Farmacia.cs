namespace Libreria_De_Farmacias
{
    public class Farmacia
    {
        //atributos
        private string nombreFarm;
        private string proveedor;
        private string ubicacionFarm;
        private string nombreMedicamento;
        private int precioMedicamento;
        private int cantidadStock;
        
        //constructor:
        public Farmacia(string nombreFarm, string proveedor, string ubicacionFarm, string nombreMedicamento, int precioMedicamento,int cantidadStock)
        {
            this.nombreFarm = nombreFarm;
            this.proveedor = proveedor;
            this.ubicacionFarm = ubicacionFarm;
            this.nombreMedicamento = nombreMedicamento;
            this.precioMedicamento = precioMedicamento;
            this.cantidadStock = cantidadStock;
        }
        //Metodos get y set:
        public string GetNombreFarm()
        {
            return nombreFarm;
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
        public int GetPrecioMedicamento()
        {
            return precioMedicamento;
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
            return $"Nombre de la farmacia:{nombreFarm}|Proveedor: {proveedor}|Ubicacion: {ubicacionFarm}|Nombre del medicamento: {nombreMedicamento}|Precio de medicamento: ${precioMedicamento}|Stock: {cantidadStock}";

        }

        public static string MostrarProveedor() 
        {
            return "Bayer";
        
        }
    }
}

