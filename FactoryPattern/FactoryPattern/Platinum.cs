using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Platinum:ITicketInterface
    {
        public int AvailableSeats()
        {
            return 10;
        }

        public int TicketPrice()
        {
            return 350;
        }

        public string PremiumServices()
        {
            return "Food with beverage";
        }
    }
}
