using businesslayer.concrete;
using dataaccesslayer.entity_framework;
using dataaccesslayer.entityframework;
using entitylayer.concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ContactSubController : Controller
    {
        ContactMenager contactMenager = new ContactMenager(new efcontactdal());

        [HttpGet]
        public IActionResult Index()
        {
            var values = contactMenager.TGetByID(7);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(contact contact)
        {
            contactMenager.Tupdate(contact);
            return RedirectToAction("Index", "ContactSub"); 
        }
    }
}
