using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace FactoryPattern
{
    class TicketFactoryClass
    {
        public ITicketInterface TicketInterface(string ticketType)
        {
            if (ticketType == "Silver")
            {
                return new Silver();
            }
            else if (ticketType == "Golg")
            {
                return new Gold();
            }
            else if (ticketType == "Platinum")
            {
                return new Platinum();
            }
            return null;
        }
    }
}
