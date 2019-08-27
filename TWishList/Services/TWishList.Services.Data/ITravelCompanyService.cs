namespace TWishList.Services.Data
{
    using System.Threading.Tasks;
    using TWishList.Services.Models;

    public interface ITravelCompanyService
    {
        Task<bool> Create(TravelCompanyServiceModel travelCompanyServiceModel);
    }
}
