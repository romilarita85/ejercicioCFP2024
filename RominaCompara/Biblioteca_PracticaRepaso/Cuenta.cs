namespace Biblioteca_PracticaRepaso
{
    public class Cuenta
    {
        string titular;
        double cantidad;

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public double getCantidad() 
        { 
            return cantidad;    
        }
        public string getTitular() 
        {
            return titular;
        }
        public string CuentaToString() 
        {
            return $"Titular {titular}| Cantidad {cantidad}";
        
        }
        //●	IngresarDinero: recibirá un monto para acreditar a la cuenta.
        //Si el monto ingresado es negativo, no se hará nada.
        public void IngresarDinero(double monto)
        {
            if (monto > 0)
            {
                cantidad += monto;
            }
        }

        //●	RetirarDinero: recibirá un monto para debitar de la cuenta.
        //La cuenta puede quedar en negativo.
        public void RetirarDinero(double monto)
        {
            cantidad -= monto;
        }
    }
}
