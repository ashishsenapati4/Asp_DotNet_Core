using DependencyInjectionExp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionExp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository? _stuRepository = null;
        public HomeController(IStudentRepository studentRepository)
        {
            _stuRepository = studentRepository;
        }

        //without dependency injection
        //public JsonResult Index()
        //{
        //    StudentRepository studentRepository = new StudentRepository();
        //    List<Student> students = studentRepository.GetAllStudent();
        //    return Json(students);
        //}

        //public JsonResult GetStudentDetails(int id)
        //{
        //    StudentRepository repository = new StudentRepository();
        //    return Json(repository.GetStudentById(id));
        //}

        //With Dependency injection
        public JsonResult Index()
        {
            List<Student> students = _stuRepository.GetAllStudent();
            return Json(students);
        }

        public JsonResult GetStudentDetails(int id)
        {
            Student student = _stuRepository.GetStudentById(id);
            return Json(student);
        }

        //Action method injection using [FromServices]
        //public JsonResult Index([FromServices] IStudentRepository _stuRepository)
        //{
        //    List<Student> students = _stuRepository.GetAllStudent();
        //    return Json(students);
        //}
    }
}
