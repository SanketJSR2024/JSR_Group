using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class CompanyDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter company name.")]
        public string CompanyName { get; set; }

        public string Description { get; set; }

        public string OwnerName { get; set; }
    }
}
