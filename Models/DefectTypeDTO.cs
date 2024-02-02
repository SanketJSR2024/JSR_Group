using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class DefectTypeDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Enter your value.")]
        public string Value { get; set; }

        public int? SoftwareId { get; set; }
    }
}
