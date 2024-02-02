using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class SiteDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter site name.")]
        public string Name { get; set; }

        public int SoftwareId { get; set; }
    }
}
