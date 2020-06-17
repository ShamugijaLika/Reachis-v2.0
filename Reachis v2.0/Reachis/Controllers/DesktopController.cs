
using Microsoft.AspNetCore.Mvc;
using Reachis.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Net;

namespace Reachis.Controllers
{
    public class DesktopController : Controller
    {      

        public IActionResult Plannings()
        {
            //Проверем, залогинился ли пользователь, если нет, тогда отправляем на страницу
            if (!HttpContext.User.Identity.IsAuthenticated) return RedirectToAction("Login", "Account");
            return View("DesktopPlannings");
        }

    }
}