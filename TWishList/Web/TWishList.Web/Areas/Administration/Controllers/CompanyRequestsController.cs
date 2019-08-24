namespace TWishList.Web.Areas.Administration.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using TWishList.Services.Data;
    using TWishList.Services.Models;
    using TWishList.Services.Mapping;
    using TWishList.Web.ViewModels.AdministrationViewModels.CompanyRequests;

    public class CompanyRequestsController : AdminController
    {
        private readonly ICompanyRequestService companyRequestService;

        public CompanyRequestsController(ICompanyRequestService companyRequestService)
        {
            this.companyRequestService = companyRequestService;
        }

        public async Task<IActionResult> All()
        {
            IList<CompanyRequestServiceModel> companyRequestServiceModels = this.companyRequestService.GetAll().ToList();

            IList<CompanyRequestViewModel> companyRequestViewModels = companyRequestServiceModels.Select(request => request.To<CompanyRequestViewModel>()).ToList();

            return this.View(companyRequestViewModels);
        }
    }
}
