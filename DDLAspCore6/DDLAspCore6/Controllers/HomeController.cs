using System.Diagnostics;
using DDLAspCore6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DDLAspCore6.Controllers
{
    public enum Gender
    {
        Male,
        Female
    }

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            List<SelectListItem> list = new List<SelectListItem>
            {
                new SelectListItem("Male","Male"),
                new SelectListItem("Female", "Female"),
                new SelectListItem("Other", "Other")
            };
            ViewBag.List = list;

            return View();
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
