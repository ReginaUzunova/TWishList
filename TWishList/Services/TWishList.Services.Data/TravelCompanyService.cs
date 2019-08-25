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
    using TWishList.Services.Mapping;
    using TWishList.Services.Models;

    public class TravelCompanyService : ITravelCompanyService
    {
        private readonly TWishListDbContext context;
        private readonly ICompanyRequestService companyRequestService;

        public TravelCompanyService(TWishListDbContext context, ICompanyRequestService companyRequestService, RoleManager roleManager)
        {
            this.context = context;
            this.companyRequestService = companyRequestService;
        }

        public async Task<bool> CreateTravelCompany(CompanyRequestServiceModel companyRequestServiceModel)
        {
            var currentCompanyRequestServiceModel = this.companyRequestService.GetById(companyRequestServiceModel.Id);

            var temporaryPassword = TemporaryPasswordGenerator();
            var username = UsernameGenerator(companyRequestServiceModel.Name);

            var travelCompanyServiceModel = currentCompanyRequestServiceModel.To<TravelCompanyServiceModel>();

            travelCompanyServiceModel.Username = username;
            travelCompanyServiceModel.Password = temporaryPassword;

            TravelCompany travelCompany = travelCompanyServiceModel.To<TravelCompany>();

            this.context.TravelCompanies.Add(travelCompany);
            int result = await this.context.SaveChangesAsync();

            return result > 0;
        }

        public bool AddToRole(string username, string role)
        {
            if (context.Roles.Contains(GlobalConstants.CompanyRoleName))
            {

            }
            var user = GetUserByUsername(username);

            this.userManager.AddToRoleAsync(user, role).GetAwaiter().GetResult();
            return true;
        }

        private string TemporaryPasswordGenerator()
        {
            int passwordLenght = 10;
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            StringBuilder randomPassword = new StringBuilder(passwordLenght);
            Random random = new Random(passwordLenght);

            for (int i = 0; i < passwordLenght; i++)
            {
                randomPassword.Append(characters[random.Next(characters.Length)]);
            }

            return randomPassword.ToString();
        }

        private string UsernameGenerator(string companyName)
        {
            int randomLenght = 5;
            string characters = "0123456789";

            StringBuilder randomUsername = new StringBuilder(randomLenght);
            Random random = new Random(randomLenght);

            for (int i = 0; i < randomLenght; i++)
            {
                randomUsername.Append(characters[random.Next(characters.Length)]);
            }

            return companyName + randomUsername.ToString();
        }

    }
}
