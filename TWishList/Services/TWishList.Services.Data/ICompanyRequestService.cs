using System;
using System.Collections.Generic;
using System.Text;
using TWishList.Services.Models;

namespace TWishList.Services.Data
{
    public interface ICompanyRequestService
    {
        void CreateRequest(CompanyRequestServiceModel serviceModel);
    }
}
