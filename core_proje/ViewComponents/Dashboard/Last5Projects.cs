using businesslayer.concrete;
using dataaccesslayer.entityframework;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.ViewComponents.Dashboard
{
    public class Last5Projects : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            PortfolioManager portfolioMenager = new PortfolioManager(new efportfoliodal());
            var values = portfolioMenager.TGetList().OrderByDescending(x=>x.portfolioID).Take(5).ToList();
            return View(values);
        }
    }
}
