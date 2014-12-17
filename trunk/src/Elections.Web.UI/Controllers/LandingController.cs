using System.Configuration;
using System.Web.Mvc;
using Platform.Client.Configuration;
using Elections.Web.UI.Models;

namespace Elections.Web.UI.Controllers
{
	public class LandingController : Controller
	{
		private readonly IApplicationSettings _applicationSettings;
		private readonly IPlatformSettings _platformSettings;

		public LandingController(IApplicationSettings applicationSettings, IPlatformSettings platformSettings)
		{
			_applicationSettings = applicationSettings;
			_platformSettings = platformSettings;
		}

		public ActionResult Index()
		{
			var model = new LandingModel();

			try
			{
				model.AppId = _applicationSettings.AppId;
				model.ShopYourWayUrl = _platformSettings.SywWebSiteUrl;
			}
			catch (ConfigurationErrorsException)
			{
				model.DisplayProperConfiguraionMessage = true;
			}

			return View(model);
		}
	}
}