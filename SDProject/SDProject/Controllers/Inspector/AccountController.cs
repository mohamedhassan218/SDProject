using Microsoft.AspNetCore.Mvc;

namespace SDProject.Controllers.Inspector
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Startup");
        }

        public IActionResult Startup()
        {
            return View();
        }
        public IActionResult AsAdmin()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Signup()
        {
            return View();
        }
    }
}
