using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets.Data.Model
{
    public class Planet
    {
        // This is done with EF so it autoincrements on the Model design.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long PlanetId { get; set; }

        public string Type { get; set; }

        public string PlanetName { get; set; }
    }
}
