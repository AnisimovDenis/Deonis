using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deonis_lib.Entities
{
    public class Order
    {
        public string Article { get; set; }

        public string Ticket { get; set; }

        public int NumberOfTrips { get; set; }

        public string Employee { get; set; }

        public decimal Price { get; set; }
    }
}
