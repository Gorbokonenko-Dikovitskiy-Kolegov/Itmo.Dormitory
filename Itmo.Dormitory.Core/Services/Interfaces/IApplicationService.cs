using Itmo.Dormitory.Core.DTO;
using System;
using System.Collections.Generic;

namespace Itmo.Dormitory.Core.Services.Interfaces
{
    public interface IApplicationService
    {
        public void AddApplication(ApplicationDTO application);
        public ApplicationDTO GetApplication(Guid id);
        public void RemoveApplication (Guid id);
        public IEnumerable<ApplicationDTO> GetAllApplications();
    }
}
