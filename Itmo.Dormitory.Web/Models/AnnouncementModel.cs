using System;

namespace Itmo.Dormitory.Models
{
    public class AnnouncementModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime CreationTime { get; set; }
        public string Content { get; set; }
    }
}
