namespace TWishList.Services.Models
{
    using TWishList.Data.Common.Models;
    using TWishList.Data.Models;
    using TWishList.Services.Mapping;

    public class CompanyRequestServiceModel : IMapFrom<CompanyRequest>, IMapTo<CompanyRequest>
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
    }
}
