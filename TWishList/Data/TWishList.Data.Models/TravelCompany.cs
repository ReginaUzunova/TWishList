namespace TWishList.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using TWishList.Data.Common.Models;

    public class TravelCompany : BaseModel<int>
    {
        public TravelCompany()
        {
            this.Offers = new HashSet<Offer>();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public string UniqueIdentifier { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

        [Required]
        public string City { get; set; }

        public string CompanyWebsite { get; set; }

        public virtual ICollection<Offer> Offers { get; set; }
    }
}
