using Itmo.Dormitory.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Itmo.Dormitory.Data.Contexts
{
    public class DormitoryContext : DbContext
    {
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        public DormitoryContext(DbContextOptions<DormitoryContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=database.db");
        }
        public DormitoryContext()
        {
            Database.EnsureCreated();
        }
    }
}
