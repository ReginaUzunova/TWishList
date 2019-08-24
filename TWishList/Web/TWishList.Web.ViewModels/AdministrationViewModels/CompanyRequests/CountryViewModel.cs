using System;
using System.Collections.Generic;
using System.Text;
using TWishList.Services.Mapping;
using TWishList.Services.Models;

namespace TWishList.Web.ViewModels.AdministrationViewModels.CompanyRequests
{
    public class CountryViewModel : IMapFrom<CountryServiceModel>
    {
        public string Name { get; set; }

        public HashSet<DestinationServiceModel> Destinations { get; set; }

        public HashSet<DesirableDestinationServiseModel> DesirableDestinations { get; set; }
    }
}
