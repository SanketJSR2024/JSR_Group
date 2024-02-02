using System;
using System.ComponentModel.DataAnnotations;

namespace DataAcesss.Data
{
    public class SoftwareVersion
    {
        [Key]
        public int Id { get; set; }

        public string VersionName { get; set; }

        public DateTime? PublishDate { get; set; }

        public bool? IsActive { get; set; }
    }
}
