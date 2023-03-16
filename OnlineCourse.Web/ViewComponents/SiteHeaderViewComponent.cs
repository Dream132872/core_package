using Microsoft.AspNetCore.Mvc;

namespace OnlineCourse.Web.ViewComponents
{
    public class SiteHeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.ComponentData = "component dynamic data";

            return View();
        }
    }
}
