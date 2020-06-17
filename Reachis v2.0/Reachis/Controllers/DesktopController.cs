
using Microsoft.AspNetCore.Mvc;

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