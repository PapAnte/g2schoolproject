using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bravo.Models.DatabaseEntities
{
    public class WebBenutzer
    {
        [Required]
        public long Id { get; set; }
        public string Nutzername { get; set; }
        public string Passwort { get; set; }
        public long Rechtegruppe_ID { get; set; }
        public string Name { get; set; }
        public string Anrede { get; set; }
        public string Titel { get; set; }
        public DateTime Geburtsdatum { get; set; }
        public string EMail { get; set; }
        public DateTime Erstellungsdatum { get; set; }
    }
}
