using Microsoft.AspNetCore.Mvc;
using CoursesMVCTypre.Models;
using System.Diagnostics;
using System.Xml.Linq;

namespace CoursesMVCTypre.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Greeting(String name, int age = 34)
        {
            ViewData["Greeting"] = "Hello" + name;
            ViewData["Age"] = age;
            return View();

        }
        public IActionResult instructors()
        {
            instructors instructor = new instructors();
            string instrctorname = instructor.GetName();
            int age = instructor.GetAge();

            ViewData["Greeting"] = "Hello" + instrctorname;
            ViewData["Age"] = age;
            return View();


        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
