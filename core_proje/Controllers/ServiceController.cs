using businesslayer.concrete;
using dataaccesslayer.entityframework;
using entitylayer.concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ServiceController : Controller
    {
        servicemenager Servicemenager = new servicemenager(new efservicedal());
        public IActionResult Index()
        {
            var values = Servicemenager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddService(service service) 
        {
            Servicemenager.Tadd(service);
            return RedirectToAction("index");
        }
        public IActionResult DeleteService(int id)
        {
            var values = Servicemenager.TGetByID(id);
            Servicemenager.Tdelete(values);
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult EditService(int id)
        {
            var values = Servicemenager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditService(service service)
        {
            Servicemenager.Tupdate(service);
            return RedirectToAction("index");
        }

    }
}
