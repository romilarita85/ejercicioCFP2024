using Biblioteca_Colectivo;//le digo q utilice todo lo que esta en mi biblioteca
namespace Testeo_Colectivo
{
    internal class Program//crear todo lo que sea de nuestra clase
    {
        static void Main(string[] args)
        {
            //**********************************
            //Colectivo colectivo1;//Declaracion de la variable tipo de colectivo
            //colectivo1 = new Colectivo("AD123BC", 85, "MONSA", 50, "Lanus", "Retiro");
            //// por medio de la palabra reservada new y el constructor creo una nueva instancia de mi clase
            //string info;
            //info = colectivo1.ColectivoToString();
            //Console.WriteLine(info);
            //**************************************
            Colectivo colectivo1 = new Colectivo("AD123BC", 85, "MONSA", 50, "Lanus", "Retiro");
            Colectivo colectivo2 = new Colectivo("CD456BC", 07, "CAT", 45, "Lanus", "Retiro");
            Colectivo colectivo3 = new Colectivo("SC853BC", 22, "SUR", 30, "Lomas", "Avellaneda");
            Colectivo colectivo4 = new Colectivo("MN201BC", 285, "RAPIDO", 50, "Constitucion", "Recoleta");
            Colectivo colectivo5 = new Colectivo("LO741BC", 458, "NORTE", 65, "Once", "Barracas");

            Colectivo[] misColectivos = new Colectivo[5];
            misColectivos[0] = colectivo1;
            misColectivos[1] = colectivo2;
            misColectivos[2] = colectivo3;
            misColectivos[3] = colectivo4;
            misColectivos[4] = colectivo5;

            Console.WriteLine("**********************Mostrando el array completo**********************");

            foreach (Colectivo item in misColectivos)
            {
                Console.WriteLine(item.ColectivoToString());
            }
            misColectivos[4] = null; //si quiero eliminar una posicion-No lo puedo hacer

            Console.WriteLine("Mostrando el borrando el ultimo elemento");

            foreach (Colectivo item in misColectivos)
            {
                if(item is not null)
                {
                    Console.WriteLine(item.ColectivoToString()); 
                }
            }

            List<Colectivo> listaDeColectivos = new List<Colectivo>(); 
            listaDeColectivos.Add(colectivo1);
            listaDeColectivos.Add(colectivo2);
            listaDeColectivos.Add(colectivo3);
            listaDeColectivos.Add(colectivo4);
            listaDeColectivos.Add(colectivo5);

            Console.WriteLine("**********************Mostrando la lista completa**********************");

            foreach (Colectivo item in listaDeColectivos)
            {
                Console.WriteLine(item.ColectivoToString());
            }

            //listaDeColectivos.Remove(colectivo5); //eliminar por elemento
            ////listaDeColectivos.RemoveAt(4); // eliminar por posicion

            //Console.WriteLine("\n****Mostrando el borrado del ultimo elemento****");

            //foreach (Colectivo item in listaDeColectivos)
            //{
            //    Console.WriteLine(item.ColectivoToString());
            //}

           

            Console.WriteLine("**********************Mostrando la lista ordenada por linea**********************");
            foreach (Colectivo item in listaDeColectivos)
            {
                Console.WriteLine(item.ColectivoToString());
            } 
            listaDeColectivos.Sort(Colectivo.CompararColectivosPorLinea);

            
            Console.WriteLine("**********************Mostrando la lista ordenada por empresa**********************");

            foreach (Colectivo item in listaDeColectivos)
            {
                Console.WriteLine(item.ColectivoToString());
            }
            listaDeColectivos.Sort(Colectivo.CompararColectivosPorEmpresa);

            
            Console.WriteLine("**********************Mostrando la lista sin linea 22**********************");

            //int indice = RetornarIndiceEnLista(listaDeColectivos); //la linea a borrar se especifica en la funcion
            int indice = RetornarIndiceEnLista(listaDeColectivos, 22); //especifico la linea a borrar
            
            listaDeColectivos.RemoveAt(indice);

            foreach (Colectivo item in listaDeColectivos)
            {
                Console.WriteLine(item.ColectivoToString());
            }
            Console.WriteLine("**********************Mostrando la lista sin linea 85**********************");
           
            indice = RetornarIndiceEnLista(listaDeColectivos, 85);
            
            listaDeColectivos.RemoveAt(indice);
            
            foreach (Colectivo item in listaDeColectivos)
            {
                Console.WriteLine(item.ColectivoToString());
            }

            //do
            //{
            //    Console.WriteLine("Ingrese la cantidad de pasajeros: ");

            //    if (colectivo1.SubirPasajeros(int.Parse(Console.ReadLine())))
            //    {
            //        Console.WriteLine("puede subir");

            //    }
            //    else
            //    {
            //        Console.WriteLine("no hay mas espacio");
            //    }

            //} while (true);
        }
        //public static int RetornarIndiceEnLista(List<Colectivo> lista) //si quiero eliminar linea 22
        //{

        //    int indice = -1;
        //    foreach (Colectivo item in lista)
        //    {
        //        if (item.GetLinea() == 22)
        //        {
        //            indice = lista.IndexOf(item);

        //        }
        //    }
        //    return indice;

        //}
        public static int RetornarIndiceEnLista(List<Colectivo> lista,int linea) // quiero eliminar una linea especif
        {

            int indice = -1;
            foreach (Colectivo item in lista)
            {
                if (item.GetLinea() == linea)
                {
                    indice = lista.IndexOf(item);

                }
            }
            return indice;

        }
    }
}
   

