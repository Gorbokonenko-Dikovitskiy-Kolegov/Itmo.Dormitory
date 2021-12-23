using AutoMapper;
using Itmo.Dormitory.Core.DTO;
using Itmo.Dormitory.Core.Services.Interfaces;
using Itmo.Dormitory.Data.Entities;
using Itmo.Dormitory.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itmo.Dormitory.Core.Services.Implementation
{
    public class AnnouncementService : IAnnouncementService
    {
        private readonly GenericRepository<Announcement> _announcementRepository;
        private readonly IMapper _toDTOmapper;
        private readonly IMapper _fromDTOmapper;
        public AnnouncementService(GenericRepository<Announcement> announcementRepository)
        {
            _announcementRepository = announcementRepository;
            _toDTOmapper = new MapperConfiguration(cfg => cfg.CreateMap<Announcement, AnnouncementDTO>()).CreateMapper();
            _fromDTOmapper = new MapperConfiguration(cfg => cfg.CreateMap<AnnouncementDTO, Announcement>()).CreateMapper();
        }
        public void AddAnnouncement(AnnouncementDTO announcement)
        {
            _announcementRepository.Add(_fromDTOmapper.Map<AnnouncementDTO, Announcement>(announcement));
        }

        public List<AnnouncementDTO> GetAllAnnouncements()
        {
            return _toDTOmapper.Map<IEnumerable<Announcement>, List<AnnouncementDTO>>(_announcementRepository.GetAll());
        }

        public AnnouncementDTO GetAnnouncement(Guid id)
        {
           return _toDTOmapper.Map<Announcement, AnnouncementDTO>(_announcementRepository.FindById(id));
        }

        public void RemoveAnnouncement(Guid id)
        {
            _announcementRepository.Remove(id);
        }

        public void UpdateAnnouncement(Guid id, AnnouncementDTO newAnnouncement)
        {
            throw new NotImplementedException();
        }
    }
}
