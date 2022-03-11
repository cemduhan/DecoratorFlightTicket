using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorFlightTicket.Ticket.PlusServices
{
    public class BiggerSeat:ExtraServices
    {
        public BiggerSeat(ISeat ticket)
        : base(ticket)
        {
            _description = "Bigger Seat";
            _price = 77;
        }
    }
}
