using Deonis_lib.Entities;
using Deonis_lib.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deonis_lib.Services
{
    public class EmployeeManager : IEmployeeManager
    {
        IEmployeeStore store;

        public EmployeeManager(IEmployeeStore store)
        {
            this.store = store;
        }

        public void Add(Employee newObj)
        {
            throw new NotImplementedException();
        }

        public void Edit(Employee obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            return store.GetAll();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
