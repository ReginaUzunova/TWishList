namespace TWishList.Services.Models
{
    using System.Collections.Generic;
    using TWishList.Data.Models;
    using TWishList.Services.Mapping;


    public class CountryServiceModel : IMapFrom<Country>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public HashSet<DestinationServiceModel> Destinations { get; set; }

        public HashSet<DesirableDestinationServiseModel> DesirableDestinations { get; set; }
    }
}
