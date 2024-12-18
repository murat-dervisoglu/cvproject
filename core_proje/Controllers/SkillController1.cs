using businesslayer.concrete;
using dataaccesslayer.entityframework;
using entitylayer.concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SkillController1 : Controller
    {
        SkillMenager skillmenager = new SkillMenager(new efskilldal());
        public IActionResult Index()
        {
            var values = skillmenager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult Addskill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Addskill(skill skill)
        {
            skillmenager.Tadd(skill);
            return RedirectToAction("index");
        }
        public IActionResult DeleteSkill(int id)
        {
            var values = skillmenager.TGetByID(id);
            skillmenager.Tdelete(values);
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Editskill(int id)
        {
            var values = skillmenager.TGetByID(id); 
            return View(values);
        }
        [HttpPost]
        public IActionResult Editskill(skill skill)
        {
            skillmenager.Tupdate(skill);
            return RedirectToAction("index");
        }

    }
}
