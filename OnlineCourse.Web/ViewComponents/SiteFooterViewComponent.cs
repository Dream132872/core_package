using Microsoft.AspNetCore.Mvc;

namespace OnlineCourse.Web.ViewComponents
{
    public class SiteFooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
