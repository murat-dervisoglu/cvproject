using businesslayer.concrete;
using dataaccesslayer.entityframework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ContactController : Controller
    {
        MessageMenager messageMenager = new MessageMenager(new efmessagedal());
        public IActionResult Index()
        {
            var values = messageMenager.TGetList();
            return View(values);
        }
        public IActionResult DeleteContact(int id)
        {
            var values = messageMenager.TGetByID(id);
            messageMenager.Tdelete(values);
            return View("index");
        }
        public IActionResult ContactDetails(int id)
        {
            var values = messageMenager.TGetByID(id);
            return View(values);    
        }
    }
}
