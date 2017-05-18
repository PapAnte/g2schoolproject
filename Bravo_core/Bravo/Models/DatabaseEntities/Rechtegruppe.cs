using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bravo.Models.DatabaseEntities
{
    public class Rechtegruppe
    {
        [Required]
        public long Id { get; set; }
        public string Bezeichnung { get; set; }
        public bool Benutzerverwaltung_Vollzugriff { get; set; }
        public long Tickets_VorlageID { get; set; }
        public long Ausstattung_VorlageID { get; set; }
    }
}
