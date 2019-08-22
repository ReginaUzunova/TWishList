using System;
using System.Collections.Generic;
using System.Text;

namespace TWishList.Web.ViewModels.AdministrationViewModels
{
    public class CompanyRequestViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string UniqueIdentifier { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string CompanyWebsite { get; set; }
    }
}
