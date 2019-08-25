using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TWishList.Services.Data;

namespace TWishList.Web.Areas.Administration.Controllers
{
    public class TravelCompanyController
    {
        private readonly ITravelCompanyService travelCompanyService;

        public TravelCompanyController(ITravelCompanyService travelCompanyService)
        {
            this.travelCompanyService = travelCompanyService;
        }

        public async Task<IActionResult> CreateTravelCompany()
        {

        }
    }
}
