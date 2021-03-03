using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Gold:ITicketInterface
    {
        public int AvailableSeats()
        {
            return 20;
        }

        public int TicketPrice()
        {
            return 300;
        }

        public string PremiumServices()
        {
            return "Food";
        }
    }
}
