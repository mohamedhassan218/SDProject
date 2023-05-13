using Microsoft.AspNetCore.Mvc;

namespace SDProject.Controllers.Inspector
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
