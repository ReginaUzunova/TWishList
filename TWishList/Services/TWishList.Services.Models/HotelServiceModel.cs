namespace TWishList.Services.Models
{
    using TWishList.Data.Models;
    using TWishList.Services.Mapping;

    public class HotelServiceModel : IMapFrom<Hotel>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Rating { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public int DestinationId { get; set; }
        public DestinationServiceModel Destination { get; set; }
    }
}
