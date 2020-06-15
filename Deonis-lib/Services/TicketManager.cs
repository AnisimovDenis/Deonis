using Deonis_lib.Entities;
using Deonis_lib.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deonis_lib.Services
{
    public class TicketManager : ITicketManager
    {
        ITicketStore store;

        public TicketManager(ITicketStore store)
        {
            this.store = store;
        }

        public void Add(Ticket newObj)
        {
            throw new NotImplementedException();
        }

        public void Edit(Ticket obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ticket> GetAll()
        {
            return store.GetAll();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
