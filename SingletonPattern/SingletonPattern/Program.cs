using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => FirstCall(),
                () => SecondCall()
                );
        }

            private static void FirstCall()
            {
                Singleton ton = Singleton.GetInstance;
                ton.Logging("I am doing logging");
            }
            
            private static void SecondCall()
            {
                Singleton ton1 = Singleton.GetInstance;
                ton1.Logging("I am doing logging again");
            }
           

            //Singleton.Inheritance heritance = new Singleton.Inheritance();
            //heritance.Logging("Calling Inherited class");

        
    }
}
