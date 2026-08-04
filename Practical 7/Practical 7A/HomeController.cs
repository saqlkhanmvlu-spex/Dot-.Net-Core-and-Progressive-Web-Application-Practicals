using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Prac7.Models;
using WebApplication8.Models;

namespace Prac7.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Student s = new Student();

            s.RollNo = 13;
            s.Name = "Saqlain Khan";

            return View(s);

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
