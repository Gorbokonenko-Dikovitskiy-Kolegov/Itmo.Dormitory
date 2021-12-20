using Itmo.Dormitory.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Itmo.Dormitory.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly IApplicationService _applicationService;
        public ApplicationController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        
        public void AddApplication()
        {
            _applicationService.AddApplication();
        }
    }
}
