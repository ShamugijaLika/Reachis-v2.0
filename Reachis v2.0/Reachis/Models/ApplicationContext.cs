using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Reachis.Models;
using System.Threading.Tasks;

namespace Reachis.Models
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {

        }

        //public static ApplicationContext Create()
        //{
        //    return new ApplicationContext();
        //}
        public DbSet<Planner> Planners { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //Отношения между моделями в Fluent API - one to many
            builder.Entity<Planner>()
               .HasOne(p => p.user)
               .WithMany(b => b.Planners);
            builder.Entity<Area>()
               .HasOne(p => p.planner)
               .WithMany(b => b.Areas);
            builder.Entity<Task>()
               .HasOne(p => p.planner)
               .WithMany(b => b.Tasks);
            builder.Entity<Task>()
                .HasOne(p => p.area)
                .WithMany(b => b.Tasks);

        }

    }


}