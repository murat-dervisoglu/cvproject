using businesslayer.concrete;
using dataaccesslayer.entity_framework;
using dataaccesslayer.entityframework;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.ViewComponents.Service
{
    public class ServiceList: ViewComponent

    {
        servicemenager servicemenager = new servicemenager(new efservicedal());
        public IViewComponentResult Invoke()
        {
            var values = servicemenager.TGetList();
            return View(values);
        }
    }
}
