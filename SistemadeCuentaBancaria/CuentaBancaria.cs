//.
namespace SistemadeCuentaBancaria
{
    public abstract class CuentaBancaria
    {
        private int _numeroCuenta;
        protected double _saldo;
        private Cliente _cliente;

        public int NumeroCuenta
        {
            get { return _numeroCuenta; }
        }

        public Cliente Cliente
        {
            get { return _cliente; }
        }

        protected CuentaBancaria(int numeroCuenta, Cliente cliente)
        {
            _numeroCuenta = numeroCuenta;
            _cliente = cliente;
            _saldo = 0;
        }

        public void Depositar(double monto)
        {
            if (monto > 0)
                _saldo += monto;
            else
                Console.WriteLine("Monto inválido.");
        }

        public abstract void Retirar(double monto);

        public double ConsultarSaldo()
        {
            return _saldo;
        }
    }
}
