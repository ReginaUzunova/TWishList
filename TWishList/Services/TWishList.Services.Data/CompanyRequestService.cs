namespace TWishList.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using TWishList.Data;
    using TWishList.Data.Models;
    using TWishList.Services.Mapping;
    using TWishList.Services.Models;

    public class CompanyRequestService : ICompanyRequestService
    {
        private readonly TWishListDbContext context;
        private readonly IUserService userService;

        public CompanyRequestService(TWishListDbContext context, IUserService userService)
        {
            this.context = context;
            this.userService = userService;
        }

        public async Task<bool> Create(CompanyRequestServiceModel companyRequestServiceModel)
        {
            CompanyRequest companyRequest = companyRequestServiceModel.To<CompanyRequest>();

            context.CompanyRequests.Add(companyRequest);
            int result = await context.SaveChangesAsync();

            return result > 0;
        }

        public IEnumerable<CompanyRequestServiceModel> GetAll()
        {
            IEnumerable<CompanyRequestServiceModel> listOfRequests = this.context.CompanyRequests.Include(x => x.Country).Include(x => x.User).OrderBy(x => x.CreatedOn).To<CompanyRequestServiceModel>().ToList();

            return listOfRequests;
        }

        public CompanyRequestServiceModel GetById(string id)
        {
            return this.context.CompanyRequests
                .To<CompanyRequestServiceModel>()
                .SingleOrDefault(request => request.UserId == id);
        }
    }
}
