using System.Web.Mvc;
using Planets.Common.Service;
using Planets.Data.Repositories;
using Unity;
using Unity.Lifetime;
using Unity.Mvc5;

namespace Planets
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IPlanetRepository, PlanetRepository>(new TransientLifetimeManager());
            container.RegisterType<IPlanetService, PlanetService>(new TransientLifetimeManager());

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}