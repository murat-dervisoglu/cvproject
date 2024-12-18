using businesslayer.Abstract;
using businesslayer.concrete;
using dataaccesslayer.entityframework;
using Microsoft.AspNetCore.Mvc;

namespace core_proje.ViewComponents.Dashboard
{
	public class ToDoListPanel : ViewComponent
	{
		ToDoListManager toDoListManager = new ToDoListManager(new EFToDoListDal());

		public IViewComponentResult Invoke()
		{
			
			var values = toDoListManager.TGetList();

			return View(values);
		}
	}
}
