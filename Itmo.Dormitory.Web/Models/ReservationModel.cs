using System;

namespace Itmo.Dormitory.Web.Models
{
    public class ReservationModel
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Owner { get; set; }
    }
}
