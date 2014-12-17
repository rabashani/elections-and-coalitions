using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System.Web.Mvc;

namespace Elections.Web.UI.App_Start.IoC
{
	public class ApiControllersInstaller : IWindsorInstaller
	{
		public void Install(IWindsorContainer container, IConfigurationStore store)
		{
			container.Register(Classes.FromThisAssembly().BasedOn<IController>().LifestyleTransient());
			container.Register(Component.For<Platform.Client.Common.Context.IContextProvider>().ImplementedBy<Platform.Client.Common.Context.HttpContextProvider>());
		}
	}
}