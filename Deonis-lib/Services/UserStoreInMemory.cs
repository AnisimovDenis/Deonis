using Deonis_lib.Entities;
using Deonis_lib.Services.Interfaces;
using Deonis_lib.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deonis_lib.Services
{
    public class UserStoreInMemory : IUserStore
    {
        public IEnumerable<User> Get() => Data.users;

        public void Edit(int id, User user)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
