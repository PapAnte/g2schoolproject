using Bravo.Models.DatabaseEntities.Relation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bravo.Models.DatabaseEntities
{
    public interface IGeraetekomponente
    {
        ICollection<IGeraet> Geraete { get; }
    }

    public class Geraetekomponente : IGeraetekomponente
    {
        [Required]
        public long Id { get; set; }
        public string Bezeichnung { get; set; }
        public ICollection<Geraeteart_Komponenten_Vorgabe> Geraeteart_Komponenten_Vorgabe { get; set; }
        public ICollection<Geraetekomponente_Information> Geraetekomponente_Information { get; set; }

        [NotMapped]
        public ICollection<IGeraet> Geraete { get { return this.Geraetekomponente_Information?.Select(s => s.Geraet).ToList<IGeraet>(); } }
    }
}