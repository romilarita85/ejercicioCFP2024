namespace Ejercicio_6
//Una empresa que se dedica a la comercialización de lámparas de bajo consumo, registra de sus ventas, los siguientes datos: marca y cantidad. El precio de cada lamparita es de $150 (Sin importar la marca).
//El programa deberá calcular el precio total de la venta, aplicando un descuento si es que corresponde.
//A.Si compra 6 lamparitas o más, tiene un descuento del 50%.
//B.Si compra 5 lamparitas marca “ArgentinaLuz” se aplica un 40% y si es de otra marca, el descuento es del 30%.
//C.Si compra 4 lamparitas marca “ArgentinaLuz” o “FelipeLamparas” se hace un descuento del 25%, y si es de otra marca el descuento es del 20%.
//D.Si compra 3 lamparitas marca “ArgentinaLuz” el descuento es del 15%, si es “FelipeLamparas se hace un descuento del 10% y si es otra marca, 5%.
//E.Si el importe final con descuento suma más de $950, se debe agregar el 10% de ingresos brutos.
//Informar: cantidad de lamparitas, marca, total sin descuento, descuento, total con descuento, y si corresponde total de ingresos brutos y total a pagar.

{
    internal class Program
    {
        static void Main(string[] args)
        {
            String marcaLamparas = "";
            int cantidadLamparas = 0;
            int precio = 150;
            decimal descuento = 0;
            decimal valorDescuento = 0;
            decimal precioTotal = 0;
            decimal precioTotalConDesc = 0;
            decimal iibb = 0,10;
            decimal valoriibb = 0;
            decimal precioTotalConIIBB = 0;
            

            Console.WriteLine("Ingrese la marca de la lamparita: ");
            marcaLamparas = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de las lamparitas");
            cantidadLamparas = Console.Read();

            precioTotal = cantidadLamparas * precio;
            //A.Si compra 6 lamparitas o más, tiene un descuento del 50 %.
            if (cantidadLamparas > 5)
            {
                descuento = 0,5;
            }
            else
            {//B.Si compra 5 lamparitas marca “ArgentinaLuz” se aplica un 40%
             //y si es de otra marca, el descuento es del 30%.
                if (cantidadLamparas == 5)
                {
                    if (marcaLamparas == "argentinaluz")
                    {
                        descuento = 0,4;
                    }
                    else 
                    {
                        descuento = 0,30;
                    }
                }
                else
                {//C.Si compra 4 lamparitas marca “ArgentinaLuz” o “FelipeLamparas”
                 //se hace un descuento del 25%,y si es de otra marca el descuento es del 20%.
                    if (cantidadLamparas == 4)
                    {
                        if (marcaLamparas == "argentinaluz" || marcaLamparas == "felipelamparas")
                        {
                            descuento = 0,25;
                        }
                        else
                        {
                            descuento = 0,20;
                        }
                    }
                    else
                    {//D.Si compra 3 lamparitas marca “ArgentinaLuz”
                     //el descuento es del 15%, si es “FelipeLamparas
                     //se hace un descuento del 10% y si es otra marca, 5%.
                        if (cantidadLamparas == 3)
                        {
                            if (marcaLamparas == "argentinaluz")
                            {
                                descuento = 0,15;
                            }
                            else
                            {
                                if (marcaLamparas == "felipelamparas")
                                {
                                    descuento = 0,10;
                                }
                                else
                                {
                                    descuento = 0,05;
                                }
                            }
                        }
                        else 
                        {
                            
                        }
                    }
                }
            }
            Console.WriteLine("La cantidad de lamparitas es " + cantidadLamparas);
            Console.WriteLine("La marca de lamparitas es " + marcaLamparas);
            Console.WriteLine("El total sin descuento es " + precioTotal);
            //E.Si el importe final con descuento suma más de $950,
            //se debe agregar el 10% de ingresos brutos.
            if(descuento != 0) 
            {
                valorDescuento = precioTotal * descuento;
                precioTotalConDesc = precioTotal - valorDescuento; 
                Console.WriteLine("El  descuento es " + valorDescuento);
                Console.WriteLine("El precio total con descuento es $", precioTotalConDesc);
            }
            if (precioTotalConDesc > 950)
            {
                valoriibb = precioTotalConDesc * iibb;
                precioTotalConIIBB = precioTotalConDesc + valoriibb;


            }
            Console.WriteLine("El total de ingresos brutos es " + valoriibb);
            Console.WriteLine("El total a pagar con ingresos brutos es" + precioTotalConIIBB);



        }
    }
}


/////Informar: cantidad de lamparitas, marca, total sin descuento, descuento, total con descuento, y si corresponde total de ingresos brutos y total a pagar.
