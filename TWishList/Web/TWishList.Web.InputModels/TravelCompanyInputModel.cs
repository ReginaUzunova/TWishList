namespace TWishList.Web.InputModels
{
    using AutoMapper;
    using System.ComponentModel.DataAnnotations;
    using TWishList.Services.Mapping;
    using TWishList.Services.Models;

    public class TravelCompanyInputModel : IMapTo<TravelCompanyServiceModel>, IHaveCustomMappings
    {
        [Required(ErrorMessage = "Name is required!")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "\"{0}\" should be between {2} and {1} symbols.")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Unique Identifier")]
        public string UniqueIdentifier { get; set; }

        [Required]
        [Display(Name = "Liable Person")]
        public string LiablePerson { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string City { get; set; }

        [Display(Name = "Company Website")]
        public string CompanyWebsite { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration
                .CreateMap<TravelCompanyInputModel, TravelCompanyServiceModel>()
                .ForMember(destination => destination.Country,
                            opts => opts.MapFrom(origin => new CountryServiceModel
                            {
                                Name = origin.Country
                            }));
        }
    }
}
