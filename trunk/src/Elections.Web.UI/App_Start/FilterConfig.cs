using System.Web.Mvc;
using Platform.Client.Configuration;
using Elections.Common.Filters;
using Elections.Domain.Auth;
using Elections.Domain.Context;
using Elections.Web.UI.Filters;

namespace Elections.Web.UI.App_Start
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			var container = IoCActivator.Container;
			
			filters.Add(new HandleErrorAttribute());
			filters.Add(new TokenExtractingFilter(container.Resolve<IPlatformTokenDistributer>()));
			filters.Add(new TokenPersistenceFilter(container.Resolve<IApplicationSettings>()));
			filters.Add(new DefaultExceptionHandlingFilter(container.Resolve<IExceptionHandler>()));
			filters.Add(new RequestDataExtractorFilter(container.Resolve<IRequestContextProvider>(),
														container.Resolve<IRequestContentProvider>(),
														container.Resolve<ILoggingContext>()));
		}
	}
}