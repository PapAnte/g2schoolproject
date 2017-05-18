using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bravo.Models.DatabaseEntities.Relation
{
    public class Software_in_Raum
    {
        public long SoftwareID { get; set; }
        public virtual Software Software { get; set; }

        public long RaumID { get; set; }
        public virtual Room Room { get; set; }
    }
}