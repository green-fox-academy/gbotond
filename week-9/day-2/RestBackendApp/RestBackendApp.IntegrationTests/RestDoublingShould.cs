using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RestBackendApp.IntegrationTests
{
    public class RestDoublingShould
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public RestDoublingShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            var response = await Client.GetAsync("doubling");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
