using Deonis_lib.Entities;
using Deonis_lib.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deonis_lib.Services.InMemory
{
    public class OrderStoreInMemory : DataStoreInMemory<Order>, IOrderStore
    {
        public OrderStoreInMemory() : base(TestData.Data.orders) { }

        public override void Edit(int id, Order item)
        {
            throw new NotImplementedException();
        }
    }
}
