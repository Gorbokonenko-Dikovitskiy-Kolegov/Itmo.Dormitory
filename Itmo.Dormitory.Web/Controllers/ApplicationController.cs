using AutoMapper;
using Itmo.Dormitory.Core.DTO;
using Itmo.Dormitory.Core.Services.Interfaces;
using Itmo.Dormitory.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Itmo.Dormitory.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly IApplicationService _applicationService;
        private readonly IMapper _toDTOmapper;
        private readonly IMapper _fromDTOmapper;
        public ApplicationController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
            _toDTOmapper = new MapperConfiguration(cfg => cfg.CreateMap<ApplicationModel, ApplicationDTO>()).CreateMapper();
            _fromDTOmapper = new MapperConfiguration(cfg => cfg.CreateMap<ApplicationDTO, ApplicationModel>()).CreateMapper();
        }
        
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost("addApplication")]
        public void AddApplication()
        {
            var application = new ApplicationModel() { Id = Guid.NewGuid(), Date = DateTime.Now,
                Status = false, Owner = "Marshall Mathers", ApplicationType = "SomeType" };
            _applicationService.AddApplication(_toDTOmapper.Map<ApplicationModel, ApplicationDTO>(application));
        }

        public List<ApplicationModel> GetAllApplications()
        {
            return _fromDTOmapper.Map<IEnumerable<ApplicationDTO>, List<ApplicationModel>>(_applicationService.GetAllApplications());
        }

        public void RemoveApplication(Guid id)
        {
            _applicationService.RemoveApplication(id);
        }
        
        public ApplicationModel GetApplication(Guid id)
        {
            return _fromDTOmapper.Map<ApplicationDTO, ApplicationModel>(_applicationService.GetApplication(id));
        }
    }
}
