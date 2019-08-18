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
        private const string RequestInfoMessage = "Thank you, your request has been accepted.";

        private readonly ICompanyRequestService companyRequestService;

        public HomeController(ICompanyRequestService companyRequestService)
        {
            this.companyRequestService = companyRequestService;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult CompanyRequest()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> CompanyRequest(CompanyRequestInputModel companyRequestInputModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(companyRequestInputModel);
            }

            CompanyRequestServiceModel companyRequestServiceModel = AutoMapper.Mapper.Map<CompanyRequestServiceModel>(companyRequestInputModel);

            this.companyRequestService.CreateRequest(companyRequestServiceModel);

            this.TempData["info"] = RequestInfoMessage;

            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
