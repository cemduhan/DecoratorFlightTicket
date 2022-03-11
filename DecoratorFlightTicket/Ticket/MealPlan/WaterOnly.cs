using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorFlightTicket.Ticket.MealPlan
{
    public class WaterOnly: MealPlan
    {
        public WaterOnly(ISeat ticket)
        : base(ticket)
        {
            _description = "Water Only";
            _price = 5;
        }
    }
}
