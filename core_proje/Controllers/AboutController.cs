using businesslayer.concrete;
using dataaccesslayer.entity_framework;
using dataaccesslayer.entityframework;
using entitylayer.concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AboutController : Controller
    {
        aboutmenager aboutMenager = new aboutmenager(new efaboutdal());
        
        [HttpGet]
        public IActionResult Index()
        {
            var values = aboutMenager.TGetByID(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(about about)
        {
            aboutMenager.Tupdate(about);
            return RedirectToAction("Index", "DefaultController1");
        }
    }
}
