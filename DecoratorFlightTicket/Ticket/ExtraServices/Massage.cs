using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorFlightTicket.Ticket.PlusServices
{
    public class Massage: ExtraServices
    {
        public Massage(ISeat ticket)
        : base(ticket)
        {
            _description = "Massage Service";
            _price = 55;
        }
    }
}
