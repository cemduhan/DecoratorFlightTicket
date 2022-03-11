using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorFlightTicket.Ticket.MealPlan
{
    public abstract class MealPlan: ISeat
    {
        private ISeat ticket;

        protected string _description = "undefined meal plan";
        protected double _price = 0.0;

        public MealPlan(ISeat ticket)
        {
            this.ticket = ticket;
        }

        public string getDescription()
        {
            return string.Format("{0}, {1}", ticket.getDescription(), _description);
        }

        public double cost()
        {
            return this.ticket.cost() + _price;
        }
    }
}
