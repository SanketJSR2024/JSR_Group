using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class ImageProcessReqDTO
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

        public string TextInImage { get; set; }

        public bool? IsImageFullScreen { get; set; }

        public bool? IsSeverityScore { get; set; }

        public string AcceptanceCriteria { get; set; }

        public int? PDId { get; set; }
    }
}
