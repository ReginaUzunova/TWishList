using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using AutoMapper;
using TWishList.Services.Mapping;
using TWishList.Services.Models;

namespace TWishList.Web.InputModels
{
    public class CompanyRequestInputModel : IMapTo<CompanyRequestServiceModel>, IHaveCustomMappings
    {
        [Required(ErrorMessage = "Name is required!")]
        [Display(Name = "Company Name")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "\"{0}\" should be between {2} and {1} symbols.")]
        public string CompanyName { get; set; }

        [Required]
        [Display(Name = "Company Unique Identifier")]
        public string CompanyUniqueIdentifier { get; set; }

        [Required]
        [Display(Name = "Company Liable Person")]
        public string CompanyLiablePerson { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Company Email")]
        public string CompanyEmail { get; set; }

        [Required]
        [Display(Name = "Company Phone Number")]
        [Phone]
        public string CompanyPhoneNumber { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string City { get; set; }

        [Display(Name = "Company Website")]
        public string CompanyWebsite { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration
                .CreateMap<CompanyRequestInputModel, CompanyRequestServiceModel>()
                .ForMember(destination => destination.Country,
                            opts => opts.MapFrom(origin => new CountryServiceModel
                            {
                                Name = origin.Country
                            }));
        }
    }
}
