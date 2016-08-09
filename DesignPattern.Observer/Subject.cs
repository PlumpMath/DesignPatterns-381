using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPattern.Observer
{
    public class Subject
    {
        private readonly List<IObserver> observers = new List<IObserver>();

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnRegisterObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Execute()
        {
            Console.WriteLine("Subject : doing something...");
            Thread.Sleep(5000); //doing somthing
            NotifyObservers();

            Console.WriteLine("Subject : doing something...");
            Thread.Sleep(3000); //doing somthing
            NotifyObservers();
        }

        private void NotifyObservers()
        {
            Console.WriteLine("Subject : Notifying all observers");
            foreach (IObserver observer in observers)
            {
                observer.Notify();
            }
        }
    }
}
