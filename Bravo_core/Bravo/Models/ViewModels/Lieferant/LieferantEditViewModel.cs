using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bravo.Models.ViewModels.Lieferant
{
    public class LieferantEditViewModel
    {
        public long Id { get; set; }
        public string EMail { get; set; }
        public string Fax { get; set; }
        public string Mobil { get; set; }
        public string Name { get; set; }
        public string Ort { get; set; }
        public string Plz { get; set; }
        public string Strasse { get; set; }
        public string Telefon { get; set; }
    }
}
