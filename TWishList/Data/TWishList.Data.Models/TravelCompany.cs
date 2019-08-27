namespace TWishList.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using TWishList.Data.Common.Models;
    using TWishList.Data.Models.Identity;

    public class TravelCompany : BaseDeletableModel<int>
    {
        public TravelCompany()
        {
            this.Offers = new HashSet<Offer>();
        }

        public int RequestId { get; set; }
        public virtual CompanyRequest CompanyRequest { get; set; }

        //public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Offer> Offers { get; set; }
    }
}
