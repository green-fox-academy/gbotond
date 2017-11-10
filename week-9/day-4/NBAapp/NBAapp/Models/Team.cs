using NBAapp.Entities;
using NBAapp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBAapp.Models
{
    public class Team
    {

        public string Name { get; set; }
        public int Fundation { get; set; }

        //public List<Player> Players { get; set; } = new List<Player>
        //{
        //    new Player("Kyrie Irving", "PG", 25, 1.91, 88, true, Weakness.Defense, Practice.ZoneDefense),
        //    new Player("Terry Rozier", "PG", 25, 1.91, 88, true, Weakness.Shooting, Practice.Shooting),
        //    new Player("Marcus Smart", "SG", 23, 1.93, 99, true, Weakness.Shooting, Practice.Shooting),
        //    new Player("Jaylen Brown", "SG", 21, 2.01, 102, true, Weakness.Passing, Practice.Passing),
        //    new Player("Gordon Hayward", "SF", 27, 2.03, 103, false, Weakness.Defense, Practice.ZoneDefense),
        //    new Player("Jayson Tatum", "SF", 19, 2.03, 95, true, Weakness.Passing, Practice.Passing),
        //    new Player("Aron Baynes", "PF", 30, 2.08, 118, true, Weakness.Positioning, Practice.PickandRoll),
        //    new Player("Marcus Morris", "PF", 28, 2.06, 110, true, Weakness.Passing, Practice.Passing),
        //    new Player("Daniel Theis", "C", 25, 2.10, 111, true, Weakness.Positioning, Practice.ZoneDefense),
        //    new Player("Al Horford", "C", 31, 2.08, 113, true, Weakness.Rebounding, Practice.Rebounding),
        //};

        //public Player GetPlayer(string name)
        //{
        //    var specplayer = Players.FirstOrDefault(player => player.Name == name);
        //    return specplayer;
        //}
    }
}
