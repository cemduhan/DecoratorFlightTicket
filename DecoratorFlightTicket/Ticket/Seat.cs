using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorFlightTicket.Ticket
{
    public interface ISeat
    {

        string getDescription();
        double cost();
    }
}
