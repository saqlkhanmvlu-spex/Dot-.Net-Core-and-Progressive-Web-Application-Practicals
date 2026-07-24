using Microsoft.AspNetCore.Mvc;
public class HomeController : Controller
{
    private readonly AppDbContext _context;
    public HomeController(AppDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        Product p = new Product();
        p.Name = "Saqlain";
        p.Salary = 50000;
        _context.Products.Add(p);
        _context.SaveChanges();
        return Content("Product Inserted Successfully");
    }
}
