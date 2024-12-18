using businesslayer.concrete;
using dataaccesslayer.entityframework;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.ViewComponents.Skill
{
    public class SkillList:ViewComponent
    {
        SkillMenager skillMenager = new SkillMenager(new efskilldal());
        public IViewComponentResult Invoke()
        {
            var values = skillMenager.TGetList();
            return View(values);
        }

    }
}
