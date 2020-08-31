using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Reachis.Controllers;

namespace Reachis.Models.Repository
{
    interface IRepository<T> : IDisposable
        where T : class
    {
        IEnumerable<T> GetPlannerList(ApplicationUser UserNow); // получение всех объектов
        T GetPlanner(int id); // получение одного объекта по id
        void Create(T item); // создание объекта
        void Update(T item); // обновление объекта
        void Delete(int id); // удаление объекта по id
        void Save();  // сохранение изменений
    }

    public class PlannerRepository : IRepository<Planner>
    {
        private ApplicationContext db;
        //private readonly SignInManager<ApplicationUser> signInManager;

        public PlannerRepository()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-22I96MT;Initial Catalog=ReachisRDB;Persist Security Info=True;User ID=QLS;Password=admin;Trusted_Connection=True;");
            this.db = new ApplicationContext(optionsBuilder.Options);
            //this.signInManager = signInManager;

        }

        public IEnumerable<Planner> GetPlannerList(ApplicationUser UserNow)
        {
            return db.Planners.Where(x => x.user == UserNow);
        }

        public Planner GetPlanner(int id)
        {
            return db.Planners.Find(id);
        }

        public void Create(Planner planner)
        {
             db.Planners.Add(planner);
        }

        public void Update(Planner planner)
        {
            db.Entry(planner).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Planner planner = db.Planners.Find(id);
            if (planner != null)
                db.Planners.Remove(planner);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
