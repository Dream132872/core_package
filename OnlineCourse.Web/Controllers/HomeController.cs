using Microsoft.AspNetCore.Mvc;

namespace OnlineCourse.Web.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact-us")]
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}