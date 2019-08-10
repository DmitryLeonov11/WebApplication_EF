using DependencyInjection;
using DependencyInjection.Modules;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace WebApplication1
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            Register<DomainModule>(container);
            Register<InfrastructureModule>(container);
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

        public static void Register<T>(IUnityContainer container) where T: IModule , new()
        {
            new T().Register(container);
        }
    }
}