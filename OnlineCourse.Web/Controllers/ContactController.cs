using Microsoft.AspNetCore.Mvc;

namespace OnlineCourse.Web.Controllers
{
    public class ContactController : Controller
    {
        [Route("contact-us")]
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
