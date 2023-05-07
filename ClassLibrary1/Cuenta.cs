using System.Linq.Expressions;

namespace ClassLibrary1
{
    public class Cuenta
    {
        public double saldo { get; set; }
        public string message { get; set; }

        public Cuenta(double saldo)
        {
            this.saldo = saldo;
            message = "";
        }
        public Cuenta()
        {
            saldo = 0;
            message = "";
        }

        public double debitarCuenta(double monto)
        {
            
            if ((saldo - monto)< 0){
                message = "Saldo insuficiente";
            }            
            return saldo -= monto;
        }

        public double abonarCuenta(double monto)
        {
            return saldo += monto;
        }
    }
}