using businesslayer.concrete;
using dataaccesslayer.entityframework;
using entitylayer.concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class TestimonialController : Controller
	{
		TestimonialMenager testimonialMenager = new TestimonialMenager(new eftestimonialdal());
		public IActionResult Index()
		{
			var values = testimonialMenager.TGetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddTestimonial()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddTestimonial(testimonial p)
		{
			testimonialMenager.Tadd(p);
			return RedirectToAction("Index");
		}
		public IActionResult DeleteTestimonial(int id)
		{
			var values = testimonialMenager.TGetByID(id);
			testimonialMenager.Tdelete(values);
			return RedirectToAction("Index");
		}
        [HttpGet]
        public IActionResult EditTestimonial(int id)
        {
            var values = testimonialMenager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditTestimonial(testimonial testimonial)
        {
            testimonialMenager.Tupdate(testimonial);
            return RedirectToAction("Index");
        }

    }
}
