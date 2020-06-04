using Deonis_lib.Entities;
using Deonis_lib.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deonis_lib.Services
{
    public class UserManager : IUserManager
    {
        IUserStore store;

        public UserManager(IUserStore store)
        {
            this.store = store;
        }

        public IEnumerable<User> GetAll()
        {
            return store.GetAll();
        }

        public void Add(User newUser)
        {
            
        }

        public void Edit(User user)
        {
            store.Edit(user.Id, user);
        }

        public void SaveChanges()
        {
            store.SaveChanges();
        }
    }
}
