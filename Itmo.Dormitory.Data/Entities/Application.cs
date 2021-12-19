using System;

namespace Itmo.Dormitory.Data.Entities
{
    public class Application
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string  Owner { get; set; }
        public bool Status { get; set; }
        public ApplicationType applicationType { get; set; }
    }
}
