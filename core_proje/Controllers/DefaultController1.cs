using businesslayer.concrete;
using dataaccesslayer.entityframework;
using entitylayer.concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.Controllers
{
    [AllowAnonymous]
    public class DefaultController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SendMessage(message p)
        {
            MessageMenager messagemenager = new MessageMenager(new efmessagedal());
            p.date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.status = true;
            messagemenager.Tadd(p);
            return PartialView();
        }
    }
}
