using Microsoft.AspNetCore.Mvc;
using SDProject.Data;
using SDProject.Models;
namespace SDProject.Controllers.Inspector
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostEnvironment _environment;
        public AdminController(ApplicationDbContext context, IHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
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
        [ValidateAntiForgeryToken]  // to more security
        public async Task<IActionResult> Create(CaseInspector inspector, IFormFile img_file)
        {
            // to create Images folder in the project Path.
            string path = "wwwroot/images/"; // wwwroot/Img/
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (img_file != null)
            {
                path = Path.Combine(path, img_file.FileName); // for exmple : /Img/Photoname.png
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await img_file.CopyToAsync(stream);
                    ViewBag.Message = string.Format("<b>{0}</b> uploaded.</br>", img_file.FileName.ToString());
                }
            }
            return View();
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
