using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TWishList.Data.Common.Models;

namespace TWishList.Data.Models
{
    public class CompanyRequest : BaseDeletableModel<int>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string UniqueIdentifier { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }

        [Required]
        public string City { get; set; }

        public string CompanyWebsite { get; set; }
    }
}
