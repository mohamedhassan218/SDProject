using Microsoft.AspNetCore.Mvc;

namespace SDProject.Controllers.Inspector
{
    public class InspectorController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Inspector");
        }

        public IActionResult Cases() 
        {
            return View();
        }

        public IActionResult Inspector()
        {
            return View();
        }

        public IActionResult Report()
        {
            return View();
        }
    }
}
