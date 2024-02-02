using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAcesss.Data
{
    public class CompanySoftware
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CompanyId { get; set; }

        [Required]
        public string CompanySectionName { get; set; }

        [Required]
        public string SoftwareKey { get; set; }

        public bool? IsActive { get; set; }

        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }
    }
}
