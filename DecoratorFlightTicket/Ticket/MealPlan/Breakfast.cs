using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorFlightTicket.Ticket.MealPlan
{
    public class Breakfast: MealPlan
    {
        public Breakfast(ISeat ticket)
        : base(ticket)
        {
            _description = "Breakfast Service";
            _price = 17;
        }
    }
}
