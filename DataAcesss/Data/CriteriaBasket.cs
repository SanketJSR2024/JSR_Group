using System.ComponentModel.DataAnnotations;

namespace DataAcesss.Data
{
    public class CriteriaBasket
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
