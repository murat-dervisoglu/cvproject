using businesslayer.concrete;
using dataaccesslayer.entityframework;
using dataaccesslayer.concrete;
using entitylayer.concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using Microsoft.DiaSymReader;

namespace core_proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/Message")]
    public class MessageController : Controller
    {
        WriterMessageManager writermessageManager= new WriterMessageManager(new EfWriterMessagedal());

        private readonly UserManager<WriterUser> _userManager;

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        [Route("")]
        [Route("RecieverMessage")]
        public async Task< IActionResult> RecieverMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList  = writermessageManager.GetListReceiverMessage(p);
            return View(messageList);
        }
        [Route("")]
        [Route("SenderMessage")]
        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = writermessageManager.GetListSenderMessage(p);
            return View(messageList);
        }
        [Route("MessageDetails/{id}")]
        public IActionResult MessageDetails(int id)
        {
            WriterMessage message = writermessageManager.TGetByID(id);
            return View(message);
        }
        [Route("RecieverMessageDetails/{id}")]
        public IActionResult RecieverMessageDetails(int id)
        {
            WriterMessage message = writermessageManager.TGetByID(id);
            return View(message);
        }
        [HttpGet]
        [Route("")]
        [Route("SendMessage")]
        public IActionResult SendMessage()
        {
        return View();
        }
        [HttpPost]
        [Route("")]
        [Route("SendMessage")]
        public async Task <IActionResult> SendMessage(WriterMessage p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name = values.Name+ " "+ values.Surname;
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Sender = mail;
            p.SenderName= name;
            context c= new context();
            var usernamesurname = c.Users.Where(x => x.Email==p.Receiver).Select(y => y.Name+ " "+y.Surname).FirstOrDefault();
            p.ReceiverName = usernamesurname;

            writermessageManager.Tadd(p);
            return RedirectToAction("SenderMessage");
        }
    }
}
