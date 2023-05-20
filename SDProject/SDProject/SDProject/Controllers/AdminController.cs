using Microsoft.AspNetCore.Mvc;
using SDProject.Data;
using SDProject.Models;
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
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CaseInspector inspector, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                if (image != null && image.Length > 0)
                {
                    using (var ms = new MemoryStream())
                    {
                        image.CopyTo(ms);
                        inspector.ImageData = ms.ToArray();
                    }
                }
                _context.Add(inspector);
                _context.SaveChanges();
                return RedirectToAction("Index", "Admin");
            }
            return View(inspector);
        }
        // Add New Case.
        [HttpGet]
        public IActionResult Information()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Information(Case c)
        {
            if (ModelState.IsValid)
            {
                _context.Add(c);
                _context.SaveChanges();
                return RedirectToAction("Index", "Admin");
            }
            return View(c);
        }
        public IActionResult Inspectors()
        {
            var inspectors = _context.Inspectors.ToList();
            return View(inspectors);
        }
        public IActionResult Reports()
        {
            var reports = _context.Reports.ToList();
            return View(reports);
        }
    }
}
