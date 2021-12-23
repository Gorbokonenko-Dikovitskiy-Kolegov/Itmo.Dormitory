using System;

namespace Itmo.Dormitory.Models
{
    public class AnnouncementModel
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
