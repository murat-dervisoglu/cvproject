using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using businesslayer.concrete;
using dataaccesslayer.entityframework;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.ViewComponents.Portfolio
{
    public class PortfolioList : ViewComponent
    {
        PortfolioManager portfolioMenager = new PortfolioManager(new efportfoliodal());
        public IViewComponentResult Invoke()
        {
            var values = portfolioMenager.TGetList();
            return View(values);
        }
    }
}
