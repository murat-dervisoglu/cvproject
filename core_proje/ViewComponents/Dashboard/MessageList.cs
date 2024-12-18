using businesslayer.Abstract;
using businesslayer.concrete;
using dataaccesslayer.entityframework;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.ViewComponents.Dashboard
{
    public class MessageList:ViewComponent
    {
		public IViewComponentResult Invoke()
		{
			string p = "admin@gmail.com";
			WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessagedal());
			var values = writerMessageManager.GetListReceiverMessage(p).OrderByDescending(x => x.WriterMessageID).Take(6).ToList();
			return View(values);
		}
	}
}
