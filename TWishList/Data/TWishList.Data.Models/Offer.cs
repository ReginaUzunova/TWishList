using System;
using System.Collections.Generic;
using System.Text;

namespace TWishList.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using TWishList.Data.Common.Models;
    using TWishList.Data.Models.Enums;

    public class Offer : BaseDeletableModel<int>
    {
        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public DateTime ActiveUntil { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int CategoryId { get; set; }
        public virtual OfferCategory Category { get; set; }

        public int Nights { get; set; }

        public DateTime IssuedOn { get; set; }

        public TransportType TransportType { get; set; }

        [Required]
        public string CompanyId { get; set; }
        public virtual TravelCompany Company { get; set; }

        public int DestinationId { get; set; }
        public virtual Destination Destination { get; set; }
    }
}
