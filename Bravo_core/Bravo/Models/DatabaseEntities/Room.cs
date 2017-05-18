using Bravo.Models.DatabaseEntities.Abstract;
using Bravo.Models.DatabaseEntities.Relation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bravo.Models.DatabaseEntities
{
    public interface IRoom : IEntity, IName
    {
        string Notiz { get; set; }
        ICollection<ITool> Tools { get; }
        ICollection<RoomToolRelation> RoomToolRelations { get; set; }
    }

    public class Room : IRoom
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Notiz { get; set; }
        public ICollection<RoomToolRelation> RoomToolRelations { get; set; }
        public ICollection<Software_in_Raum> Software_in_Raum { get; set; }
        public ICollection<Geraet> Geraete { get; set; }

        [NotMapped]
        public ICollection<ITool> Tools { get { return this.RoomToolRelations?.Select(s => s.Tool).ToList<ITool>(); } }
    }
}
