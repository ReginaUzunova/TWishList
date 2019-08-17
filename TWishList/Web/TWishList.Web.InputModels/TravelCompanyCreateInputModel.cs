namespace TWishList.Web.InputModels
{
    using System.ComponentModel.DataAnnotations;

    public class TravelCompanyCreateInputModel
    {
        [Required(ErrorMessage = "Name is required!")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Name \"{0}\" should be between {2} and {1} symbols.")]
        public string Name { get; set; }

        [Required]
        public string UniqueIdentifier { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string City { get; set; }

        public string CompanyWebsite { get; set; }
    }
}
