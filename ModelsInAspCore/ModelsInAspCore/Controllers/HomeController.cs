using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelsInAspCore.Models;
using ModelsInAspCore.Repository;

namespace ModelsInAspCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IStudent _student = null;

        private readonly IBook _book = null;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _student = new StudentRepository();
            _book = new BookRepository();
        }

        public IActionResult Index()
        {
            //var students = new List<StudentModel>
            //{ 
            //    new StudentModel {StudentId = 899, StudentName = "Ashish", StudentEmail = "ashish@gmail.com", StudentPhone = 73882882},
            //    new StudentModel {StudentId = 874, StudentName = "Amita", StudentEmail = "amita@gmail.com", StudentPhone = 56256277},
            //    new StudentModel {StudentId = 425, StudentName = "Pooja", StudentEmail = "pooja@gmail.com", StudentPhone = 02882992},

            //};

            //ViewData["studentData"] = students;

            return View();
        }

        public List<StudentModel> Students()
        {
            return _student.GetAllStudents();
        }

        public StudentModel StudentById(int id)
        {
            return _student.GetStudentById(id);
        }

        public List<BookModel> Books()
        {
            return _book.GetAllBooks();
        }

        public BookModel BookById(int id)
        {
            return _book.BookById(id);
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
