using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reachis.Models
{
    public class Area
    {
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public string AreaColor { get; set; }
        public int AreaTimeInMin { get; set; }
        public Planner planner { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
