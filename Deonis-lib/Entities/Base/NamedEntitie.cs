using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deonis_lib.Entities.Base
{
    /// <summary> Сущность с именем </summary>
    public abstract class NamedEntitie : BaseEntitie
    {
        /// <summary> Имя </summary>
        public string Name { get; set; }
    }
}
