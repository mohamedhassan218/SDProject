using Microsoft.AspNetCore.Mvc;

namespace SDProject.Controllers
{
    public class RegisterationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
