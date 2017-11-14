using Microsoft.EntityFrameworkCore;
using TeamManagerApp.Models;

namespace TeamManagerApp.Entities
{
    public class TeamManagerContext : DbContext
    {
        public TeamManagerContext(DbContextOptions<TeamManagerContext> options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Post> Posts { get; set; }
        //public DbSet<Player> Stats { get; set; }
    }
}
