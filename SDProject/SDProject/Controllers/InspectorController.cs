using Microsoft.AspNetCore.Mvc;
using SDProject.Data;
using SDProject.Models;

namespace SDProject.Controllers.Inspector
{
    public class InspectorController : Controller
    {
        private readonly ApplicationDbContext _context;
        private CaseInspector _inspector;
        public InspectorController(ApplicationDbContext context, CaseInspector inspector)
        {
            _context = context;
            _inspector = inspector;
        }
        public IActionResult Index()
        {
            return RedirectToAction("Inspector");
        }
        public IActionResult Cases() 
        {
            var cases = _context.Cases.ToList();
            foreach(var x in cases)
            {
                if(x.Inspector != _inspector)
                {
                    cases.Remove(x);
                }
            }
            return View(cases);
        }
        public IActionResult Inspector()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Report()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Report(Report report)
        {
            if (ModelState.IsValid)
            {
                _context.Add(report);
                _context.SaveChanges();
                return RedirectToAction("Index", "Inspector");
            }
            return View(report);
        }
    }
}