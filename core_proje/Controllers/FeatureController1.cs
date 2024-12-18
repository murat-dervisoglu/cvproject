using businesslayer.concrete;
using dataaccesslayer.entityframework;
using entitylayer.concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class FeatureController1 : Controller
    {
        FeatureMenager FeatureMenager = new FeatureMenager(new effeaturedal());
        public IActionResult Index()
        {
            var values = FeatureMenager.TGetByID(1);
            return View(values);
        }
        
        [HttpPost]
        public IActionResult Index(feature feature)
        {
            FeatureMenager.Tupdate(feature);
            return RedirectToAction("Index", "DefaultController1");
        }
    }
}
