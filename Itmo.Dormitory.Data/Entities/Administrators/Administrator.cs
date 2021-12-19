using System;

namespace Itmo.Dormitory.Data.Entities
{
    abstract public class Administrator
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
