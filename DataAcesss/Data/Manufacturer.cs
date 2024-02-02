using System.ComponentModel.DataAnnotations;

namespace DataAcesss.Data
{
    public class Manufacturer
    {
        [Key]
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerMiddleName { get; set; }
        public string OwnerLastName { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public string Website { get; set; }
    }
}
