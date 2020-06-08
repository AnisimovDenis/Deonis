using Deonis_lib.Entities;
using Deonis_lib.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deonis_lib.Services.InMemory
{
    public class TicketStoreInMemory : DataStoreInMemory<Ticket>, ITicketStore
    {
        public TicketStoreInMemory() : base(TestData.Data.tickets) { }

        public override void Edit(int id, Ticket item)
        {
            throw new NotImplementedException();
        }
    }
}
