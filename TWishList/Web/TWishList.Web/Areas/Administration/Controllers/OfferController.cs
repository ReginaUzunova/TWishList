using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TWishList.Web.Areas.Administration.Controllers
{
    public class OfferController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}