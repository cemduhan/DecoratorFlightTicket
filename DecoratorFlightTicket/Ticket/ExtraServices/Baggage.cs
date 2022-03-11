using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorFlightTicket.Ticket.PlusServices
{
    public class Baggage:ExtraServices
    {
        public Baggage(ISeat ticket)
        : base(ticket)
        {
            _description = "Extra Baggage";
            _price = 50;
        }
    }
}
