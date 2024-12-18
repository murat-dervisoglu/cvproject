using businesslayer.concrete;
using dataaccesslayer.entity_framework;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.ViewComponents.about
{
    public class AboutList : ViewComponent

    {
        aboutmenager aboutMenager = new aboutmenager(new efaboutdal());
        public IViewComponentResult Invoke()
        {
            var values = aboutMenager.TGetList();
            return View(values);
        }
    }
}
