namespace TWishList.Web.InputModels.AdministrationInputModels
{
    using System;

    public class OfferCreateInputModel
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public DateTime ActiveUntil { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Category { get; set; }

        public int Nights { get; set; }

        public string TransportType { get; set; }

        public string Company { get; set; }

        public string Destination { get; set; }
    }
}
