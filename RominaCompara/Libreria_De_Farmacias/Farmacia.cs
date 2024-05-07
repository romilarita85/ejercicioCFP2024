namespace Libreria_De_Farmacias
{
    public class Farmacia
    {
        //atributos
        private string nombreFarm;
        private string ubicacionFarm;
        private string horarioDeAtencion;
        private int capacidadDeAlmacenaje;
        private int ingresosMensuales;
        private int presupuesto;
        
        //constructor:
        public Farmacia(string nombreFarm, string ubicacionFarm, string horarioDeAtencion, int capacidadDeAlmacenaje, int ingresosMensuales, int presupuesto)
        {
            this.nombreFarm = nombreFarm;
            this.ubicacionFarm = ubicacionFarm;
            this.horarioDeAtencion = horarioDeAtencion;
            this.capacidadDeAlmacenaje = capacidadDeAlmacenaje;
            this.ingresosMensuales = ingresosMensuales;
            this.presupuesto = presupuesto;
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
        public int GetIngresosMensuales()
        {
            return ingresosMensuales;
        }
        public int GetPresupuesto()
        {
            return presupuesto;
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
            return $"Nombre de la farmacia:{nombreFarm}| Ubicacion: {ubicacionFarm}|Horario de atencion: {horarioDeAtencion}|Capacidad de Almacenamiento: capacidadDeAlmacenaje, int ingresosMensuales, int presupuesto";

        }

        
        //Comportamiento: quiero que farmacia1 compre medicamentos de proveedor
    }
}

