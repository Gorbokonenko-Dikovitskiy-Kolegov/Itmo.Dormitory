using AutoMapper;
using Itmo.Dormitory.Core.DTO;
using Itmo.Dormitory.Core.Services.Interfaces;
using Itmo.Dormitory.Data.Entities;
using Itmo.Dormitory.Data.Repositories;
using System;
using System.Collections.Generic;

namespace Itmo.Dormitory.Core.Services.Implementation
{
    public class ReservationService : IReservationService
    {
        private readonly GenericRepository<Reservation> _reservationRepository;
        private readonly IMapper _toDTOmapper;
        private readonly IMapper _fromDTOmapper;
        public ReservationService(GenericRepository<Reservation> reservationRepository)
        {
            _reservationRepository = reservationRepository;
            _toDTOmapper = new MapperConfiguration(cfg => cfg.CreateMap<Reservation, ReservationDTO>()).CreateMapper();
            _fromDTOmapper = new MapperConfiguration(cfg => cfg.CreateMap<ReservationDTO, Reservation>()).CreateMapper();
        }
        public void AddReservation(ReservationDTO reservation)
        {
            _reservationRepository.Add(_fromDTOmapper.Map<ReservationDTO, Reservation>(reservation));
        }
        public ReservationDTO GetReservation(Guid id)
        {
            var reservation = _reservationRepository.FindById(id);
            return _toDTOmapper.Map<Reservation, ReservationDTO>(reservation);
        }
        public void RemoveReservation(Guid id)
        {
            _reservationRepository.Remove(id);
        }

        public IEnumerable<ReservationDTO> GetAllReservations()
        {
            return _toDTOmapper.Map<IEnumerable<Reservation>, List<ReservationDTO>>(_reservationRepository.GetAll());
        }
        public IEnumerable<ReservationDTO> GetAllUserReservations(string username)
        {
            return _toDTOmapper.Map<IEnumerable<Reservation>, List<ReservationDTO>>(_reservationRepository.Get(x => x.Owner == username));
        }
    }
}
