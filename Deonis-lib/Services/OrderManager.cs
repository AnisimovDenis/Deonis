using Deonis_lib.Entities;
using Deonis_lib.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deonis_lib.Services
{
    public class OrderManager : IOrderManager
    {
        IOrderStore store;

        public OrderManager(IOrderStore store)
        {
            this.store = store;
        }

        public void Add(Order newObj)
        {
            throw new NotImplementedException();
        }

        public void Edit(Order obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAll()
        {
            return this.store.GetAll();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
