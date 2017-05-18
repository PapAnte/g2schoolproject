using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bravo.Models.ViewModels.Ticket
{
    public class TicketEditViewModel
    {
        public long Id { get; set; }
        public string Bezeichnung { get; set; }
        public string Notiz { get; set; }
        public string Ersteller { get; set; }
        public DateTime DatumEingang { get; set; }
        public string Bearbeiter { get; set; }
        public DateTime AbgeschlossenDatum { get; set; }
    }
}
