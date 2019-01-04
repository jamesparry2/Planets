using System.Collections.Generic;
using Planets.Data.Model;
using Planets.Data.Repositories;

namespace Planets.Common.Service
{
    public interface IPlanetService
    {
        IEnumerable<Planet> GetAllPlanets();
        Planet GetPlanetById(long id);
        int AddNewPlanet(Planet planet);
        int DeleteNewPlanet(Planet planet);
        int UpdatePlanet(Planet planet);
    }

    public class PlanetService : IPlanetService
    {
        private readonly IPlanetRepository _planetRepository;

        public PlanetService(IPlanetRepository planetRepository)
        {
            _planetRepository = planetRepository;
        }

        public IEnumerable<Planet> GetAllPlanets()
        {
            return _planetRepository.GetPlanets();
        }

        public Planet GetPlanetById(long id)
        {
            return _planetRepository.GetPlanetById(id);
        }

        public int AddNewPlanet(Planet planet)
        {
            return _planetRepository.AddNewPlanet(planet);
        }

        public int DeleteNewPlanet(Planet planet)
        {
            return _planetRepository.DeleteNewPlanet(planet);
        }

        public int UpdatePlanet(Planet planet)
        {
            return _planetRepository.UpdatePlanet(planet);
        }
    }
}
