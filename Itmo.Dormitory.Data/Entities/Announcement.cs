using System;

namespace Itmo.Dormitory.Data.Entities
{
    public class Announcement
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime CreationTime { get; set; }
        public string Content { get; set; }
    }
}
