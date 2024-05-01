//Colecciones mas comunes: listas, colas,-> vamos a poder crear tanto como quieramos
//pueden ser de cualquier tipo o pueden ser genericas ej. una lista de autos o de personas
namespace Biblioteca_Colectivo
{
    public class Colectivo
    {
        //Atributos:(van a ser privados en este caso -si no le pongo nada asume que son privados)

        private string patente;
        private int linea;
        private string empresa;
        private int capacidad;
        private string cabecera;
        private string terminal;
        private int cantidadDePasajeros;

        //Constructor:el unico metodo que no tenia retorno (void)
        //constructor va a ser de instancia
        //no tiene retorno y lleva siempre el nombre de la clase
        //puedo tener varios constructores pero respetando los parametros
        public Colectivo(string patente, int linea, string empresa, int capacidad, string cabecera, string terminal, int cantidadDePasajeros)
        {
            this.patente = patente;
            this.linea = linea;
            this.empresa = empresa;
            this.capacidad = capacidad;
            this.cabecera = cabecera;
            this.terminal = terminal;
            this.cantidadDePasajeros = 0;
        }
        //MetodosGetters y Setters-> Permitir consultar(get)
        //y/o modificar atributos(set insertar o agregar)
        //tienen que hacer referencia al atributo con el q estan trabajando
        public string GetPatente()
        {
            return patente;
        }
        public int GetLinea()
        {
            return linea;
        }
        public string GetEmpresa()
        {
            return empresa;
        }
        public int GetCapacidad()
        {
            return capacidad;
        }
        public string GetTerminal()
        {
            return terminal;
        }
        public string GetCabecera()
        {
            return cabecera;
        }

        // los set no tienen retorno;
        public void SetTerminal(string destino)
        {
            terminal = destino;
        }
        public void SetCabecera(string destino)
        {
            cabecera = destino;
        }
        //Comportamientos:
        public string ColectivoToString()
        {
            return $"Patente:{patente}-linea:{linea}- empresa:{empresa}-capacidad:{capacidad}-terminal:{terminal}-cabecera:{cabecera}-Cantidad de pasajeros:{cantidadDePasajeros}";

        }

        public bool SubirPasajeros(int cantidad)
        {
            bool puedenSubir = false;
            if ((this.capacidad > this.cantidadDePasajeros) && (this.cantidadDePasajeros + cantidad <= capacidad))
            {
                this.cantidadDePasajeros += cantidad;
                puedenSubir = true;
            }
            return puedenSubir;
        }
    }
}