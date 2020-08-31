
using Microsoft.AspNetCore.Mvc;
using Reachis.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Net;
using Reachis.Models.Repository;
using System.Runtime.InteropServices.WindowsRuntime;
using System;
using System.Security.Principal;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Reachis.Controllers;

namespace Reachis.Controllers
{
    public class DesktopController : Controller
    {
        IRepository<Planner> db;

        public DesktopController()
        {
            db = new PlannerRepository();
        }
        public IActionResult Plannings()
        {
            //Проверем, залогинился ли пользователь, если нет, тогда отправляем на страницу авторизации
            if (!HttpContext.User.Identity.IsAuthenticated) return RedirectToAction("Login", "Account");
            return View("DesktopPlannings", db.GetPlannerList(AuthUser.UserAuth));
        }
        
        //[HttpGet]
        public IActionResult Create()
        {
            return View("PlusPlanning");
        }

        [HttpPost]
        public IActionResult Create(PlannerAddViewModel model)
        {
            if(ModelState.IsValid)
            {
                Planner newPlanner = new Planner
                {
                    PlannerName = model.PlanName,
                    StartDday = model.Startday,
                    EndDday = model.Endday,
                    user = AuthUser.UserAuth
                };

                db.Create(newPlanner);
                db.Update(newPlanner);
                db.Save();
                return RedirectToAction("Plannings");
            }
            return View(model);
        }

    }
}