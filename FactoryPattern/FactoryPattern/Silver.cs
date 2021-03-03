using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Silver:ITicketInterface
    {
        public int AvailableSeats()
        {
            return 50;
        }

        public int TicketPrice()
        {
            return 250;
        }

        public string PremiumServices()
        {
            return string.Empty;
        }
    }
}
