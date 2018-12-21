using System.Web.Mvc;
using Planets.Common.Service;
using Planets.Data.Repositories;
using Unity;
using Unity.Mvc5;

namespace Planets
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IPlanetRepository, PlanetRepository>();
            container.RegisterType<IPlanetService, PlanetService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}