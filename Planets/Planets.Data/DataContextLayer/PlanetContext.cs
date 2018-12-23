using Planets.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets.Data.DataContextLayer
{
    public class PlanetContext : DbContext
    {
        public PlanetContext() : base("PlanetContext")
        {
            Database.SetInitializer<PlanetContext>(new DropCreateDatabaseIfModelChanges<PlanetContext>());
        }

        public DbSet<Planet> Planets { get; set; }

    }
}
