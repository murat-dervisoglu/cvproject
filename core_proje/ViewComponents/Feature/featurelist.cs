using businesslayer.concrete;
using dataaccesslayer.entityframework;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.ViewComponents.Feature
{
    public class featurelist : ViewComponent
    {
        FeatureMenager featuremenager = new FeatureMenager(new effeaturedal());
        public IViewComponentResult Invoke()
        {
            var values= featuremenager.TGetList();
            return View(values);
        }
    }
}
