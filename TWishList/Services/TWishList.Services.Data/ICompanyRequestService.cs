using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace TWishList.Services.Data
{
    using System.Threading.Tasks;
    using TWishList.Services.Models;

    public interface ICompanyRequestService
    {
        void CreateRequest(CompanyRequestServiceModel serviceModel);

        IEnumerable<CompanyRequestServiceModel> GetAll();

        CompanyRequestServiceModel GetById(int id);
    }
}
