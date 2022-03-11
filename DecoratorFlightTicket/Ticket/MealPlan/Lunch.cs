using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorFlightTicket.Ticket.MealPlan
{
    public class Lunch: MealPlan
    {
        public Lunch(ISeat ticket)
        : base(ticket)
        {
            _description = "Lunch Service";
            _price = 25;
        }
    }
}
