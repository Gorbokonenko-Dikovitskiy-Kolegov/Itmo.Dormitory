using Itmo.Dormitory.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itmo.Dormitory.Core.Services.Interfaces
{
    public interface IAnnouncementService
    {
        public List<AnnouncementDTO> GetAllAnnouncements();
        public AnnouncementDTO GetAnnouncement(Guid id);
        public void RemoveAnnouncement(Guid id);
        public void UpdateAnnouncement(Guid id, AnnouncementDTO newAnnouncement);
        public void AddAnnouncement(AnnouncementDTO announcement);
    }
}
