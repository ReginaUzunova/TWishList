namespace TWishList.Data.Models.Identity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.DesirableDestinations = new HashSet<DesirableDestination>();
        }

        public string FullName { get; set; }

        public virtual ICollection<DesirableDestination> DesirableDestinations { get; set; }
    }
}
