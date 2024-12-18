using businesslayer.concrete;
using dataaccesslayer.concrete;
using dataaccesslayer.entityframework;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.ViewComponents.Dashboard
{
    public class FeatureStatistics : ViewComponent
    {       
        context c = new context();

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.skills.Count();
            ViewBag.v2 = c.portfolios.Count();
            ViewBag.v3 = c.experiences.Count();
            ViewBag.v4 = c.messages.Where(x =>x.status==false).Count();
            
            return View();
        }
    }
}
