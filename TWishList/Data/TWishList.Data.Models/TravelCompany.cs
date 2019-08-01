using System;
using System.Collections.Generic;
using System.Text;

namespace TWishList.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using TWishList.Data.Common.Models;

    public class TravelCompany : BaseModel<int>
    {
        public TravelCompany()
        {
            this.Offers = new HashSet<Offer>();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Information { get; set; }

        public DateTime ActiveSince { get; set; }

        public virtual ICollection<Offer> Offers { get; set; }
    }
}
