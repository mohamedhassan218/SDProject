using Microsoft.AspNetCore.Mvc;
using SDProject.Data;

namespace SDProject.Controllers
{
    public class InformationController : Controller
    {
        private readonly ApplicationDbContext _dbcontext;

        public InformationController(ApplicationDbContext context)
        {
            _dbcontext = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddCase()
        {

            return View();
        }

    }
}
