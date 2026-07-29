using Microsoft.AspNetCore.Mvc;

namespace ShoppingMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult SetTheme(string theme)
        {
            CookieOptions option = new CookieOptions();
            option.Expires = DateTime.Now.AddDays(30);

            Response.Cookies.Append("Theme", theme, option);

            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            ViewBag.Theme = Request.Cookies["Theme"];
            return View();
        }
    }
}
