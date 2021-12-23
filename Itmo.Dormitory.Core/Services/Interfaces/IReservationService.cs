using Itmo.Dormitory.Core.DTO;
using System;
using System.Collections.Generic;

namespace Itmo.Dormitory.Core.Services.Interfaces
{
    public interface IReservationService
    {
        public void AddReservation(ReservationDTO reservation);
        public ReservationDTO GetReservation(Guid id);
        public void RemoveReservation(Guid id);
        public IEnumerable<ReservationDTO> GetAllReservations();
        public IEnumerable<ReservationDTO> GetAllUserReservations(string username);
    }
}
