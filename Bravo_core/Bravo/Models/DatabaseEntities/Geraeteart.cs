using Bravo.Models.DatabaseEntities.Relation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bravo.Models.DatabaseEntities
{
    public interface IGeraeteart
    {
        ICollection<IGeraetekomponente> Geraetekomponente { get; }
    }
    
    public class Geraeteart : IGeraeteart
    {
        [Required]
        public long Id { get; set; }
        public string Bezeichnung { get; set; }
        public ICollection<Geraeteart_Komponenten_Vorgabe> Geraeteart_Komponenten_Vorgabe { get; set; }
        public ICollection<Geraet> Geraete { get; set; }

        [NotMapped]
        public ICollection<IGeraetekomponente> Geraetekomponente { get { return this.Geraeteart_Komponenten_Vorgabe?.Select(s => s.Geraetekomponente).ToList<IGeraetekomponente>(); } }
    }
}
