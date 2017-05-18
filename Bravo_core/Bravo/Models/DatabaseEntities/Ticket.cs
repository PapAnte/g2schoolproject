using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bravo.Models.DatabaseEntities
{
    public class Ticket
    {
        public long Id { get; set; }
        public string Bezeichnung { get; set; }
        public string Notiz { get; set; }
        public string Ersteller { get; set; }
        public DateTime DatumEingang { get; set; }
        public string Bearbeiter { get; set; }
        public DateTime AbgeschlossenDatum { get; set; }

        //public ICollection<ApplicationUser> ApplicationUser { get; set; }
    }
}
