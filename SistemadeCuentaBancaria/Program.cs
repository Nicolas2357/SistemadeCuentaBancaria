using SistemadeCuentaBancaria;

class Program
{
    static void Main()
    {
        SistemaBancario banco = new SistemaBancario();
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n1. Agregar cliente");
            Console.WriteLine("2. Crear cuenta ahorro");
            Console.WriteLine("3. Crear cuenta corriente");
            Console.WriteLine("4. Listar cuentas");
            Console.WriteLine("5. Salir");
            Console.Write("Opción: ");

            string input = Console.ReadLine();
            int opcion;
            if (!int.TryParse(input, out opcion))
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    banco.AgregarCliente("Juan", "123456789", "Centro");
                    break;

                case 2:
                    banco.CrearCuentaAhorro(1, 0.05);
                    break;

                case 3:
                    banco.CrearCuentaCorriente(1, 1000);
                    break;

                case 4:
                    banco.ListarCuentas();
                    break;

                case 5:
                    salir = true;
                    break;
            }
        }
    }
}