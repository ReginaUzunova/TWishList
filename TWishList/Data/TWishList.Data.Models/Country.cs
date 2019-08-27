namespace TWishList.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using TWishList.Data.Common.Models;

    public class Country : BaseDeletableModel<int>
    {
        public Country()
        {
            this.Destinations = new HashSet<Destination>();
            this.DesirableDestinations = new HashSet<DesirableDestination>();
        }

        public string Name { get; set; }

        public virtual ICollection<Destination> Destinations { get; set; }

        public virtual ICollection<DesirableDestination> DesirableDestinations { get; set; }

    }
}
