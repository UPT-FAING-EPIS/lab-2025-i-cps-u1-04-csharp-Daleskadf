using NUnit.Framework;
using Comportamiento.Domain;

namespace Comportamiento.Domain.Tests
{
    public class ObserverTests
    {
        [Test]
        public void TestObserverPattern()
        {
            // Crear un Subject
            var subject = new Subject();

            // Crear dos Observers
            var observer1 = new ConcreteObserver("Observer 1");
            var observer2 = new ConcreteObserver("Observer 2");

            // Attach los Observers al Subject
            subject.Attach(observer1);
            subject.Attach(observer2);

            // Cambiar el estado del Subject
            subject.State = "State 1";

            // Verificar que los Observers recibieron el mensaje
            Assert.AreEqual("State 1", observer1.State);
            Assert.AreEqual("State 1", observer2.State);
        }
    }
}
