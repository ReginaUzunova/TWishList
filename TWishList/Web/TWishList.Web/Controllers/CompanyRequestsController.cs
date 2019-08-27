using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TWishList.Services.Data;
using TWishList.Services.Mapping;
using TWishList.Services.Models;
using TWishList.Web.InputModels;
using TWishList.Web.ViewModels;

namespace TWishList.Web.Controllers
{
    public class CompanyRequestsController : BaseController
    {
        private readonly ICompanyRequestService companyRequestService;
        private readonly IUserService userService;

        public CompanyRequestsController(ICompanyRequestService companyRequestService, IUserService userService)
        {
            this.companyRequestService = companyRequestService;
            this.userService = userService;
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CompanyRequestInputModel companyRequestInputModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(companyRequestInputModel);
            }

            var companyRequestServiceModel = companyRequestInputModel.To<CompanyRequestServiceModel>();

            companyRequestServiceModel.UserId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            await this.companyRequestService.Create(companyRequestServiceModel);

            return RedirectToAction("Index", "Home");
        }
    }
}
