namespace HolaMundo;

public class CuentaBancaria
{
    
        private string titular;
        private decimal saldo;

        public CuentaBancaria(string titular, decimal saldoInicial)
        {
            this.titular = titular;
            this.saldo = saldoInicial;
        }

        public void Depositar(decimal cantidad)
        {
            if (cantidad > 0)
            {
                saldo += cantidad;
            }
        }

        public bool Retirar(decimal cantidad)
        {
            if (cantidad > 0 && cantidad <= saldo)
            {
                saldo -= cantidad;
                return true;
            }
            return false;
        }

        public decimal ObtenerSaldo()
        {
            return saldo;
        }

        public string ObtenerTitular()
        {
            return titular;
        }

}