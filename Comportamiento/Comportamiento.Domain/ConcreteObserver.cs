namespace Comportamiento.Domain
{
    public class ConcreteObserver : IObserver
    {
        private string _name;
        private string _state;

        public string State => _state; // Esta propiedad te permitirá acceder al estado desde fuera de la clase.

        public ConcreteObserver(string name)
        {
            _name = name;
        }

        public void Update(string message)
        {
            _state = message;
            Console.WriteLine($"{_name} received update: {_state}");
        }
    }
}
