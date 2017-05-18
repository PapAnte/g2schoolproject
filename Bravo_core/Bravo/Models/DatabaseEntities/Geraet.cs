using Bravo.Models.DatabaseEntities.Relation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bravo.Models.DatabaseEntities
{
    public interface IGeraet
    {
        ICollection<IGeraetekomponente> Geraetekomponenten { get; }
    }

    public class Geraet : IGeraet
    {
        public long Id { get; set; }
        public string Bezeichnung { get; set; }
        public int Gewaehrleistung_Monate { get; set; }
        public DateTime Einkaufsdatum { get; set; }
        public byte[] Einkaufsbeleg { get; set; }
        public string Notiz { get; set; }

        public ICollection<Geraetekomponente_Information> Geraetekomponente_Information { get; set; }

        [NotMapped]
        public ICollection<IGeraetekomponente> Geraetekomponenten { get { return this.Geraetekomponente_Information?.Select(s => s.Geraetekomponente).ToList<IGeraetekomponente>(); } }
    }
}
