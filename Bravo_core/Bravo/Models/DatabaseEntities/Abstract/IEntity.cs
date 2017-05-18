using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bravo.Models.DatabaseEntities.Abstract
{
    public interface IEntity
    {
        long Id { get; set; }
    }
}
