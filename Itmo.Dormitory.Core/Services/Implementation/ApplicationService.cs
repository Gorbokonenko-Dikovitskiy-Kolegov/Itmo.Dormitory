using AutoMapper;
using Itmo.Dormitory.Core.DTO;
using Itmo.Dormitory.Core.Services.Interfaces;
using Itmo.Dormitory.Data.Entities;
using Itmo.Dormitory.Data.Repositories;
using System;
using System.Collections.Generic;

namespace Itmo.Dormitory.Core.Services.Implementation
{
    public class ApplicationService : IApplicationService
    {
        private readonly GenericRepository<Application> _applicationRepository;
        private readonly IMapper _toDTOmapper;
        private readonly IMapper _fromDTOmapper;
        public ApplicationService(GenericRepository<Application> applicationRepository)
        {
            _applicationRepository = applicationRepository;
            _toDTOmapper = new MapperConfiguration(cfg => cfg.CreateMap<Application, ApplicationDTO>()).CreateMapper();
            _fromDTOmapper = new MapperConfiguration(cfg => cfg.CreateMap<ApplicationDTO,Application>()).CreateMapper();
        }
        public void AddApplication(ApplicationDTO application)
        { 
            _applicationRepository.Add(_fromDTOmapper.Map<ApplicationDTO, Application>(application));
        }
        public ApplicationDTO GetApplication(Guid id)
        {
            var application = _applicationRepository.FindById(id);
            return _toDTOmapper.Map<Application, ApplicationDTO>(application);
        }
        public void RemoveApplication(Guid id)
        {
            _applicationRepository.Remove(id);
        }

        public IEnumerable<ApplicationDTO> GetAllApplications()
        {
            return _toDTOmapper.Map<IEnumerable<Application>, List<ApplicationDTO>>(_applicationRepository.GetAll());
        }
    }
}
