using businesslayer.concrete;
using dataaccesslayer.entityframework;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.ViewComponents.Portfolio
{
    public class SlideList : ViewComponent
    {
        PortfolioManager portfolioMenager = new PortfolioManager(new efportfoliodal());
        public IViewComponentResult Invoke()
        {
            var values = portfolioMenager.TGetList();
            return View(values);
        }
    }
}
