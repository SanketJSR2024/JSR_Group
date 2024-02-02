using System.ComponentModel.DataAnnotations.Schema;

namespace DataAcesss.Data
{
    public class SoftwareVersionFeatures
    {
        public int Id { get; set; }

        public int? VersionId { get; set; }

        public int? FeatureId { get; set; }

        public bool? IsActive { get; set; }

        [ForeignKey("FeatureId")]
        public virtual Feature Feature { get; set; }

        [ForeignKey("VersionId")]
        public virtual SoftwareVersion SoftwareVersion { get; set; }
    }
}
