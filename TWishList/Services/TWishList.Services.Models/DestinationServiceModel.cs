namespace TWishList.Services.Models
{
    using System.Collections.Generic;
    using TWishList.Data.Models;
    using TWishList.Services.Mapping;


    public class DestinationServiceModel : IMapFrom<Destination>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public int CountryId { get; set; }
        public CountryServiceModel Country { get; set; }

        public HashSet<HotelServiceModel> Hotels { get; set; }

        public HashSet<OfferServiceModel> Offers { get; set; }
    }
}
