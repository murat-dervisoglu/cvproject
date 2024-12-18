using businesslayer.Abstract;
using businesslayer.concrete;
using dataaccesslayer.entityframework;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.ViewComponents.Contact
{
    public class ContactDetails: ViewComponent
    {
        ContactMenager contactmenager = new ContactMenager(new efcontactdal());
        public IViewComponentResult Invoke()
        {
            var values = contactmenager.TGetList();
            return View(values);
        }
    }
}
