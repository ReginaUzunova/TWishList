

namespace TWishList.Web.Areas.Administration.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class HomeController : AdminController
    {
        public IActionResult Index()
        {
            return this.View();
        }

    }
}
