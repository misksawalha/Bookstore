using Bookstore.Data;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();

            return View(categories);
        }
    }
}
