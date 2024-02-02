using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAcesss.Data
{
    public class TextInImage
    {
        [Key]
        public int Id { get; set; }

        public bool? IsImageName { get; set; }

        public bool? WPOfProduct { get; set; }

        public bool? DateAndShift { get; set; }

        public bool? IsManufacturer { get; set; }

        public bool? ManufacturingPlantAndLine { get; set; }

        public bool? SiteName { get; set; }

        public bool? CustomerName { get; set; }

        public bool? CriteriaName { get; set; }

        public int SoftwareId { get; set; }

        [ForeignKey("SoftwareId")]
        public virtual CompanySoftware CompanySoftware { get; set; }

        public int? PDId { get; set; }

        [ForeignKey("PDId")]
        public ProjectDetails ProjectDetails { get; set; }
    }
}
