using System;

namespace DesignPattern.Observer
{
    public class ObserverA : IObserver
    {
        #region IObserver Members

        public void Notify()
        {
            Console.WriteLine("Observer A : Thank you");
        }

        #endregion
    }
}
