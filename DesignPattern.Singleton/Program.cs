namespace DesignPattern.Singleton
{
    static class Program
    {
        static void Main(string[] args)
        {
            SingletonSample s1 = SingletonSample.Instance;
            SingletonSample s2 = SingletonSample.Instance;
            SingletonSample s3 = SingletonSample.Instance;

            s1.someString = "one";
            s1.Execute();

            s2.someString = "two";
            s1.Execute();

            s3.someString = "three";
            s2.Execute();
        }
    }
}
