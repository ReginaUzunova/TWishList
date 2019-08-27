namespace TWishList.Web.Controllers
{
    using System.Diagnostics;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using TWishList.Services.Data;
    using TWishList.Services.Models;
    using TWishList.Web.InputModels;
    using TWishList.Web.Models;

    public class HomeController : BaseController
    {
        private readonly ICompanyRequestService companyRequestService;

        public HomeController(ICompanyRequestService companyRequestService)
        {
            this.companyRequestService = companyRequestService;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
