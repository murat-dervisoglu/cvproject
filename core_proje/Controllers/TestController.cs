using Microsoft.AspNetCore.Mvc;

namespace core_proje.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
