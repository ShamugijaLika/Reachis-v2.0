using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reachis.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public string TaskDesc { get; set; }
        public string DayToDay { get; set; }
        public int TimeInMin { get; set; }
        public CheckedEnum Check { get; set; }
        public Planner planner { get; set; }
        public Area area { get; set; }

    }
}
