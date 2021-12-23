using System;
namespace Itmo.Dormitory.Core.DTO
{
    public class AnnouncementDTO
    {
        public Guid Id { get; set; }
        public DateTime CreationTime { get; set; }
        public string Content { get; set; }
    }
}
