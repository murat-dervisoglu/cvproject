using dataaccesslayer.concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace core_proje.ViewComponents.Dashboard
{
    public class StatisticsDashboard2 : ViewComponent
    {
        context c = new context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.portfolios.Count();
            ViewBag.v2 = c.messages.Count();
            ViewBag.v3 = c.services.Count();
            return View();
        }
    }
}
