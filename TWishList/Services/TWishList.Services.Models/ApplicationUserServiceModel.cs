using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using TWishList.Data.Models.Identity;
using TWishList.Services.Mapping;

namespace TWishList.Services.Models
{
    public class ApplicationUserServiceModel : IdentityUser, IMapFrom<ApplicationUser>
    {
        public string FullName { get; set; }

        public HashSet<DesirableDestinationServiseModel> DesirableDestinations { get; set; }
    }
}
