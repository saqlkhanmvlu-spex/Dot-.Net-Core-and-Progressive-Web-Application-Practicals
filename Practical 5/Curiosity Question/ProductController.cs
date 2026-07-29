using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShoppingMVC.Data;
using ShoppingMVC.Models;

namespace ShoppingMVC.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext db;

        public ProductController(ApplicationDbContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(db.Products.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(Product p)
        {
            db.Products.Update(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var p = db.Products.Find(id);
            db.Products.Remove(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
