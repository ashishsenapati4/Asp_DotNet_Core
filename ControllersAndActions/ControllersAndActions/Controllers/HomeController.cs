using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    [Route("")]
    [Route("Home")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            //ViewData["name"] = "Ashish";
            //ViewData["age"] = 23;
            //ViewData["currentDate"] = DateTime.Now.ToLongDateString();

            //string[] TempleArray = { "Jagannath Temple", "Lingaraj Temple", "Tarini Temple", "Nilamadhaba Temple" };
            //ViewData["temples"] = TempleArray;

            //ViewData["games"] = new List<String>()
            //{ 
            //    "Cricket", "Football", "Badminton", "Hockey", "Kabaddi", "GotiDabula", "Baunsha"
            //};

            //ViewBag.name = "Arpita";
            //ViewBag.age = 21;
            //ViewBag.currentDate = DateTime.Now.ToShortDateString();

            //ViewData["myCrush"] = "money";


            //string[] TempleArray = { "Jagannath Temple", "Lingaraj Temple", "Tarini Temple", "Nilamadhaba Temple" };
            //ViewBag.temples = TempleArray;

            //ViewBag.games = new List<String>()
            //{
            //    "Cricket", "Football", "Badminton", "Hockey", "Kabaddi", "GotiDabula", "Baunsha Bagudi"
            //};

            ViewData["data1"] = "View_Data";
            ViewBag.data2 = "View_Bag";
            TempData["data3"] = "Temp_Data";

            TempData["data4"] = new List<string>()
            {
                "Cricket", "Football", "Badminton", "Hockey", "Kabaddi", "GotiDabula", "Baunsha"
            };

            TempData.Keep("data3");

            return View();
        }

        //[Route("")]
        [Route("About")]
        public IActionResult About()
        {
            TempData.Keep("data3");
            return View();
        }

        [Route("Contact")]
        public IActionResult Contact()
        {
            TempData.Keep("data3");
            return View();
        }
    }
}
