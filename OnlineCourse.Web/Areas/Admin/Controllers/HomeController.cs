using Microsoft.AspNetCore.Mvc;

namespace OnlineCourse.Web.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
