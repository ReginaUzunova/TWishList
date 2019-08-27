namespace TWishList.Services.Data
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TWishList.Common;
    using TWishList.Data;
    using TWishList.Data.Models;
    using TWishList.Data.Models.Identity;
    using TWishList.Services.Mapping;
    using TWishList.Services.Models;

    public class TravelCompanyService : ITravelCompanyService
    {
        private readonly TWishListDbContext context;
        private readonly ICompanyRequestService companyRequestService;
        private readonly UserManager<ApplicationUser> userManager;

        public TravelCompanyService(
            TWishListDbContext context,
            ICompanyRequestService companyRequestService,
            UserManager<ApplicationUser> userManager)
        {
            this.context = context;
            this.companyRequestService = companyRequestService;
            this.userManager = userManager;
        }

        public async Task<bool> Create(TravelCompanyServiceModel travelCompanyServiceModel)
        {
            TravelCompany travelCompany = travelCompanyServiceModel.To<TravelCompany>();

            this.context.TravelCompanies.Add(travelCompany);
            int result = await this.context.SaveChangesAsync();

            return result > 0;
        }


        public bool AddToCompanyRole(string username, string role)
        {
            
            return true;
        }
    }
}
