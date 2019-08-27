namespace TWishList.Services.Data
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TWishList.Data;
    using TWishList.Data.Models.Identity;
    using TWishList.Services.Mapping;
    using TWishList.Services.Models;

    public class UserService : IUserService
    {
        private readonly TWishListDbContext context;
        private readonly UserManager<ApplicationUser> userManager;

        public UserService(TWishListDbContext context, UserManager<ApplicationUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public ApplicationUserServiceModel GetUserById(string username)
        {
            return this.context.Users.To<ApplicationUserServiceModel>().SingleOrDefault(user => user.UserName == username);
        }
    }
}
