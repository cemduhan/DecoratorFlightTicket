using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorFlightTicket.Ticket
{
    public class Economy: ISeat
    {
        protected string _description = "Economy seat";
        protected double _price = 100;

        public string getDescription()
        {
            return string.Format("{0}", _description);
        }

        public double cost()
        {
            return this._price;
        }
    }
}
