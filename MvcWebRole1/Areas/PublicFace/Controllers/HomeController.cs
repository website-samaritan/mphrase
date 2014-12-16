using System.Web.Mvc;

namespace MvcWebRole1.Areas.PublicFace.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}
