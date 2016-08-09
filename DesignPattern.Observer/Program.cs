using System;

namespace DesignPattern.Observer
{
    static class Program
    {
        static void Main()
        {
            IObserver observerA = new ObserverA();
            IObserver observerB = new ObserverB();

            Subject subject = new Subject();
            Console.WriteLine("Caller : Registering ObserverA");
            subject.RegisterObserver(observerA);

            Console.WriteLine("Caller : Registering ObserverB");
            subject.RegisterObserver(observerB);

            Console.WriteLine("Caller : Execute Subject");
            subject.Execute();

            Console.WriteLine("Caller : Un-Registering ObserverA");
            subject.UnRegisterObserver(observerA);

            Console.WriteLine("Caller : Execute Subject Again");
            subject.Execute();
        }
    }
}
