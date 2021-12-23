using System;

namespace Itmo.Dormitory.Core.DTO
{
    public class ReservationDTO
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Owner { get; set; }
    }
}
