using businesslayer.concrete;
using dataaccesslayer.entityframework;
using entitylayer.concrete;
using Microsoft.AspNetCore.Mvc;


namespace core_proje.ViewComponents.Contact
{
    public class SendMessage: ViewComponent
    {
        MessageMenager messagemenager = new MessageMenager(new efmessagedal());

        [HttpGet]

        public IViewComponentResult Invoke()
        {
            return View();
        }
        
    }
}
