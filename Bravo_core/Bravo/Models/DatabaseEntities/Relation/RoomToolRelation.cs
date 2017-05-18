using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bravo.Models.DatabaseEntities.Relation
{
    public class RoomToolRelation
    {
        public long RoomId { get; set; }
        public virtual Room Room { get; set; }

        public long ToolId { get; set; }
        public virtual Tool Tool { get; set; }
    }
}
