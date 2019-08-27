using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TWishList.Data.Common.Models;
using TWishList.Data.Models.Identity;

namespace TWishList.Data.Models
{
    public class CompanyRequest : BaseDeletableModel<int>
    {
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string CompanyUniqueIdentifier { get; set; }

        [Required]
        public string CompanyLiablePerson { get; set; }

        [Required]
        public string CompanyEmail { get; set; }

        [Required]
        public string CompanyPhoneNumber { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

        [Required]
        public string City { get; set; }

        public string CompanyWebsite { get; set; }

        public virtual TravelCompany TravelCompany { get; set; }
    }
}
