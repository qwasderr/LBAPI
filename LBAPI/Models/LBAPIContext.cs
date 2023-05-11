using Microsoft.EntityFrameworkCore;
namespace LBAPI.Models
{
    public class LBAPIContext: DbContext
    {
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public LBAPIContext(DbContextOptions<LBAPIContext> options) :base(options)
        {
           Database.EnsureCreated();
        }
    }
}
