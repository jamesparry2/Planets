using System.ComponentModel.DataAnnotations.Schema;

namespace Planets.Data.Model
{
    public class Image
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImageId { get; set; }
        public string ImageUriPath { get; set; }
    }
}
