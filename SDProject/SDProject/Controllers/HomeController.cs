using Microsoft.AspNetCore.Mvc;
using SDProject.Models;
using System.Diagnostics;

namespace SDProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cases()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Data()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Inspector()
        {
            return View();
        }

        public IActionResult Information()
        {
            return View();
        }

       
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Report()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
