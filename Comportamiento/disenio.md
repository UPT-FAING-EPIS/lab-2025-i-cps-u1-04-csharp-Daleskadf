```mermaid
classDiagram
    ISubject : +Attach(observer)
    ISubject : +Detach(observer)
    ISubject : +Notify()
    
    IObserver : +Update(message)
    
    Subject : -observers : List
    Subject : -state : string
    Subject : +Attach(observer)
    Subject : +Detach(observer)
    Subject : +Notify()
    Subject : +State

    ConcreteObserver : -name : string
    ConcreteObserver : -state : string
    ConcreteObserver : +Update(message)

    ISubject <|-- Subject
    IObserver <|-- ConcreteObserver
    Subject "1" -- "*" IObserver : "Notifica a"
    ConcreteObserver "1" -- "1" Subject : "Recibe notificación de"

```