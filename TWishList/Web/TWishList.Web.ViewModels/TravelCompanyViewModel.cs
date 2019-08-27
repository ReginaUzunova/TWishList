using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TWishList.Services.Mapping;
using TWishList.Services.Models;

namespace TWishList.Web.ViewModels
{
    public class TravelCompanyViewModel : IMapTo<TravelCompanyServiceModel>, IHaveCustomMappings
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

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration
                .CreateMap<TravelCompanyServiceModel, TravelCompanyViewModel>()
                .ForMember(destination => destination.CountryId,
                            opts => opts.MapFrom(origin => origin.CountryId));
        }
    }
}
