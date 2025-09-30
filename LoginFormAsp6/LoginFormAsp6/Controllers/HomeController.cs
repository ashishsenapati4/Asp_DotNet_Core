using LoginFormAsp6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace SessionAspCore6.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyDBContext _dbContext;

        public HomeController(MyDBContext myDBContext)
        {
            this._dbContext = myDBContext;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("UserSession") != null)
            {
                return RedirectToAction("Dashboard");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Login(UsrTbl user)
        {
            
            var myUser = _dbContext.UsrTbls.Where(x => x.Email == user.Email && x.Password == user.Password).FirstOrDefault();

            if (myUser!=null)
            {
                HttpContext.Session.SetString("UserSession", user.Email);
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.Message = "Login Failed...";
            }
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UsrTbl user)
        {
            if(ModelState.IsValid)
            {
                await _dbContext.UsrTbls.AddAsync(user);
                await _dbContext.SaveChangesAsync();
                TempData["Data"] = "User " + user.Name + " added successfully";
                return RedirectToAction("Login");

            }
            return View();

        }

        public IActionResult Dashboard()
        {
            if(HttpContext.Session.GetString("UserSession") !=null)
            {
                ViewBag.Data = HttpContext.Session.GetString("UserSession");
            }
            else
            {
                return RedirectToAction("Login");
            }
            return View();
        }

        public IActionResult Logout()
        {
            if(HttpContext.Session.GetString("UserSession") != null)
            {
                HttpContext.Session.Remove("UserSession");
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> Display()
        {
            return  _dbContext.UsrTbls != null ? View(await _dbContext.UsrTbls.ToListAsync()) : Problem("Error");
        }

        public IActionResult Privacy()
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
