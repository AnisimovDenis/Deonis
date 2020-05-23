using Deonis_lib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deonis_lib.Services.Interfaces
{
    public interface IUserManager
    {
        IEnumerable<User> GetAll();

        void Add(User newUser);

        void Edit(User user);

        void SaveChanges();
    }
}
