using Planets.Data.Model;

namespace Planets.Data.Repositories
{
    public interface IPlanetRepository
    {
        Planet GetPlanetById(long id);
    }

    public class PlanetRepository : IPlanetRepository
    {
        public Planet GetPlanetById(long id)
        {
            return new Planet
            {
                PlanetId = 22,
                PlanetName = "Earth",
            };
        }
    }
}
