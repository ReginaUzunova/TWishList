namespace TWishList.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using TWishList.Data;
    using TWishList.Data.Models;
    using TWishList.Services.Mapping;
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

        public IEnumerable<CompanyRequestServiceModel> GetAll()
        {
            //this.context.CompanyRequests.Include

            IEnumerable<CompanyRequestServiceModel> list = this.context.CompanyRequests.Include(x => x.Country).OrderBy(x => x.CreatedOn).To<CompanyRequestServiceModel>().ToList();

            return list;
        }

        
    }
}
