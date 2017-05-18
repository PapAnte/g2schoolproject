using Bravo.Models.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bravo.Models.ViewModels.Room
{
    public class RoomEditViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<DatabaseEntities.Tool> AllTools { get; set; }
        public List<DatabaseEntities.Tool> ToolListFromRoom { get; set; }
    }
}
