using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAcesss.Data
{
    public class CompanyCustomer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public int SoftwareId { get; set; }

        public bool? IsActive { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        [ForeignKey("SoftwareId")]
        public virtual CompanySoftware CompanySoftware { get; set; }
    }
}
