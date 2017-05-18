using Bravo.Models.DatabaseEntities.Abstract;
using Bravo.Models.DatabaseEntities.Relation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bravo.Models.DatabaseEntities
{
    public interface ITool : IEntity, IName
    {
        ICollection<IRoom> Rooms { get; }
    }

    public class Tool : ITool
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public ICollection<RoomToolRelation> RoomToolRelations { get; set; }

        [NotMapped]
        public ICollection<IRoom> Rooms { get { return this.RoomToolRelations?.Select(s => s.Room).ToList<IRoom>(); } }
    }
}
