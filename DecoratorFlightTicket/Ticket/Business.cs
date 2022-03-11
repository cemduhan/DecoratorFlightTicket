using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorFlightTicket.Ticket
{
    public class Business : ISeat
    {
        protected string _description = "Business";
        protected double _price = 200;

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
