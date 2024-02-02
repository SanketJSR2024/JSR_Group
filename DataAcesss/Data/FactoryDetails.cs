using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAcesss.Data
{
    public class FactoryDetails
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int? DefectTypeId { get; set; }

        [Required]
        public string UnitOfMeasurement { get; set; }

        [Required]
        public string AcceptableMeasurement { get; set; }

        [Required]
        public string QuantityAcceptablePerModule { get; set; }

        [Required]
        public int? SoftwareId { get; set; }

        [Required]
        public int? AccCriteriaId { get; set; }

        [ForeignKey("SoftwareId")]
        public CompanySoftware CompanySoftware { get; set; }

        [ForeignKey("AccCriteriaId")]
        public AcceptanceCriteria AcceptanceCriteria { get; set; }

    }
}
