using System.ComponentModel.DataAnnotations;

namespace DataAcesss.Data
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string OwnerName { get; set; }
    }
}
