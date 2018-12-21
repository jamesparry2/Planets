using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planets.Data.Model;
using Planets.Data.Repositories;

namespace Planets.Common.Service
{
    public interface IPlanetService
    {
        Planet GetPlanetById(long id);
    }

    public class PlanetService : IPlanetService
    {
        private readonly IPlanetRepository _planetRepository;

        public PlanetService(IPlanetRepository planetRepository)
        {
            _planetRepository = planetRepository;
        }

        public Planet GetPlanetById(long id)
        {
            return _planetRepository.GetPlanetById(id);
        }
    }
}
