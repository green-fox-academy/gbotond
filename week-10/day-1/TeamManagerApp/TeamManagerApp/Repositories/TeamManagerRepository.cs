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

        public List<Post> GetPost()
        {
            return TeamManagerContext.Posts.ToList();
        }

        //public List<Player> GetStats()
        //{
        //    return TeamManagerContext.Stats.ToList();
        //}

        public void AddPost(Post post)
        {
            TeamManagerContext.Posts.Add(post);
            TeamManagerContext.SaveChanges();
        }

        public Post GetID(long id)
        {
            return TeamManagerContext.Posts.FirstOrDefault(p => p.Id == id);
        }

        public void UpvotePost(Post oldpost)
        {
            var newpost = TeamManagerContext.Posts.FirstOrDefault(p => p.Id == oldpost.Id);
            newpost.UpVote++;
            TeamManagerContext.SaveChanges();
        }

        public void DownvotePost(Post oldpost)
        {
            var newpost = TeamManagerContext.Posts.FirstOrDefault(p => p.Id == oldpost.Id);
            newpost.DownVote++;
            TeamManagerContext.SaveChanges();
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

        public void DeletePlayer(string name)
        {
            Player deletedPlayer = TeamManagerContext.Players.FirstOrDefault(x => x.Name == name);
            TeamManagerContext.Players.Remove(deletedPlayer);
            TeamManagerContext.SaveChanges();
        }

        public void UpdateTodo(Player player)
        {
            TeamManagerContext.Players.Update(player);
            TeamManagerContext.SaveChanges();
        }
    }
}
