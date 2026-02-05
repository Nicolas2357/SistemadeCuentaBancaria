using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeCuentaBancaria
{
    public class CuentaCorriente : CuentaBancaria
    {
        private double _limiteSobregiro;

        public CuentaCorriente(int numeroCuenta, Cliente cliente, double limiteSobregiro)
            : base(numeroCuenta, cliente)
        {
            _limiteSobregiro = limiteSobregiro;
        }

        public override void Retirar(double monto)
        {
            if (monto > 0 )
                _saldo -= monto;
        }
    }
}
