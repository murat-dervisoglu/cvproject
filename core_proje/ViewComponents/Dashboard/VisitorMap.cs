using Microsoft.AspNetCore.Mvc;

namespace core_proje.ViewComponents.Dashboard
{
	public class VisitorMap:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
