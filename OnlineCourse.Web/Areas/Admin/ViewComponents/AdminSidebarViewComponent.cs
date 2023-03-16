using Microsoft.AspNetCore.Mvc;

namespace OnlineCourse.Web.Areas.Admin.ViewComponents
{
    public class AdminSidebarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("AdminSidebar");
        }
    }
}
