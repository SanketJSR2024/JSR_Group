using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAcesss.Data
{
    public class Site
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int SoftwareId { get; set; }

        [ForeignKey("SoftwareId")]
        public virtual CompanySoftware CompanySoftware { get; set; }
    }
}
