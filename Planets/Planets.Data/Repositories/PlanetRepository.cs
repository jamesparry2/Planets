using Planets.Data.DataContextLayer;
using Planets.Data.Model;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Planets.Data.Repositories
{
    public interface IPlanetRepository
    {
        IEnumerable<Planet> GetPlanets();
        Planet GetPlanetById(long id);
        int AddNewPlanet(Planet planet);
        int DeleteNewPlanet(Planet planet);
        int UpdatePlanet(Planet planet);
    }

    public class PlanetRepository : IPlanetRepository
    {
        public IEnumerable<Planet> GetPlanets()
        {
            var listOfPlanets = new List<Planet>();
            using(var context = new PlanetContext())
            {
                var response = context.Planets.SqlQuery("SELECT * FROM Planets").ToList();
            }
            return listOfPlanets;
        }

        public Planet GetPlanetById(long id)
        {
            var planetToReturn = new Planet();
            using(var context = new PlanetContext())
            {
                planetToReturn = context.Planets.Find(id);
            }
            return planetToReturn;
        }

        public int AddNewPlanet(Planet planet)
        {
            var rowsAffected = 0;
            using(var context = new PlanetContext())
            {
                context.Planets.Add(planet);
                rowsAffected = context.SaveChanges();
            }
            return rowsAffected;
        }

        public int DeleteNewPlanet(Planet planet)
        {
            var rowsAffected = 0;
            using (var context = new PlanetContext())
            {
                context.Planets.Remove(planet);
                rowsAffected = context.SaveChanges();
            }
            return rowsAffected;
        }

        public int UpdatePlanet(Planet planet)
        {
            var rowsAffected = 0;
            using(var context = new PlanetContext())
            {
                var sqlParams = new List<SqlParameter>
                {
                    new SqlParameter("@TypeId", planet.Type.Id),
                    new SqlParameter("@ImageId", planet.Image.ImageId),
                    new SqlParameter("@PlanetName", planet.PlanetName),
                    new SqlParameter("@PlanetId", planet.PlanetId)
                };

                var sqlQueryToExecute = @"
                    UPDATE Planets
                    SET 
                        Type_Id = @TypeId,
                        Image_ImageId = @ImageId,
                        PlanetName = @PlanetName
                    WHERE PlanetId = @PlanetId;
                ";

                context.Planets.SqlQuery(sqlQueryToExecute, sqlParams);
                rowsAffected = context.SaveChanges();
            }
            return rowsAffected;
        }
    }
}
