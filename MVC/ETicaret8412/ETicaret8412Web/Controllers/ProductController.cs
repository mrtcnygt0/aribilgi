using ETicaret8412Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret8412Web.Controllers
{
    public class ProductController : Controller
    {
        _8412dbContext _context = new _8412dbContext();
        public IActionResult Index()
        {
            List<Product> liste = _context.Products.ToList();
            return View(liste);
        }
    }
}
