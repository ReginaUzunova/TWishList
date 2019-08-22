namespace TWishList.Services.Data
{
    using System.Collections.Generic;
    using TWishList.Data;
    using TWishList.Data.Models;
    using TWishList.Services.Models;

    public class CompanyRequestService : ICompanyRequestService
    {
        private readonly TWishListDbContext context;

        public CompanyRequestService(TWishListDbContext context)
        {
            this.context = context;
        }

        public void CreateRequest(CompanyRequestServiceModel companyRequestServiceModel)
        {
            CompanyRequest companyRequest = AutoMapper.Mapper.Map<CompanyRequest>(companyRequestServiceModel);

            context.CompanyRequests.Add(companyRequest);
            context.SaveChanges();
        }

        public IEnumerable<CompanyRequest> All()
        {
            return context.CompanyRequests;
        }
    }
}
