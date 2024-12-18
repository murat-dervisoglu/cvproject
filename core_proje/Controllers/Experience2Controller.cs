using businesslayer.concrete;
using dataaccesslayer.entityframework;
using entitylayer.concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace core_proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class Experience2Controller : Controller
	{
		ExperienceManager experienceManager = new ExperienceManager(new efexperiencedal());
		public IActionResult Index()
		{

			return View();
		}
		public IActionResult ListExperience()
		{
			var values = JsonConvert.SerializeObject(experienceManager.TGetList());
			return Json(values);
		}

		[HttpPost]
		public IActionResult AddExperience(experience p)
		{
			experienceManager.Tadd(p);
			var values = JsonConvert.SerializeObject(p);
			return Json(values);
		}
		public IActionResult GetByID(int experienceId)
		{
			var v = experienceManager.TGetByID(experienceId);
			var values = JsonConvert.SerializeObject(v);
			return Json(values);
		}
		public IActionResult DeleteExperience(int id)
		{
			var v = experienceManager.TGetByID(id);
			experienceManager.Tdelete(v);
			return NoContent();
		}
		[HttpPost]
		public IActionResult UpdateExperience([FromBody] experience p)
		{
			var findvalue = experienceManager.TGetByID(p.experienceId);

			if (findvalue != null)
			{
				findvalue.name = p.name;
				findvalue.date = p.date;
				findvalue.imageUrl = p.imageUrl;
				findvalue.description = p.description;
				experienceManager.Tupdate(findvalue);
				var val = JsonConvert.SerializeObject(findvalue);

				return Json(val);
			}
			return NoContent();
		}

	}
}
