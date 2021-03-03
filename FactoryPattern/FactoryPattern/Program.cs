using System;

namespace FactoryPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            string a = string.Empty;
            Console.WriteLine("PLease enter your ticket Type");
            a = Console.ReadLine();
            TicketFactoryClass ticketFactoryClass = new TicketFactoryClass();
            ITicketInterface ticketInterface = ticketFactoryClass.TicketInterface(a);
            Console.WriteLine(ticketInterface.AvailableSeats());
            Console.WriteLine(ticketInterface.PremiumServices());
            Console.WriteLine(ticketInterface.TicketPrice());
            Console.ReadLine();
        }
    }
}
