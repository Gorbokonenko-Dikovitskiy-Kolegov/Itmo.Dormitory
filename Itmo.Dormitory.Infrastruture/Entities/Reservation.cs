using System;

namespace Itmo.Dormitory.Data.Entities
{
    public class Reservation
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Owner { get; set; }
    }
}
