using businesslayer.concrete;
using dataaccesslayer.entityframework;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.ViewComponents.Testimonial
{
    public class TestimonialList: ViewComponent
    {
        TestimonialMenager testimonialmenager = new TestimonialMenager(new eftestimonialdal());

        public IViewComponentResult Invoke()
        {
            var value = testimonialmenager.TGetList();
            return View(value);
        }

    }
}
