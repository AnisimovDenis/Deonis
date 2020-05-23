using Deonis_lib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deonis_lib.Services.Interfaces
{
    public interface IUserStore
    {
        IEnumerable<User> Get();

        void Edit(int id, User user);

        void SaveChanges();
    }
}
