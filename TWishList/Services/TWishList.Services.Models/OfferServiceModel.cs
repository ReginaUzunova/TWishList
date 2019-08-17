namespace TWishList.Services.Models
{
    using System;
    using TWishList.Data.Models;
    using TWishList.Data.Models.Enums;
    using TWishList.Services.Mapping;

    public class OfferServiceModel : IMapFrom<Offer>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public DateTime ActiveUntil { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int CategoryId { get; set; }
        public OfferCategoryServiceModel Category { get; set; }

        public int Nights { get; set; }

        public DateTime IssuedOn { get; set; }

        public TransportType TransportType { get; set; }

        public int CompanyId { get; set; }
        public TravelCompanyServiceModel Company { get; set; }

        public int DestinationId { get; set; }
        public DestinationServiceModel Destination { get; set; }
    }
}
