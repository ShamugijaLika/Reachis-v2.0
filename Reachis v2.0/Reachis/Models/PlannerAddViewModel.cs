using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reachis.Models
{
    public class PlannerAddViewModel
    {
        [Required]
        public string PlanName { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public string Startday { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public string Endday { get; set; }
    }
}
