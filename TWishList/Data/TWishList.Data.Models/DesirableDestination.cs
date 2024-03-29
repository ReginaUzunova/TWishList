﻿namespace TWishList.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using TWishList.Data.Common.Models;
    using TWishList.Data.Models.Identity;

    public class DesirableDestination : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        [Required]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
