using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagerApp.Entities;
using TeamManagerApp.Models;

namespace TeamManagerApp.Repositories
{
    public class TeamManagerRepository
    {
        TeamManagerContext TeamManagerContext;

        public TeamManagerRepository(TeamManagerContext teamManagerContext)
        {
            TeamManagerContext = teamManagerContext;
        }

        public List<Player> GetTeam()
        {
            return TeamManagerContext.Players.ToList();
        }

        public Player GetPlayer(string name)
        {
            var specPlayer = TeamManagerContext.Players.FirstOrDefault(player => player.Name == name);
            return specPlayer;
        }

        public void AddPlayer(Player player)
        {
            TeamManagerContext.Players.Add(player);
            TeamManagerContext.SaveChanges();
        }
    }
}
