using Planets.Data.Model;
using System.Data.Entity;

namespace Planets.Data.DataContextLayer
{
    public class PlanetContext : DbContext
    {
        public PlanetContext() : base("PlanetContext")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<PlanetContext>());
        }

        public DbSet<Planet> Planets { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<PlanetType> PlanetTypes { get; set; }

    }
}
