using Microsoft.EntityFrameworkCore;
using SD_340_W22SD_Labs.Models;

namespace SD_340_W22SD_Labs.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<SD_340_W22SD_Labs.Models.Route> Route { get; set; } = default!;
        public DbSet<SD_340_W22SD_Labs.Models.ScheduledStop> ScheduledStop { get; set; } = default!;
        public DbSet<SD_340_W22SD_Labs.Models.Stop> Stop { get; set; } = default!;
    }
}
