using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_GRAL
{
    public class ejemplo_de_otra_clase
    {
        public string nombre;

        public ejemplo_de_otra_clase() //declaro public para que pueda relacionarse con program
        {
            this.nombre = "Carlos";
        }
        public static string PedirCadena(string mensaje)
        {
            Console.Write(mensaje);
            return Console.ReadLine();
        }

    }
}
