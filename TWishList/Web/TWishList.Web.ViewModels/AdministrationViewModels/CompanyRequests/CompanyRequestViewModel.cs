using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TWishList.Services.Mapping;
using TWishList.Services.Models;

namespace TWishList.Web.ViewModels.AdministrationViewModels.CompanyRequests
{
    public class CompanyRequestViewModel : IMapTo<CompanyRequestServiceModel>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string CompanyName { get; set; }

        public string CompanyUniqueIdentifier { get; set; }

        public string CompanyLiablePerson { get; set; }

        public string CompanyEmail { get; set; }

        public string CompanyPhoneNumber { get; set; }
       
        public int CountryId { get; set; }
        public CountryServiceModel Country { get; set; }

        public string City { get; set; }

        public string CompanyWebsite { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration
                .CreateMap<CompanyRequestServiceModel, CompanyRequestViewModel>()
                .ForMember(destination => destination.CountryId,
                            opts => opts.MapFrom(origin => origin.CountryId));
        }
    }
}
