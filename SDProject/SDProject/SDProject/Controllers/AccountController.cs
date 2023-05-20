using Microsoft.AspNetCore.Mvc;
using SDProject.Data;
using SDProject.Models;

namespace SDProject.Controllers.Inspector
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return RedirectToAction("Startup");
        }
        public IActionResult Startup()
        {
            var name = HttpContext.Session.GetString("Name");
            if (string.IsNullOrEmpty(name))
            {
                return View();
            }
            return View();
        }
        public IActionResult AsAdmin()
        {
            return View();
        }
       
        // Specified to the Admin.
        [HttpGet]
        public IActionResult Login()
        {
            return View(new Login());
        }
        [HttpPost]
        public IActionResult Login(Login user)
        {
            var result = _context.Admins.FirstOrDefault(u => u.Email == user.Email);
            if(result != null && result.Password == user.Password)
            {
                HttpContext.Session.SetString("Email", user.Email);
                return RedirectToAction("Index", "Admin");
            }
            return View(user);
        }
       
        // To enable Admin to create new account.
        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signup(Admin user)
        {
            if(ModelState.IsValid)
            {
                _context.Add(user);
                _context.SaveChanges();
                return RedirectToAction("SignIn", "Account");
            }
            return View(user);
        }

        // Specified to the Inspector.
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(CaseInspector user)
        {
            var result = _context.Inspectors.FirstOrDefault(u => u.Email == user.Email);
            if (result != null && result.Password == user.Password)
            {
                HttpContext.Session.SetString("Email", user.Email);
                return RedirectToAction("Index", "Inspector");
            }
            return View(user);
        }
    }
}