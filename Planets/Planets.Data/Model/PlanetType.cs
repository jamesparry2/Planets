using System.ComponentModel.DataAnnotations.Schema;

namespace Planets.Data.Model
{
    public class PlanetType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string TypePlanet { get; set; }
    }
}
