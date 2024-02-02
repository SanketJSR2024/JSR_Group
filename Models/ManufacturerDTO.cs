using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class ManufacturerDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter company name.")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Please enter company owner first name.")]
        public string OwnerFirstName { get; set; }

        [Required(ErrorMessage = "Please enter company owner middle name.")]
        public string OwnerMiddleName { get; set; }

        [Required(ErrorMessage = "Please enter company owner last name.")]
        public string OwnerLastName { get; set; }

        [Required(ErrorMessage = "Please enter company owner email name.")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Please enter company owner mobile name.")]
        public string MobileNo { get; set; }

        [Required(ErrorMessage = "Please enter company owner website.")]
        public string Website { get; set; }

    }
}
