using Microsoft.AspNetCore.Mvc;
using SDProject.Data;
using SDProject.Models;

namespace SDProject.Controllers
{
    public class InspectorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InspectorController(ApplicationDbContext _context)
        {
            _context = _context;
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CaseInspector inspector)
        {
            if(ModelState.IsValid)
            {
                _context.Inspectors.Add(inspector);
                _context.SaveChanges();
                return View();
            }
            return View();
        }
    }
}
