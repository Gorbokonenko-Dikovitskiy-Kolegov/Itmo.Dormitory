using Itmo.Dormitory.Data.Entities;
using Itmo.Dormitory.Data.Repositories;
using System;

namespace Itmo.Dormitory.Core.Services
{
    public class ApplicationService : IApplicationService
    {
        private readonly GenericRepository<Application> _applicationRepository;
        public ApplicationService(GenericRepository<Application> applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }
        public void AddApplication()
        {
            _applicationRepository.Create(new Application() { Id = Guid.NewGuid(), Date = DateTime.Now, Owner = "Marshall Mathers", Status = false, applicationType = ApplicationType.RenewDocuments });
        }
        public void DeleteApplication(Application application)
        {
            _applicationRepository.Remove(application);
        }
    }
}
