//.


namespace SistemadeCuentaBancaria
{
    public abstract class Persona
    {
        private int _id;
        private string _nombre;
        private string _telefono;

        public int Id
        {
            get { return _id; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        protected Persona(int id, string nombre, string telefono)
        {
            _id = id;
            _nombre = nombre;
            _telefono = telefono;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {_nombre} | Teléfono: {_telefono}");
        }
    }
}
