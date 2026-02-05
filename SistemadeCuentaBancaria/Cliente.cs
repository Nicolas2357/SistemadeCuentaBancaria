//.
namespace SistemadeCuentaBancaria
{
    public class Cliente : Persona
    {
        private string _direccion;

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public Cliente(int id, string nombre, string telefono, string direccion)
            : base(id, nombre, telefono)
        {
            _direccion = direccion;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Cliente: {Nombre} | Tel: {Telefono} | Dirección: {_direccion}");
        }
    }
}
