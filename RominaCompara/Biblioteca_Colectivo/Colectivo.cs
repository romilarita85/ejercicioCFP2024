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
        public Colectivo(string patente, int linea, string empresa, int capacidad, string cabecera, string terminal)
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
            return $"Patente:{patente}-linea:{linea}- empresa:{empresa}-capacidad:{capacidad}-cabecera:{cabecera}-terminal:{terminal}";

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
        //88 - 102 = -14 -> negativos
        //88- 88 = 0
        //102-88 = 14 -> positivos
        public static int CompararColectivosPorLinea(Colectivo c1, Colectivo c2 ) 
        {
            //int resultado = 0; //88-88 = 0 
            //if (c1.GetLinea() < c2.GetLinea()) // negativos
            //{
            //    resultado = -1;
            //}
            //else 
            //{
            //    if (c1.GetLinea() > c2.GetLinea())// positivos 
            //    {
            //        resultado = 1;
            //    }
            //}
            //return resultado;

            ///otra forma:**************************************
            return c1.GetLinea() - c2.GetLinea();

        }
        public static int CompararColectivosPorEmpresa(Colectivo c1, Colectivo c2)
        {
            //int resultado = 0; //88-88 = 0 
            //if (String.Compare(c1.GetEmpresa(), c2.GetEmpresa() ) > 0 ) // positivos
            //{
            //    resultado = 1;
            //}
            //else
            //{
            //    if (String.Compare(c1.GetEmpresa(), c2.GetEmpresa() ) < 0 )// negativos 
            //    {
            //        resultado = -1;
            //    }
            //}
            //return resultado;

            ///otra forma mas corta:**************************************
            return String.Compare(c1.GetEmpresa(), c2.GetEmpresa());

        }
        //creo una funcion para saber en que posicion esta mi elemento
    }
}