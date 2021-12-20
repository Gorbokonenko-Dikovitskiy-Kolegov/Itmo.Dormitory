using Itmo.Dormitory.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Itmo.Dormitory.Data.Contexts
{
    public class DormitoryContext : DbContext
    {
        public DbSet<Announcement> Announcements { get; private set; }
        public DbSet<Application> Applications { get; private set; }
        public DbSet<Reservation> Reservations { get; private set; }

        public DormitoryContext(DbContextOptions<DormitoryContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
