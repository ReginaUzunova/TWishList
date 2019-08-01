using System;
using System.Collections.Generic;
using System.Text;

namespace TWishList.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using TWishList.Data.Common.Models;

    public class OfferCategory : BaseModel<int>
    {
        public OfferCategory()
        {
            this.Offers = new HashSet<Offer>();
        }

        public string Name { get; set; }

        public virtual ICollection<Offer> Offers { get; set; }
    }
}
