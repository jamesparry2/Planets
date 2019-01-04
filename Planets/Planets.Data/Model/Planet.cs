using System.ComponentModel.DataAnnotations.Schema;

namespace Planets.Data.Model
{
    public class Planet
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long PlanetId { get; set; }
        public PlanetType Type { get; set; }
        public string PlanetName { get; set; }
        public Image Image { get; set; }
    }
}
