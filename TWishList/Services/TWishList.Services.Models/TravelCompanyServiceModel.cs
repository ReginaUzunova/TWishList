namespace TWishList.Services.Models
{
    using System.Collections.Generic;
    using TWishList.Data.Models;
    using TWishList.Services.Mapping;

    public class TravelCompanyServiceModel : IMapFrom<TravelCompany>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string UniqueIdentifier { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public int CountryId { get; set; }
        public CountryServiceModel Country { get; set; }

        public string City { get; set; }

        public string CompanyWebsite { get; set; }

        public HashSet<OfferServiceModel> Offers { get; set; }
    }
}
