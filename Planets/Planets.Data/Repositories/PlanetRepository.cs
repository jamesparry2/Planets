using Planets.Data.DataContextLayer;
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
            var planetToReturn = new Planet();

            using(var context = new PlanetContext())
            {
                context.Planets.Add(new Planet()
                {
                    PlanetName = "Jupiter",
                    Type = "Gas Giant"
                });
                context.SaveChanges();
            }
 
            return new Planet
            {
                PlanetId = 22,
                PlanetName = "Earth",
            };
        }
    }
}
