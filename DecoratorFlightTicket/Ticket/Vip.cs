using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorFlightTicket.Ticket
{
    public class Vip : ISeat
    {
        protected string _description = "VIP Seat";
        protected double _price = 500;

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
