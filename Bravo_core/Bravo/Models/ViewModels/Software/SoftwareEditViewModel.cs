using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bravo.Models.ViewModels.Software
{
    public class SoftwareEditViewModel
    {
        public long Id { get; set; }
        public string Bezeichnung { get; set; }
        public string Version { get; set; }
        public int Lizenz_Benutzerumfang { get; set; }
        public string lizenz_Schlüssel { get; set; }
        public DateTime Einkaufsdatum { get; set; }
        public byte[] Einkaufsbeleg { get; set; }
        public string Notiz { get; set; }
    }
}
