using System;

namespace DesignPattern.Observer
{
    public class ObserverB : IObserver
    {
        #region IObserver Members

        public void Notify()
        {
            Console.WriteLine("Observer B : Thank you");
        }

        #endregion
    }
}
