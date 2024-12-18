using businesslayer.Abstract;
using businesslayer.concrete;
using dataaccesslayer.entityframework;
using entitylayer.concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.Controllers
{
    [Authorize (Roles ="Admin")]
    public class ExperienceController : Controller
    {
        public readonly IExperienceService _experienceManager;

        public ExperienceController(IExperienceService experienceService)
        {
            _experienceManager = experienceService;
        }

       // ExperienceManager experienceMenager = new ExperienceManager(new efexperiencedal());

        public IActionResult Index()
        {
            var values = _experienceManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(experience experience)
        {
            _experienceManager.Tadd(experience);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteExperience(int id)
        {
            var values = _experienceManager.TGetByID(id);
            _experienceManager.Tdelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            var values = _experienceManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditExperience(experience experience)
        {
            _experienceManager.Tupdate(experience);
            return RedirectToAction("Index");
        }

    }
}
