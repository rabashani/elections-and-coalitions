using System.Web.Mvc;

namespace Elections.Web.UI.Views.Shared
{
	public class LoginController : Controller
	{
		[RequireHttps]
		public ActionResult Index()
		{
			return View();
		}
	}
}