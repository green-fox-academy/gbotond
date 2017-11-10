using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using NBAapp.Entities;
using NBAapp.Models;
using NBAapp.Repositories;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace NBAapp.IntegrationTests
{
    public class NBAappShould
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public NBAappShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        //[Fact]
        //public async Task ReturnOkStatusForTeamInfo()
        //{
        //    var response = await Client.GetAsync("/teaminfo");

        //    Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        //}

        //[Fact]
        //public async Task ReturnNotFoundStatusWithWrongRoute()
        //{
        //    var response = await Client.GetAsync("/teminfo");
        //    string responseJson = await response.Content.ReadAsStringAsync();

        //    Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        //}

        [Fact]
        public async Task AddPlayer()
        {
            var options = new DbContextOptionsBuilder<NBAContext>().UseInMemoryDatabase
                          (databaseName: "PlayerAddTestDb").Options;

            using (var dbContext = new NBAContext(options))
            {
                var todoRepository = new NBARepository(dbContext);

                dbContext.Players.Add(new Player()
                {
                    Name = "Paul Pierce",
                });
                dbContext.SaveChanges();

                string expected = "Paul Pierce";
                var player = await dbContext.Players.FirstOrDefaultAsync(x => x.Name.Equals("Paul Pierce"));
                Assert.Equal(expected, player.Name);
            }
        }

        [Fact]
        public void DeletePlayer()
        {
            var options = new DbContextOptionsBuilder<NBAContext>().UseInMemoryDatabase
                          (databaseName: "PlayerDelTestDb").Options;

            using (var dbContext = new NBAContext(options))
            {
                var nbaRepository = new NBARepository(dbContext);

                dbContext.Players.Add(new Player()
                {
                    Name = "Kevin Garnett",
                });
                dbContext.SaveChanges();

                var deletedPlayer = dbContext.Players.FirstOrDefault(x => x.Name.Equals("Kevin Garnett"));
                nbaRepository.DeletePlayer(deletedPlayer.Name);
                dbContext.SaveChanges();

                var expected = 0;
                var numberOfPlayers = dbContext.Players.Count();
                Assert.Equal(expected, numberOfPlayers);
            }
        }
    }
}
