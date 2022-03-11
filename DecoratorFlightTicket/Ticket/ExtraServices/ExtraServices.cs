using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorFlightTicket.Ticket.PlusServices
{
    public abstract class ExtraServices: ISeat
    {
        private ISeat ticket;

        protected string _description = "undefined extra services";
        protected double _price = 0.0;

        public ExtraServices(ISeat ticket)
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
