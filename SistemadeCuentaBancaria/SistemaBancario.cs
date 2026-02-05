using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeCuentaBancaria
{
    public class SistemaBancario
    {
        private List<Cliente> _clientes;
        private List<CuentaBancaria> _cuentas;

        public SistemaBancario()
        {
            _clientes = new List<Cliente>();
            _cuentas = new List<CuentaBancaria>();
        }

        public void AgregarCliente(string nombre, string telefono, string direccion)
        {
            int id = _clientes.Count + 1;
            _clientes.Add(new Cliente(id, nombre, telefono, direccion));
        }

        public void CrearCuentaAhorro(int idCliente, double tasaInteres)
        {
            Cliente? cliente = _clientes.Find(c => c.Id == idCliente);
            if (cliente != null)
            {
                _cuentas.Add(new CuentaAhorro(_cuentas.Count + 1, cliente, tasaInteres));
            }
            else
            {
                Console.WriteLine("Cliente no encontrado.");
            }
        }

        public void CrearCuentaCorriente(int idCliente, double limiteSobregiro)
        {
            Cliente? cliente = _clientes.Find(c => c.Id == idCliente);
            if (cliente != null)
            {
                _cuentas.Add(new CuentaCorriente(_cuentas.Count + 1, cliente, limiteSobregiro));
            }
            else
            {
                Console.WriteLine("Cliente no encontrado.");
            }
        }

        public CuentaBancaria? BuscarCuenta(int numeroCuenta)
        {
            return _cuentas.Find(c => c.NumeroCuenta == numeroCuenta);
        }

        public void ListarCuentas()
        {
            foreach (CuentaBancaria cuenta in _cuentas)
            {
                Console.WriteLine($"Cuenta #{cuenta.NumeroCuenta} | Cliente: {cuenta.Cliente.Nombre} | Saldo: ${cuenta.ConsultarSaldo()}");
            }
        }
    }
}
