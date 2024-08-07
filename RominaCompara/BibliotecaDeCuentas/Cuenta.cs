namespace BibliotecaDeCuentas
{
    public class Cuenta
    {
        //Atributos:
        //●	titular: que contendrá la razón social del titular de la cuenta.
        //●	cantidad:  que será un número decimal que representa al monto actual de dinero
        //en la cuenta.
        private string titular;
        private double cantidad;
        //Constructor:
        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        //●	Un método getter para cada atributo.
        public string GetTitular()
        {
            return titular;
        }
        public double GetCantidad()
        {
            return cantidad;
        }
        //Comportamientos:
        //●	CuentaToString: retornará una cadena de texto con todos los datos de la cuenta.
        public string CuentaToString()
        {
            return $"Titular: {titular} |Saldo Actual: ${cantidad}";

        }
        //●	IngresarDinero: recibirá un monto para acreditar a la cuenta.
        //Si el monto ingresado es negativo, no se hará nada.
        public void IngresarDinero(double monto)
        {
            if (monto > 0)
            {
                cantidad += monto;
                //cantidad = cantidad + monto;
            }
        }
        //●	RetirarDinero: recibirá un monto para debitar de la cuenta.
        //La cuenta puede quedar en negativo.
        public void RetirarDinero(double monto)
        {
            cantidad -= monto;
            //cantidad = cantidad - monto;
        }
        
    }
}
