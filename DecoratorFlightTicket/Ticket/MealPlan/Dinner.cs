using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorFlightTicket.Ticket.MealPlan
{
    public class Dinner: MealPlan
    {
        public Dinner(ISeat ticket)
        : base(ticket)
        {
            _description = "Dinner Service";
            _price = 35;
        }
    }
}
