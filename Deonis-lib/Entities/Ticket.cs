using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deonis_lib.Entities
{
    public class Ticket
    {
        public string Name { get; set; }

        public string Article { get; set; }

        public string TypeOfTicket { get; set; }

        public string TypeOfTransport { get; set; }

        public decimal PricePerTrip { get; set; }
    }
}
