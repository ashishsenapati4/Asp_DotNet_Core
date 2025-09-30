using System.Diagnostics;
using AspCoreWithjQuery.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreWithjQuery.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        [HttpPost]
        public int Subtract(int n1, int n2)
        {
            return n1 - n2;
        }

        [HttpPost]
        public Calculator Calculate(int n1, int n2)
        {
            Calculator cal = new Calculator();

            cal.Add = n1 + n2;
            cal.Sub = n1 - n2;
            cal.Mul = n1 * n2;
            cal.Div = (decimal)n1 / n2;

            return cal;
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
