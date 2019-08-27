namespace TWishList.Web.Middlewares
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using System.Linq;
    using System.Threading.Tasks;
    using TWishList.Common;
    using TWishList.Data;
    using TWishList.Data.Models.Identity;

    public class SeedMiddleware
    {
        private readonly RequestDelegate next;

        public SeedMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(
            HttpContext httpContext,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            TWishListDbContext dbContext)
        {
            SeedRoles(roleManager).GetAwaiter().GetResult();

            SeedUserInRoles(userManager).GetAwaiter().GetResult();

            await this.next(httpContext);
        }

        private static async Task SeedRoles(RoleManager<ApplicationRole> roleManager)
        {
            if (!await roleManager.RoleExistsAsync(GlobalConstants.AdministratorRoleName))
            {
                await roleManager.CreateAsync(new ApplicationRole(GlobalConstants.AdministratorRoleName));
            }

            if (!await roleManager.RoleExistsAsync(GlobalConstants.CompanyRoleName))
            {
                await roleManager.CreateAsync(new ApplicationRole(GlobalConstants.CompanyRoleName));
            }

            if (!await roleManager.RoleExistsAsync(GlobalConstants.UserRoleName))
            {
                await roleManager.CreateAsync(new ApplicationRole(GlobalConstants.UserRoleName));
            }
        }

        private static async Task SeedUserInRoles(UserManager<ApplicationUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new ApplicationUser
                {
                    UserName = GlobalConstants.AdministratorUsername,
                    Email = GlobalConstants.AdministratorEmail,
                    FullName = GlobalConstants.AdministratorFullName,
                };

                var result = await userManager.CreateAsync(user, GlobalConstants.AdministratorPassword);

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, GlobalConstants.AdministratorRoleName);
                }
            }
        }
    }
}
