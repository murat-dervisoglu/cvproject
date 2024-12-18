using businesslayer.concrete;
using dataaccesslayer.concrete;
using dataaccesslayer.entityframework;
using entitylayer.concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminMessageController : Controller
	{
		WriterMessageManager writerMessageManager = new WriterMessageManager (new EfWriterMessagedal());
		public IActionResult ReceiverMessageList()
		{
			string p;
			p = "admin@gmail.com";
			var values = writerMessageManager.GetListReceiverMessage(p);
			return View(values);
		}
		public IActionResult SenderMessageList()
		{
			string p;
			p = "admin@gmail.com";
			var values = writerMessageManager.GetListSenderMessage(p);
			return View(values);
		}
        public IActionResult AdminMessageDetails(int id)
        {
            var values = writerMessageManager.TGetByID(id);
            return View(values);
        }
        public IActionResult AdminMessageDelete(int id)
        {
			string p;
			p = "admin@gmail.com";
            var values = writerMessageManager.TGetByID(id);
			if (values.Receiver == p)
			{
				writerMessageManager.Tdelete(values);
				return RedirectToAction("ReceiverMessageList");
			}
			else
			{
                writerMessageManager.Tdelete(values);
                return RedirectToAction("SenderMessageList");
            }
        }
        [HttpGet]
        public IActionResult AdminMessageSend()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminMessageSend(WriterMessage p)
        {
			p.Sender = "admin@gmail.com";
			p.SenderName = "Admin";
			p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
			context c = new context();
			var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
			p.ReceiverName = usernamesurname;
			writerMessageManager.Tadd(p);
            return RedirectToAction("SenderMessageList");
        }
    }
}
