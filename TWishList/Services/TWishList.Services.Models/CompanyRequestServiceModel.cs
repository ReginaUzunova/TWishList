namespace TWishList.Services.Models
{
    using TWishList.Data.Common.Models;
    using TWishList.Data.Models;
    using TWishList.Services.Mapping;

    public class CompanyRequestServiceModel : IMapFrom<CompanyRequest>, IMapTo<CompanyRequest>
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public ApplicationUserServiceModel User { get; set; }

        public string CompanyName { get; set; }

        public string CompanyUniqueIdentifier { get; set; }

        public string CompanyLiablePerson { get; set; }

        public string CompanyEmail { get; set; }

        public string CompanyPhoneNumber { get; set; }

        public int CountryId { get; set; }
        public CountryServiceModel Country { get; set; }

        public string City { get; set; }

        public string CompanyWebsite { get; set; }
    }
}
