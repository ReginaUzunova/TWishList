using System;
using System.Collections.Generic;
using System.Text;

namespace TWishList.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class OfferCategory
    {
        public OfferCategory()
        {
            this.Offers = new HashSet<Offer>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Offer> Offers { get; set; }
    }
}
