using System;

namespace SingletonPattern
{
    public sealed class Singleton
    {
        private static int counter = 0;
        //public static readonly Object obj = new object();
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());
        public static Singleton GetInstance
        {
            get
            {           
                return instance.Value;
            }
        }

        private Singleton()
        {
            counter = counter + 1;
            Console.WriteLine(counter.ToString());
        }

        public void Logging(string message)
        {
            Console.WriteLine(message);
        }

    }

    
}
