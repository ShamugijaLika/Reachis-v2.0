using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Reachis.Models
{
    public class Planner
    {
        public int PlannerId { get; set; }
        public string PlannerName { get; set; }
        public DateTime StartDday { get; set; }
        public DateTime EndDday { get; set; }
        public string ColorPlanner { get; set; }
        public virtual ApplicationUser user { get; set; }
        public virtual ICollection<Area> Areas { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }

    }
}
