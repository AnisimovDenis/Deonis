using Deonis_lib.Entities;
using Deonis_lib.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deonis_lib.Services.InMemory
{
    public class UserStoreInMemory : DataStoreInMemory<User>, IUserStore
    {
        public UserStoreInMemory() : base(TestData.Data.users) { }

        public override void Edit(int id, User item)
        {
            throw new NotImplementedException();
        }
    }
}
