namespace TWishList.Web.Areas.Administration.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using TWishList.Services.Data;

    public class CompanyRequestController : AdminController
    {
        private readonly ICompanyRequestService companyRequestService;

        public CompanyRequestController(ICompanyRequestService companyRequestService)
        {
            this.companyRequestService = companyRequestService;
        }

        public IActionResult Index()
        {
            var companyRequests = this.companyRequestService.All().OrderByDescending(x => x.CreatedOn).ToList();

            return this.View();
        }
    }
}
