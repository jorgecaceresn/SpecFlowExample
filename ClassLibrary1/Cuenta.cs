using System.Linq.Expressions;

namespace ClassLibrary1
{
    public class Cuenta
    {
        public double saldo { get; set; }
        public string debitoMessage { get; set; }

        public string saldoMessage { get; set; }

        public Cuenta(double saldo)
        {
            this.saldo = saldo;
            debitoMessage = "";
            if(saldo < 0)
            {
                saldoMessage = "La cuenta no puede tener saldo negativo";
            }
            else
            {
                saldoMessage = "";
            }
        }
        public Cuenta()
        {
            saldo = 0;
            debitoMessage = "";
            saldoMessage = "";
        }

        public double debitarCuenta(double monto)
        {
            
            if ((saldo - monto)< 0){
                debitoMessage = "Saldo insuficiente";
            }            
            return saldo -= monto;
        }

        public double abonarCuenta(double monto)
        {
            return saldo += monto;
        }
    }
}