using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    interface ITicketInterface
    {
        int TicketPrice();
        string PremiumServices();
        int AvailableSeats();
    }
}
