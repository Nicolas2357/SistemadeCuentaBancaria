//.
using SistemadeCuentaBancaria;

class Program
{
    static void Main()
    {
        SistemaBancario sistema = new SistemaBancario();
        int opcion;
        bool salir = false;


        do
        {
            Console.Clear();
            Console.WriteLine("=== SISTEMA BANCARIO ===");
            Console.WriteLine("1. Agregar cliente");
            Console.WriteLine("2. Crear cuenta de ahorro");
            Console.WriteLine("3. Crear cuenta corriente");
            Console.WriteLine("4. Depositar");
            Console.WriteLine("5. Retirar");
            Console.WriteLine("6. Consultar saldo");
            Console.WriteLine("7. Listar cuentas");
            Console.WriteLine("8. Salir");
            Console.Write("Opción: ");

            opcion = int.Parse(Console.ReadLine());


            switch (opcion)
            {
                case 1:
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Teléfono: ");
                    string telefono = Console.ReadLine();

                    Console.Write("Dirección: ");
                    string direccion = Console.ReadLine();

                    sistema.AgregarCliente(nombre, telefono, direccion);
                    Console.WriteLine("Cliente agregado correctamente.");
                    Console.ReadLine();
                    break;

                case 2:
                    Console.Write("ID del cliente: ");
                    int idAhorro = int.Parse(Console.ReadLine());

                    Console.Write("Tasa de interés: ");
                    double tasa = double.Parse(Console.ReadLine());

                    sistema.CrearCuentaAhorro(idAhorro, tasa);
                    Console.ReadLine();
                    break;

                case 3:
                    Console.Write("ID del cliente: ");
                    int idCorriente = int.Parse(Console.ReadLine());

                    Console.Write("Límite de sobregiro: ");
                    double limite = double.Parse(Console.ReadLine());

                    sistema.CrearCuentaCorriente(idCorriente, limite);
                    Console.ReadLine();
                    break;

                case 4:
                    Console.Write("Número de cuenta: ");
                    int cuentaDep = int.Parse(Console.ReadLine());

                    CuentaBancaria? cuentaDeposito = sistema.BuscarCuenta(cuentaDep);
                    if (cuentaDeposito != null)
                    {
                        Console.Write("Monto a depositar: ");
                        double monto = double.Parse(Console.ReadLine());
                        cuentaDeposito.Depositar(monto);
                    }
                    else
                        Console.WriteLine("Cuenta no encontrada.");

                    Console.ReadLine();
                    break;

                case 5:
                    Console.Write("Número de cuenta: ");
                    int cuentaRet = int.Parse(Console.ReadLine());

                    CuentaBancaria? cuentaRetiro = sistema.BuscarCuenta(cuentaRet);
                    if (cuentaRetiro != null)
                    {
                        Console.Write("Monto a retirar: ");
                        double monto = double.Parse(Console.ReadLine());
                        cuentaRetiro.Retirar(monto);
                    }
                    else
                        Console.WriteLine("Cuenta no encontrada.");

                    Console.ReadLine();
                    break;

                case 6:
                    Console.Write("Número de cuenta: ");
                    int cuentaSaldo = int.Parse(Console.ReadLine());

                    CuentaBancaria? cuentaConsulta = sistema.BuscarCuenta(cuentaSaldo);
                    if (cuentaConsulta != null)
                        Console.WriteLine($"Saldo actual: ${cuentaConsulta.ConsultarSaldo()}");
                    else
                        Console.WriteLine("Cuenta no encontrada.");

                    Console.ReadLine();
                    break;

                case 7:
                    sistema.ListarCuentas();
                    Console.ReadLine();
                    break;

                case 8:
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    Console.ReadLine();
                    break;
            }
        } while (opcion !=0);
    }
}
