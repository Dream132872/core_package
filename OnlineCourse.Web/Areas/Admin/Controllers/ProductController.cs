using Microsoft.AspNetCore.Mvc;
using OnlineCourse.Web.Context;

namespace OnlineCourse.Web.Areas.Admin.Controllers
{
    public class ProductController : AdminBaseController
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext contex)
        {
            _context = contex;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View();
        }
    }
}
