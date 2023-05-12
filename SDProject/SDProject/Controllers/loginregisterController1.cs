using Microsoft.AspNetCore.Mvc;
using SDProject.Data;
using SDProject.Models;
using System.Diagnostics;

namespace SDProject.Controllers
{
    public class loginregisterController1 : Controller
    {
        private readonly ApplicationDbContext _dbcontext;
        public loginregisterController1(ApplicationDbContext context)
        {
            _dbcontext = context;
        }

        public IActionResult Index()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Create(CaseInspector account)
        {
            if (ModelState.IsValid)
            {
                _dbcontext.Inspectors.Add(account);
                _dbcontext.SaveChanges();
                return RedirectToAction("Data", "Home");
            }
            return View(account);
        }
        [HttpPost]
        public IActionResult Login (CaseInspector user)
        {
            if (ModelState.IsValid)
            {
              var userEmail=  _dbcontext.Inspectors.FirstOrDefault(u => u.Email == user.Email);

                if (userEmail != null && user.Password == user.Password)
                {
                    if (user.Email.Substring(0, 5) == "admin")
                    {
                        return RedirectToAction("Data", "Home");
                    }
                    else return RedirectToAction("Inspector", "Home");
                }
                else ModelState.AddModelError("", "Invalid email or passward");
            }
            return View( user);
        }
    }
}
