using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAcesss.Data
{
    public class ProjectDetails
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int SoftwareId { get; set; }

        [Required]
        public string WP_Product { get; set; }

        public DateTime Date { get; set; }

        public string Shift { get; set; }

        public string ManufacturerName { get; set; }

        public string ManufacturingBy { get; set; }

        public int? CustomerId { get; set; }

        public string CriteriaBasket { get; set; }

        public string ModuleMatrix { get; set; }

        public string ElementWith { get; set; }

        public int CellSize { get; set; }

        public string SiteName { get; set; }

        [ForeignKey("CustomerId")]
        public virtual CompanyEmployee Customer { get; set; }

        [ForeignKey("SoftwareId")]
        public virtual CompanySoftware CompanySoftware { get; set; }

    }
}
