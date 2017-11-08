using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using RestBackendApp.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RestBackendApp.IntegrationTests
{
    public class RestEndpointShould
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public RestEndpointShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnOkStatusForDoubling()
        {
            var response = await Client.GetAsync("/doubling");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnOkStatusForGreeter()
        {
            var response = await Client.GetAsync("/greeter");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
