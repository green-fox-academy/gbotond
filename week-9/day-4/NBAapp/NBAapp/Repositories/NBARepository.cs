using NBAapp.Entities;
using NBAapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBAapp.Repositories
{
    public class NBARepository
    {
        NBAContext NBAContext;

        public NBARepository(NBAContext nbaContext)
        {
            NBAContext = nbaContext;
        }

        public void AddPlayer(Player player)
        {
            NBAContext.Players.Add(player);
            NBAContext.SaveChanges();
        }

        public Player GetPlayer(string name)
        {
            var specPlayer = NBAContext.Players.FirstOrDefault(player => player.Name == name);
            return specPlayer;
        }

        public List<Player> GetTeam()
        {
            return NBAContext.Players.ToList();
        }

        public void DeletePlayer(string name)
        {
            Player deletedPlayer = NBAContext.Players.FirstOrDefault(x => x.Name == name);
            NBAContext.Players.Remove(deletedPlayer);
            NBAContext.SaveChanges();
        }

        public void UpdateTodo(Player player)
        {
            NBAContext.Players.Update(player);
            NBAContext.SaveChanges();
        }
    }
}
