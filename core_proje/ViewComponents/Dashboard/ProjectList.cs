using businesslayer.Abstract;
using businesslayer.concrete;
using core_proje.Controllers;
using dataaccesslayer.entityframework;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.ViewComponents.Dashboard
{
    public class ProjectList(Iportfolioservice portfolioservice) : ViewComponent
    {
        public readonly Iportfolioservice _portfolioService = portfolioservice;

        public IViewComponentResult Invoke()
        {
            //PortfolioMenager portfolioManager = new PortfolioMenager(new efportfoliodal());
            var values = _portfolioService.TGetList();
            
            return View(values);
        }
    }
}
