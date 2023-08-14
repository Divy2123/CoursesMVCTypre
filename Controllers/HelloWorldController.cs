
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace CoursesMVCTypre.Controllers
{
    public class HomeWorldController : Controller
    {
        public String Index()
        {
            return "This is the default action. The default Controller method. Always named Index()";
        }
        public string Welcome()
        {
            return "This is the Welcome action method, the other custom Controller method Welcome()";
        }
        public string Info(string name, int age = 34)
        {

            return HtmlEncoder.Default.Encode($"Hello {name}, Age is: {age}");
        }

        public string Verify(string name, int ID = 34)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }

    }
}