using System;
using System.Collections.Generic;

namespace Comportamiento.Domain
{
    public class Subject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private string _state;

        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
                Notify();
            }
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_state);
            }
        }
    }
}
