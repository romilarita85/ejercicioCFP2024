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
            String marca;
            int cantidad;
            double precio;
            double descuento = 0;
            float valorDescuento;
            float precioTotal;
            float precioTotalConDesc;
            double iibb = 0,10;
            float valoriibb;
            float precioTotalConIIBB;
            precio = 150;
          
            

            Console.WriteLine("Ingrese la marca de la lamparita: ");
            marca = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de las lamparitas");
            cantidad = Console.Read();

            precioTotal = cantidad * precio;

            if (cantidad == 6)
            {
                descuento = 0,5;
            }
            else
            {
                if (cantidad == 5)
                {
                    if (marca == "argentinaluz")
                    {
                        descuento = 0,4;
                    }
                    else
                    {
                        descuento = 0,30;
                    }
                }
                else
                {
                    if (cantidad == 4)
                    {
                        if (marca == "argentinaluz" && marca == "felipelamparas")
                        {
                            descuento = 0,25;
                        }
                        else
                        {
                            descuento = 0,20;

                        }
                    }
                    else
                    {
                        if (cantidad == 3)
                        {
                            if (marca == "argentinaluz")
                            {
                                descuento = 0,15;
                            }
                            else
                            {
                                if (marca == "felipelamparas")
                                {
                                    descuento = 0,10;
                                }
                                else
                                {
                                    descuento = 0,05;
                                }
                            }
                        }

                    }
                }
            }
            Console.WriteLine("La cantidad de lamparitas es " + cantidad);
            Console.WriteLine("La marca de lamparitas es " + marca);
            Console.WriteLine("El total sin descuento es " + precioTotal);

            if (descuento<> 0)
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
