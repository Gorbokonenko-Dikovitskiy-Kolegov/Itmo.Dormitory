using AutoMapper;
using Itmo.Dormitory.Core.DTO;
using Itmo.Dormitory.Core.Services.Interfaces;
using Itmo.Dormitory.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Itmo.Dormitory.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IReservationService  _reservationService;
        private readonly IMapper _toDTOmapper;
        private readonly IMapper _fromDTOmapper;
        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
            _toDTOmapper = new MapperConfiguration(cfg => cfg.CreateMap<ReservationModel, ReservationDTO>()).CreateMapper();
            _fromDTOmapper = new MapperConfiguration(cfg => cfg.CreateMap<ReservationDTO, ReservationModel>()).CreateMapper();
        }

        public void AddReservation()
        {
            var reservation = new ReservationModel()
            {
                Id = Guid.NewGuid(),
                Date = DateTime.Now,
                Owner = "Billy Bons",
            };
            _reservationService.AddReservation(_toDTOmapper.Map<ReservationModel, ReservationDTO>(reservation));
        }

        public List<ReservationModel> GetAllReservations()
        {
            return _fromDTOmapper.Map<IEnumerable<ReservationDTO>, List<ReservationModel>>(_reservationService.GetAllReservations());
        }

        public void RemoveReservation(Guid id)
        {
            _reservationService.RemoveReservation(id);
        }

        public List<ReservationModel> GetAllUserReservations(string username)
        {
            return _fromDTOmapper.Map<IEnumerable<ReservationDTO>, List<ReservationModel>>(_reservationService.GetAllUserReservations(username));
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
