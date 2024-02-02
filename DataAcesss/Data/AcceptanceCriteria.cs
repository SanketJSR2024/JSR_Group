using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAcesss.Data
{
    public class AcceptanceCriteria
    {
        [Key]
        public int Id { get; set; }

        public int? DefectTypeId { get; set; }

        public int? PDId { get; set; }

        public string UnitOfMeasurement { get; set; }

        public string AcceptableMeasurement { get; set; }

        public string QuantityAcceptable { get; set; }

        [ForeignKey("PDId")]
        public ProjectDetails ProjectDetails { get; set; }

        [ForeignKey("DefectTypeId")]
        public DefectType DefectType { get; set; }
    }
}
