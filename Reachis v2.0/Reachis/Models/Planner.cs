﻿using System;
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
        public ICollection<Area> Areas { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public ICollection<Tab> Tabs { get; set; }

    }

    public class Tab
    {
        public int TabId { get; set; }
        public string urlTab { get; set; }
        public Planner planner { get; set; }
        public bool checkTab { get; set; }
    }
}
