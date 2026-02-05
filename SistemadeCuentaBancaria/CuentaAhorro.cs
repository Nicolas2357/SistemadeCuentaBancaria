//.

namespace SistemadeCuentaBancaria
{
    public class CuentaAhorro : CuentaBancaria
    {
        private double _tasaInteres;

        public CuentaAhorro(int numeroCuenta, Cliente cliente, double tasaInteres)
            : base(numeroCuenta, cliente)
        {
            _tasaInteres = tasaInteres;
        }

        public override void Retirar(double monto)
        {
            if (monto > 0 && monto <= _saldo)
                _saldo -= monto;
            else
                Console.WriteLine("Fondos insuficientes.");
        }

        public void AplicarInteres()
        {
            _saldo += _saldo * _tasaInteres;
        }
    }
}
