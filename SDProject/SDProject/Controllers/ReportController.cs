using Microsoft.AspNetCore.Mvc;

namespace SDProject.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Submit()
        {
            return View();
        }
    }
}
