using Microsoft.EntityFrameworkCore;
using NBAapp.Models;

namespace NBAapp.Entities
{
    public class NBAContext : DbContext
    {
        public NBAContext(DbContextOptions<NBAContext> options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
    }
}
