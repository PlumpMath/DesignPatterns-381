using System;

namespace DesignPattern.Singleton
{
    public class SingletonSample
    {
        private static readonly SingletonSample singletonInstance = new SingletonSample();
        public string someString;

        private SingletonSample()
        {
            //nothing
        }

        public static SingletonSample Instance
        {
            get
            {
                return singletonInstance;
            }
        }

        public void Execute()
        {
            Console.WriteLine(someString);
        }
    }
}
