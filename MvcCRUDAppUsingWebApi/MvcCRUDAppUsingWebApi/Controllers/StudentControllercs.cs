using Microsoft.AspNetCore.Mvc;
using MvcCRUDAppUsingWebApi.Models;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace MvcCRUDAppUsingWebApi.Controllers
{
    public class StudentController : Controller
    {

        private string baseUrl = "https://localhost:7179/api/StudentAPI/";

        private HttpClient client = new HttpClient();

        [HttpGet]
        public IActionResult Index()
        {
            List<Student> students = new List<Student>();
            HttpResponseMessage responseMessage = client.GetAsync(baseUrl).Result;
            if (responseMessage != null)
            {
                string message = responseMessage.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<List<Student>>(message);

                if (result != null)
                {
                    students = result;
                }
            }

            return View(students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            var studentData = JsonConvert.SerializeObject(student);
            StringContent content = new StringContent(studentData, Encoding.UTF8, "application/json");

            HttpResponseMessage respMessage = client.PostAsync(baseUrl, content).Result;
            if (respMessage != null)
            {
                TempData["status_message"] = "Record Inserted...";
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = new Student();
            HttpResponseMessage message = client.GetAsync(baseUrl + id).Result;
            if (message != null)
            {
                string res = message.Content.ReadAsStringAsync().Result;
                var stuObject = JsonConvert.DeserializeObject<Student>(res);

                if (stuObject != null)
                {
                    student = stuObject;
                }
            }
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            var stuData = JsonConvert.SerializeObject(student);
            var stringContent = new StringContent(stuData, Encoding.UTF8, "application/json");
            HttpResponseMessage respMessage = client.PutAsync(baseUrl + student.id, stringContent).Result;

            if (respMessage != null)
            {
                TempData["status_message"] = "Record updated...";
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var stu = new Student();
            var respMessage = client.GetAsync(baseUrl + id).Result;
            if (respMessage != null)
            {
                string message = respMessage.Content.ReadAsStringAsync().Result;
                var stuObject = JsonConvert.DeserializeObject<Student>(message);

                if (stuObject != null)
                {
                    stu = stuObject;
                }
            }
            return View(stu);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var stu = new Student();
            var respMessage = client.GetAsync(baseUrl + id).Result;
            if (respMessage.IsSuccessStatusCode)
            {
                string message = respMessage.Content.ReadAsStringAsync().Result;
                var studentObject = JsonConvert.DeserializeObject<Student>(message);
                if (studentObject != null)
                {
                    stu = studentObject;
                }
            }
            return View(stu);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var respMessage = client.DeleteAsync(baseUrl + id).Result;
            if (respMessage.StatusCode == HttpStatusCode.OK)
            {
                TempData["status_message"] = "Record Deleted...";
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
