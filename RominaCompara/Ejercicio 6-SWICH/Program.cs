//Ejercicio 6:
//Una empresa que se dedica a la comercialización de lámparas de bajo consumo, registra de sus ventas, los siguientes datos: marca y cantidad. El precio de cada lamparita es de $150 (Sin importar la marca).
//El programa deberá calcular el precio total de la venta, aplicando un descuento si es que corresponde.
//A.Si compra 6 lamparitas o más, tiene un descuento del 50%.
//B.Si compra 5 lamparitas marca “ArgentinaLuz” se aplica un 40% y si es de otra marca, el descuento es del 30%.
//C.Si compra 4 lamparitas marca “ArgentinaLuz” o “FelipeLamparas” se hace un descuento del 25%, y si es de otra marca el descuento es del 20%.
//D.Si compra 3 lamparitas marca “ArgentinaLuz” el descuento es del 15%, si es “FelipeLamparas se hace un descuento del 10% y si es otra marca, 5%.
//E.Si el importe final con descuento suma más de $950, se debe agregar el 10% de ingresos brutos.
//Informar: cantidad de lamparitas, marca, total sin descuento, descuento, total con descuento, y si corresponde total de ingresos brutos y total a pagar.
namespace Ejercicio_6_SWICH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String marcaLamparas = "";
            int cantidadLamparas = 0;
            int precio = 150;
            double descuento = 0;
            double valorDescuento = 0;
            double precioTotal;
            double precioTotalConDesc= 0;
            double iibb = 0.10;
            double valoriibb = 0;
            double precioTotalConIIBB=0 ;

            Console.WriteLine("Ingrese la marca de la lamparita: ");
            marcaLamparas = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de las lamparitas");
            cantidadLamparas = Console.Read();

            precioTotal = cantidadLamparas * precio;

            switch (cantidadLamparas) 
            {
                case 3:
                    switch (marcaLamparas)
                    {
                      case "argentinaluz":
                          descuento = 0.15;
                          break;
                      case "felipelamparas":
                          descuento = 0.10;
                          break;
                      default:
                          descuento = 0.05;
                          break;
                    }
                case 4:
                    switch (marcaLamparas) 
                    {
                       case "argentinaluz" || "felipelampara":
                          descuento = 0.25;
                          break;
                       default:
                          descuento = 0.20;
                          break;
                    }
                case 5:
                    switch (marcaLamparas) 
                    {
                        case "argentinaluz":
                           descuento = 0.4;
                           break;
                        default:
                           descuento= 0.3;
                           break;
                    }
                default:
                    if (cantidadLamparas >= 6) 
                    {
                        descuento = 0.5;
                        break;
                    }
            }
            if (descuento != 0)
            {
                valorDescuento = precioTotal * descuento;
                precioTotalConDesc = precioTotal - valorDescuento;
                Console.WriteLine("El  descuento es " + valorDescuento);
                Console.WriteLine("El precio total con descuento es $", precioTotalConDesc);
            }
            if (precioTotalConDesc > 950)
            //E.Si el importe final con descuento suma más de $950,
            //se debe agregar el 10% de ingresos brutos.
            {
                valoriibb = precioTotalConDesc * iibb;
                precioTotalConIIBB = precioTotalConDesc + valoriibb;
            }
            Console.WriteLine("El total de ingresos brutos es " + valoriibb);
            Console.WriteLine("El total a pagar con ingresos brutos es" + precioTotalConIIBB);
            Console.WriteLine("La cantidad de lamparitas es " + cantidadLamparas);
            Console.WriteLine("La marca de lamparitas es " + marcaLamparas);
            Console.WriteLine("El total sin descuento es " + precioTotal);
        }
    }
}
