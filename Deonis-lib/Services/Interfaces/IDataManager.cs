using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deonis_lib.Services.Interfaces
{
    public interface IDataManager<T>
    {
        IEnumerable<T> GetAll();

        void Add(T newObj);

        void Edit(T obj);

        void SaveChanges();
    }
}
