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
        [Key]
        public int PlannerId { get; set; }
        public string PlannerName { get; set; }
        public DateTime StartDday { get; set; }
        public DateTime EndDday { get; set; }
        public string ColorPlanner { get; set; }
        public virtual ApplicationUser user { get; set; }
        public ICollection<Area> Areas { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public ICollection<Tab> Tabs { get; set; }
        public ICollection<Memo> Memos { get; set; }
        public ICollection<Decompose> Decomposes { get; set; }

    }
    public class Area
    {
        [Key]
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public string AreaColor { get; set; }
        public int AreaTimeInMin { get; set; }
        public Planner planner { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
    public enum CheckedEnum
    {
        BulletScheduled = 0,
        BulletComplete = 1,
        BulletNotComplete = 2,
        BulletMoved = 3
    }
    public class Task
    {
        [Key]
        public int TaskId { get; set; }
        public string TaskDesc { get; set; }
        public string DayToDay { get; set; }
        public int TimeInMin { get; set; }
        public CheckedEnum Check { get; set; }
        public Planner planner { get; set; }
        public Area area { get; set; }

    }

    public class Tab
    {
        [Key]
        public int TabId { get; set; }
        public string urlTab { get; set; }
        public Planner planner { get; set; }
        public bool checkTab { get; set; }
    }

    public class Memo
    {
        [Key]
        public int MemoId { get; set; }
        public string MemoText { get; set; }
        public string MemoOfDay { get; set; }
        public string StarOfDay { get; set; }
        public Planner PlannerMemo { get; set; }
    }

    public enum DecomDays
    {
        DayN = 0,
        DayN70 = 1,
        DayN50 = 2,
        DayN20 = 3,
        DayN10 = 4,
    }
    public class Decompose
    {
        [Key]
        public int DecomposeId { get; set; }
        public DecomDays DecomDay { get; set; }
        public Planner planner { get; set; }
        public ICollection<DecomposeMemo> DecomposeMemos { get; set; }  
    }
    public class DecomposeMemo
    {
        [Key]
        public int DecomposeMemoId { get; set; }
        public string DecoMemo { get; set; }
        public CheckedEnum CheckDeco { get; set; }
        public Decompose DecomposeDM { get; set; }
    }
}
