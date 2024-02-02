using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAcesss.Data
{
    public class ImageProcessData
    {
        [Key]
        public int Id { get; set; }

        public int? PDId { get; set; }

        public string ModuleSerialNo { get; set; }

        public string ModuleLocation { get; set; }

        [Required]
        public string ImageName { get; set; }

        public string ImageResult { get; set; }

        public string SeverityScore { get; set; }

        public string ModuleCountName { get; set; }

        public string DefectData { get; set; }

        public int? Crack { get; set; }

        public int? TreeCrack { get; set; }

        public int? DeadCell { get; set; }

        public int? DarkArea { get; set; }

        public int? OpenSoldering { get; set; }

        public int? FingerInteruption { get; set; }

        public int? BackSheetCut { get; set; }

        public int? EmployeeId { get; set; }

        public int? SoftwareId { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool? IsSuccess { get; set; }

        [ForeignKey("SoftwareId")]
        public CompanySoftware CompanySoftware { get; set; }

        [ForeignKey("EmployeeId")]
        public CompanyEmployee CompanyEmployee { get; set; }

        [ForeignKey("PDId")]
        public ProjectDetails ProjectDetails { get; set; }

    }
}
