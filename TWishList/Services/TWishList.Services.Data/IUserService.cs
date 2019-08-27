using System;
using System.Collections.Generic;
using System.Text;
using TWishList.Data.Models.Identity;
using TWishList.Services.Models;

namespace TWishList.Services.Data
{
    public interface IUserService
    {
        ApplicationUserServiceModel GetUserById(string id);
    }
}
