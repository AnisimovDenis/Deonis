using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deonis_lib.Entities.Base
{
    /// <summary> Базовая сущность </summary>
    public abstract class BaseEntity
    {
        /// <summary> Идентификатор </summary>
        public int Id { get; set; }
    }
}
