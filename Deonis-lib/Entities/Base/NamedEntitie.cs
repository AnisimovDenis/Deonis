using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deonis_lib.Entities.Base
{
    public abstract class NamedEntitie : Entitie
    {
        public string Name { get; set; }
    }
}
