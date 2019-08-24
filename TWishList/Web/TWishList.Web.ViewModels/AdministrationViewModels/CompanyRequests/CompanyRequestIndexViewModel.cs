using System;
using System.Collections.Generic;
using System.Text;

namespace TWishList.Web.ViewModels.AdministrationViewModels.CompanyRequests
{
    public class CompanyRequestIndexViewModel
    {
        public IList<CompanyRequestViewModel> CompanyRequestViewModels { get; set; }

        public CompanyRequestViewModel CompanyRequestViewModel { get; set; }
    }
}
