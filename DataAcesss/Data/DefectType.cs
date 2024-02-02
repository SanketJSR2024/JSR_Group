using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAcesss.Data
{
    public class DefectType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Value { get; set; }

        [Required]
        public int? SoftwareId { get; set; }

        [ForeignKey("SoftwareId")]
        public CompanySoftware CompanySoftware { get; set; }
    }
}
