using businesslayer.concrete;
using dataaccesslayer.entityframework;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.ViewComponents.Experience
{
	public class ExperienceList: ViewComponent
	{
		ExperienceManager experiencemenager = new ExperienceManager(new efexperiencedal());

		public IViewComponentResult Invoke()
		{
			var values = experiencemenager.TGetList();
			return View(values);
		}

	}
}
