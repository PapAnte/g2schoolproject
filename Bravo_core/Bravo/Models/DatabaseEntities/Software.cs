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
    public interface ISoftware : IEntity
    {
        string Bezeichnung { get; set; }
        ICollection<IRoom> Rooms { get; }
        ICollection<Software_in_Raum> Software_in_Raum { get; set; }
    }

    public class Software : ISoftware
    {
        [Required]
        public long Id { get; set; }
        public string Bezeichnung { get; set; }
        public string Version { get; set; }
        public int Lizenz_Benutzerumfang { get; set; }
        public string lizenz_Schlüssel { get; set; }
        public DateTime Einkaufsdatum { get; set; }
        public byte[] Einkaufsbeleg { get; set; }
        public string Notiz { get; set; }

        [NotMapped]
        public ICollection<IRoom> Rooms { get { return this.Software_in_Raum.Select(s => s.Room).ToList<IRoom>(); } }     
        public ICollection<Software_in_Raum> Software_in_Raum { get; set; }
    }
}
