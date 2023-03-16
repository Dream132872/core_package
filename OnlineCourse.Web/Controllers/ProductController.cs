using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineCourse.Web.Context;
using OnlineCourse.Web.Entities.Products;
using OnlineCourse.Web.Models;
using System.Diagnostics;

namespace OnlineCourse.Web.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext _context;


        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }


        // /Product/Index
        [HttpGet("products")]
        public IActionResult Index()
        {
            // create product ( C )
            //var newProduct = new Product()
            //{
            //    ProductName = "New Product",
            //    ShortDescription = "short description",
            //    ProductDescription = "long description",
            //    Image = "new_product.png",
            //    Inventory = 100,
            //    Price = 200000,
            //    Tags = "new,product,new_product",
            //    IsActive = true
            //};

            //_context.Products.Add(newProduct);
            //_context.SaveChanges();


            // get products ( R )
            var products = _context.Products.AsNoTracking().ToList(); // id : 1,2,3
            // var product = _context.Products.Single(p => p.Id == 3); // id : 3


            // update product ( U )
            //product.ProductName = "Product 3 for thrid time";
            //product.Price = 100;
            //_context.Products.Update(product);
            //_context.SaveChanges();

            // delete product ( D )
            //_context.Products.Remove(product);
            //_context.SaveChanges();

            return View(products);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
