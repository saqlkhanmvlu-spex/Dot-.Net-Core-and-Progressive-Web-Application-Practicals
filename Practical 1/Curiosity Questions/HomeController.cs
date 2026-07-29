using Microsoft.AspNetCore.Mvc;
using StudentResultMVC.Models;
namespace StudentResultMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(StudentResult s)
        {
            s.Total = s.Subject1 + s.Subject2 + s.Subject3 + s.Subject4 + s.Subject5;
            s.Percentage = s.Total / 5.0;

            if (s.Percentage >= 75)
                s.Grade = "A";
            else if (s.Percentage >= 60)
                s.Grade = "B";
            else if (s.Percentage >= 50)
                s.Grade = "C";
            else
                s.Grade = "Fail";

            return View(s);
        }
    }
}
