using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bravo.Models.DatabaseEntities.Relation
{
    public class Geraetekomponente_Information
    {
        public long GeraetID { get; set; }
        public virtual Geraet Geraet { get; set; }

        public long AttributID { get; set; }
        public virtual Geraetekomponente Geraetekomponente { get; set; }

        public string Bezeichnung { get; set; }
    }
}
