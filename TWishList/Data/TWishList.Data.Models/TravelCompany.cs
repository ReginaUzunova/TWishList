using System;
using System.Collections.Generic;
using System.Text;

namespace TWishList.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class TravelCompany
    {
        public TravelCompany()
        {
            this.Offers = new HashSet<Offer>();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Information { get; set; }

        public DateTime ActiveSince { get; set; }

        public virtual ICollection<Offer> Offers { get; set; }
    }
}
