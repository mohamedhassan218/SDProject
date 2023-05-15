using Microsoft.AspNetCore.Mvc;
using SDProject.Data;

namespace SDProject.Controllers.Inspector
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

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
        public IActionResult Inspectors()
        {
            var inspectors = _context.Inspectors;
            return View(inspectors);
        }

        public IActionResult Reports()
        {
            var reports = _context.Reports.ToList();
            return View(reports);
        }
    }
}
