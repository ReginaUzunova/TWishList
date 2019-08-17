namespace TWishList.Services.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using TWishList.Data.Models;
    using TWishList.Services.Mapping;

    public class DesirableDestinationServiseModel : IMapFrom<DesirableDestination>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int CountryId { get; set; }
        public CountryServiceModel Country { get; set; }

        public string UserId { get; set; }
        public ApplicationUserServiceModel User { get; set; }

    }
}
