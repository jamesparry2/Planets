using System.Web.Http;
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

            container.RegisterType<IImagesRepository, ImagesRepository>(new TransientLifetimeManager());
            container.RegisterType<IImageService, ImageService>(new TransientLifetimeManager());

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}