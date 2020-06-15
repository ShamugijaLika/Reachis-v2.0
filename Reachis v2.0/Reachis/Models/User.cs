using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Reachis.Models
{
    public class ApplicationUser : IdentityUser
    {
        //public ApplicationUser() { }
        public virtual ICollection<Planner> Planners { get; set; }

    }
    
}
