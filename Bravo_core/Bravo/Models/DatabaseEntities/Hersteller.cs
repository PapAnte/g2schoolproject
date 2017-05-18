using Bravo.Models.DatabaseEntities.Abstract;
using Bravo.Models.DatabaseEntities.Relation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bravo.Models.DatabaseEntities
{
    public interface IHersteller
    {
        ICollection<IRoom> Rooms { get; }
    }

    public class Hersteller : IHersteller
    {
        public long Id { get; set; }
        public string Bezeichnung { get; set; }

        public ICollection<Geraet> Geraete { get; set; }
        public ICollection<Software> Softwares { get; set; }
        public ICollection<RoomToolRelation> RoomToolRelations { get; set; }

        [NotMapped]
        public ICollection<IRoom> Rooms { get { return this.RoomToolRelations?.Select(s => s.Room).ToList<IRoom>(); } }
    }
}
