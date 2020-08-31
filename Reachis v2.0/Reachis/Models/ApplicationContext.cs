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

        public DbSet<Planner> Planners { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Tab> Tabs { get; set; }
        public DbSet<Decompose> Decomposes { get; set; }
        public DbSet<Memo> Memos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // На первом этапе разработки здесь строились отношения между моделями в Fluent API - one to many
            //builder.Entity<Planner>()
            //   .HasOne(p => p.user)
            //   .WithMany(b => b.Planners);
            //builder.Entity<Area>()
            //   .HasOne(p => p.planner)
            //   .WithMany(b => b.Areas);
            //builder.Entity<Task>()
            //   .HasOne(p => p.planner)
            //   .WithMany(b => b.Tasks);
            //builder.Entity<Task>()
            //    .HasOne(p => p.area)
            //    .WithMany(b => b.Tasks);
            //builder.Entity<Decompose>()
            //    .HasOne(p => p.planner)
            //    .WithMany(b => b.Decomposes);
            //builder.Entity<DecomposeMemo>()
            //    .HasOne(p => p.DecomposeDM)
            //    .WithMany(b => b.DecomposeMemos);
            //builder.Entity<Memo>()
            //    .HasOne(p => p.PlannerMemo)
            //    .WithMany(b => b.Memos);
            //builder.Entity<Tab>()
            //    .HasOne(p => p.planner)
            //    .WithMany(b => b.Tabs);

        }

    }


}