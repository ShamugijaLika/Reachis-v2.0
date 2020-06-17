using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Reachis.Models
{
    public class ApplicationUser : IdentityUser
    {
        public static object Identity { get; internal set; }
        public ICollection<Planner> Planners { get; set; }

    }
    
}
