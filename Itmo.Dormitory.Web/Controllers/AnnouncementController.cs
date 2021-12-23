using AutoMapper;
using Itmo.Dormitory.Core.DTO;
using Itmo.Dormitory.Core.Services.Interfaces;
using Itmo.Dormitory.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Itmo.Dormitory.Controllers
{
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _toDTOmapper;
        private readonly IMapper _fromDTOmapper;
        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
            _toDTOmapper = new MapperConfiguration(cfg => cfg.CreateMap<AnnouncementModel, AnnouncementDTO>()).CreateMapper();
            _fromDTOmapper = new MapperConfiguration(cfg => cfg.CreateMap<AnnouncementDTO, AnnouncementModel>()).CreateMapper();
        }
        public IActionResult Index()
        {
            var announcements = GetAllAnnouncements();
            return View(announcements);
        }

        public List<AnnouncementModel> GetAllAnnouncements()
        {
            return _fromDTOmapper.Map<IEnumerable<AnnouncementDTO>, List<AnnouncementModel>>(_announcementService.GetAllAnnouncements());
        }

        public AnnouncementModel GetAnnouncement(Guid id)
        {
            return _fromDTOmapper.Map<AnnouncementDTO, AnnouncementModel>(_announcementService.GetAnnouncement(id));
        }

        public void RemoveAnnouncement(Guid id)
        {
            _announcementService.RemoveAnnouncement(id);
        }

        public void UpdateAnnouncement(Guid id)
        {

        }

        public void AddAnnouncement()
        {
            var announcement = new AnnouncementModel()
            {
                Id = Guid.NewGuid(),
                CreationTime = DateTime.Now,
                Content = "Добрый день! Тут будет публиковаться важная информация",
                Title = "Важно!"
            };
            _announcementService.AddAnnouncement(_toDTOmapper.Map<AnnouncementModel, AnnouncementDTO>(announcement));
        }
    }
}
