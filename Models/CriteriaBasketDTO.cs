using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class CriteriaBasketDTO
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
