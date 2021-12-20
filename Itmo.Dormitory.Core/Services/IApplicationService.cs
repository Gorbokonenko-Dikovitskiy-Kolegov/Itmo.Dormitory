using Itmo.Dormitory.Data.Entities;

namespace Itmo.Dormitory.Core.Services
{
    public interface IApplicationService
    {
        public void AddApplication();
        public void DeleteApplication(Application application);
    }
}
