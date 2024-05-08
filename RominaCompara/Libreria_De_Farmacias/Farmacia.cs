namespace Libreria_De_Farmacias
{
    public class Farmacia
    {
        //atributos
        private string nombreFarm;
        private string ubicacionFarm;
        private string horarioDeAtencion;
        private int capacidadDeAlmacenaje;// cantidad de productos que puede almacenar
        private double ingresosMensuales;
        
        //constructor:
        public Farmacia(string nombreFarm, string ubicacionFarm, string horarioDeAtencion, int capacidadDeAlmacenaje, double ingresosMensuales)
        {
            this.nombreFarm = nombreFarm;
            this.ubicacionFarm = ubicacionFarm;
            this.horarioDeAtencion = horarioDeAtencion;
            this.capacidadDeAlmacenaje = capacidadDeAlmacenaje;
            this.ingresosMensuales = ingresosMensuales;
        }

        //Metodos get y set:
        public string GetNombreFarm()
        {
            return nombreFarm;
        }
        public string GetUbicacionFarm()
        {
            return ubicacionFarm;
        }
        public string GetHorarioDeAtencion()
        {
            return horarioDeAtencion;
        }
        public int GetCapacidadDeAlmacenaje()
        {
            return capacidadDeAlmacenaje ;
        }
        public double GetIngresosMensuales()
        {
            return ingresosMensuales;
        }
        public void SetUbicacionFarm(string ubicacion)
        {
            ubicacionFarm = ubicacion;
        }
        public void SetCapacidadDeAlmacenaje(int nuevaCapDeAlmacenaje)
        {
            capacidadDeAlmacenaje = nuevaCapDeAlmacenaje;
        }
        //comportamientos
        public string FarmaciaToString()
        {
            return $"Nombre de la farmacia:{nombreFarm}| Ubicacion: {ubicacionFarm}|Horario de atencion: {horarioDeAtencion}|Capacidad de Almacenamiento: {capacidadDeAlmacenaje}| Ingresos mensuales: {ingresosMensuales}";

        }

        // Método para registrar ventas y actualizar ingresos mensuales
        public double RegistrarVentas(double montoDeVenta)
        {
            return ingresosMensuales += montoDeVenta;
            
        }

        
    }
}

