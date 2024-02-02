using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataAcesss.Data
{
    public class ImageProcessReq
    {
        [Key]
        public int Id { get; set; }

        public int? SoftwareId { get; set; }

        public bool? IsExposureSet { get; set; }

        public string ExposureSetValue { get; set; }

        public bool? IsDefectMarking { get; set; }

        public bool? IsPerspectiveCorrection { get; set; }

        public bool? IsRename { get; set; }

        public string RenameWith { get; set; }

        public bool? IsTextInImage { get; set; }

        public string TextInImage { get; set;}

        public bool? IsImageFullScreen { get; set; }

        public bool? IsSeverityScore { get; set; }

        public string AcceptanceCriteria { get; set; }

        public int? PDId { get; set; }

        [ForeignKey("PDId")]
        public ProjectDetails ProjectDetails { get; set; }

        [ForeignKey("SoftwareId")]
        public virtual CompanySoftware CompanySoftware { get; set; }
    }
}
