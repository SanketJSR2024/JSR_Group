using System.ComponentModel.DataAnnotations;

namespace DataAcesss.Data
{
    public class Feature
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
