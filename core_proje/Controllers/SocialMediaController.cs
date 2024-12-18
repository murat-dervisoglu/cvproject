using businesslayer.concrete;
using dataaccesslayer.entityframework;
using entitylayer.concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SocialMediaController : Controller
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new efsocialmediadal());
        public IActionResult Index()
        {
            var values = socialMediaManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSocialMedia(socialmedia p )
        {
            p.status=true;
            socialMediaManager.Tadd(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSocialMedia(int id)
        {
            var values= socialMediaManager.TGetByID(id);
            socialMediaManager.Tdelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditSocialMedia(int id)
        {
            var values= socialMediaManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditSocialMedia(socialmedia p)
        {
            socialMediaManager.Tupdate(p);
            return RedirectToAction("Index");
        }
    }
}
