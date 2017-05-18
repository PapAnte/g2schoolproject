using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bravo.Models.DatabaseEntities.Relation
{
    public class Geraeteart_Komponenten_Vorgabe
    {
        public long GeraeteartID { get; set; }
        public virtual Geraeteart Geraeteart { get; set; }

        public long GeraeteartkomponenteID { get; set; }
        public Geraetekomponente Geraetekomponente { get; set; }
    }
}
