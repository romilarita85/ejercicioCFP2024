using System.Drawing;
namespace Libreria_Autos
{
    public class Auto
    {
        //A.Los atributos marca, cantCombustible, color.
        private string marca;
        private int cantCombustible;
        Color color;
       
        //B. un constructor que inicialice todos los atributos.
        public Auto(string marca, int cantCombustible, Color color)
        {
            this.marca = marca;
            this.cantCombustible = cantCombustible;
            this.color = color;
        }
        //C. Solo metodos Get() para todos sus atributos.
        public string GetMarca() 
        {
            return this.marca;
        }
        public int GetCantCombustible() 
        {
            return this.cantCombustible;
        }
        public Color GetColor()
        {
            return this.color;
               
        }
        //D. El metodo AutoToString(), este metodo debe retornar un string con toda su informacion.
        public string AutoToString() 
        {
            return $"Marca: {marca} | Cantidad de combustible: {cantCombustible} | Color: {color.Name}";
        
        }
        //E. El metodo Avanzar(int km) que retornara un booleano para informar
        //si pudo recorrer o no la cantidad de kilometros recibo por parametro,
        //tener en cuenta que para poder avanzar se debe tener conbustible y
        //por cada litro de combustible se pueden 10km.
        public bool Avanzar(int km)
        {
            int kmPosibles = cantCombustible * 10; //10 km por cada litro de combustible 
            
            if (km <= kmPosibles) // km menores o iguales a kmPosibles
            {
                cantCombustible -= km / 10;
                return true;
            }
            else
            {
                return false;
            }
        }
        //bool true// km menores o iguales a kmPosibles
        //bool false// km son mayores a kmPosibles

    }
}
