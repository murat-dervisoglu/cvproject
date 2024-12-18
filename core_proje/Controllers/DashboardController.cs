using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.Controllers
{
    [Authorize(Roles ="Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Anasayfa";
            ViewBag.v2 = "Tablolar";
            ViewBag.v3 = "İstatistikler";
            return View();
        }
    }
}
