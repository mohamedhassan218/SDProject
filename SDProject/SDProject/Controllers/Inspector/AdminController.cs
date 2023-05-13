using Microsoft.AspNetCore.Mvc;

namespace SDProject.Controllers.Inspector
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Data");
        }

        // Admin Home page.
        public IActionResult Data() 
        {
            return View();
        }
        // Create Inspector Account.
        public IActionResult Create()
        {
            return View();
        }

        // Add New Case.
        public IActionResult Information()
        {
            return View();
        }
    }
}
