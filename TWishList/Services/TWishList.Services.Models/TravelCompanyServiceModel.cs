namespace TWishList.Services.Models
{
    using System.Collections.Generic;
    using TWishList.Data.Models;
    using TWishList.Data.Models.Identity;
    using TWishList.Services.Mapping;

    public class TravelCompanyServiceModel : IMapFrom<TravelCompany>, IMapTo<TravelCompany>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string UniqueIdentifier { get; set; }

        public string LiablePerson { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public int CountryId { get; set; }
        public CountryServiceModel Country { get; set; }

        public string City { get; set; }

        public string CompanyWebsite { get; set; }

        public int RequestId { get; set; }
        public CompanyRequestServiceModel CompanyRequest { get; set; }

        public ApplicationUserServiceModel User { get; set; }

        public HashSet<OfferServiceModel> Offers { get; set; }
    }
}
