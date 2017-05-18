using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bravo.Models.DatabaseEntities
{
    public class Rechtevorlage
    {
        [Required]
        public long Id { get; set; }
        public string Bezeichnung { get; set; }
        public bool Lesen { get; set; }
        public bool Bearbeiten { get; set; }
        public bool Erstellen { get; set; }
        public bool Entfernen { get; set; }
    }
}
