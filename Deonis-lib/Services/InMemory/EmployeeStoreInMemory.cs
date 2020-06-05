using Deonis_lib.Entities;
using Deonis_lib.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deonis_lib.Services.InMemory
{
    public class EmployeeStoreInMemory : DataStoreInMemory<Employee>, IEmployeeStore
    {
        public EmployeeStoreInMemory() : base(TestData.Data.employees) { }

        public override void Edit(int id, Employee item)
        {
            throw new NotImplementedException();
        }
    }
}
