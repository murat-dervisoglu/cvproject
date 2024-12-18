using businesslayer.concrete;
using dataaccesslayer.entityframework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace core_proje.ViewComponents.SocialMedia
{
	public class SocialMediaList : ViewComponent
	{
		SocialMediaManager socialMediaManager = new SocialMediaManager(new efsocialmediadal());
		public IViewComponentResult Invoke()
		{
			var values = socialMediaManager.TGetList();
			return View(values);
		}
	}
}
